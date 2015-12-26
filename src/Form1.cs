#region namespaces
using System;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Diagnostics;
using System.Resources;

using System.Threading;
using System.Globalization;
#endregion

namespace quake_ServerStarter
{
    public partial class Form1 : Form
    {
        const string iniFile = "params.ini";

        IPAddress[] addr;
        Process quake;
        StreamWriter sWriter;
        StreamReader sReader;
        ResourceManager LocRM;

        string host; //dns host name
        string cfgPath; //full path to .cfg file
        string serverPath; //directory with server
        string parametrs; //str with all params to start .exe
        string about;

        bool isRun;


        //public
        public Form1()
        {
            ///Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en");
            ///To test another language


            InitializeComponent();
            #region Сhecks
            if (!File.Exists("quake3.exe"))
            {
                MessageBox.Show("Quake3.exe was not found!", LocRM.GetString("strError"));
                Environment.Exit(0);
            }
            #endregion
            #region LAN's IP 
            host = Dns.GetHostName();
            cbAddreses.Items.Add(IPAddress.Parse("127.0.0.1"));
            addr = Dns.GetHostAddresses(host);
            cbAddreses.Items.AddRange(addr);
            #endregion
            #region InitsAndLoads
            InitAllVars();
            loadSettingsFromFile();
            #endregion

        }


        //private
        private void InitAllVars()
        {
            //strings
            serverPath = Environment.CurrentDirectory;
            about = String.Format("Version: {0}\n",
                System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString());

            //bools
            isRun = false;

            //Localization
            LocRM = new ResourceManager("quake_ServerStarter.Resources.Strings", typeof(Resources.Strings).Assembly);
        }
        private void loadSettingsFromFile()
        {
            string buff;
            if (File.Exists(iniFile))
            {
                sReader = new StreamReader(iniFile);
                while (!sReader.EndOfStream)
                {
                    buff = sReader.ReadLine();
                    switch (buff.Substring(0, buff.IndexOf('=')))
                    {
                        default:
                            break;
                        case "ip_adress":
                            try //try add finded in .ini file ip adress
                            {
                                if ((cbAddreses.SelectedIndex = cbAddreses.Items.IndexOf(IPAddress.Parse(buff.Substring(buff.IndexOf('=') + 1)))) == -1)
                                {
                                    MessageBox.Show("Loaded IP wasn't founded in the available IP list", LocRM.GetString("strWarning"));
                                    cbAddreses.Items.Add(IPAddress.Parse(buff.Substring(buff.IndexOf('=') + 1)));
                                    cbAddreses.SelectedIndex = cbAddreses.Items.Count - 1;
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, LocRM.GetString("strError"));
                                cbAddreses.SelectedIndex = 0;
                            }
                            break;
                        case "port":
                            try
                            {
                                if ((buff.Length - buff.IndexOf('=') - 1) != 5)
                                    MessageBox.Show("Port must have 5 numbers!", LocRM.GetString("strWarning"));
                                else
                                    tbPort.Text = buff.Substring(buff.IndexOf('=')+1);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, LocRM.GetString("strError"));
                            }
                            break;
                        case "cfg_name":
                            try
                            {
                                if ((buff.Length - buff.IndexOf('=') - 1) == 0) //if string is empty
                                {
                                    break;
                                }
                                else if (buff.Contains(".cfg")) //if contains ".cfg" extension
                                {
                                    if (!File.Exists(buff.Substring(buff.IndexOf('=')+1)))
                                    {
                                        MessageBox.Show(LocRM.GetString("strCantLoad"), LocRM.GetString("strError"));
                                        break;
                                    }
                                    else
                                    {
                                        tbCfgName.Text = buff.Substring(buff.IndexOf('=') + 1);
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, LocRM.GetString("strError"));
                            }
                            break;
                        case "hostname":
                            tbHostName.Text = buff.Substring(buff.IndexOf('=') + 1);
                            break;
                    }
                }
                sReader.Close();
            }
            else
                cbAddreses.SelectedIndex = 0;
        }
        private void btnSetCfg_Click(object sender, EventArgs e)
        {
            if (openfdialog.ShowDialog() == DialogResult.Cancel) return;
            cfgPath = openfdialog.FileName;
            tbCfgName.Text = openfdialog.SafeFileName;
            //copying .cfg to server directory
            if (!File.Exists(openfdialog.SafeFileName)) File.Copy(cfgPath, serverPath + "\\" + openfdialog.SafeFileName);
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (isRun)
            {
                MessageBox.Show(LocRM.GetString("strSerAlrRun"), LocRM.GetString("strError"));
                return;
            }

            parametrs = String.Format("+set dedicated 1 +set fs_game osp +set net_ip {0} +set net_port {1} +exec {2} +set sv_hostname {3}", 
                cbAddreses.SelectedItem.ToString(), 
                tbPort.Text, 
                tbCfgName.Text, //name of .cfg
                tbHostName.Text);

            quake = Process.Start("Quake3.exe", parametrs);
            
            isRun = true;
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                if (!quake.HasExited)
                {
                    quake.Kill();
                    quake.Close();
                }
            }
            catch (NullReferenceException)
            {
            }
            catch (InvalidOperationException)
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, LocRM.GetString("strError"));
            }
            finally
            {
                isRun = false;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            sWriter = new StreamWriter(iniFile);
            sWriter.Write("ip_adress={0}\nport={1}\ncfg_name={2}\nhostname={3}",
                cbAddreses.SelectedItem.ToString(),
                tbPort.Text,
                tbCfgName.Text,
                tbHostName.Text);
            sWriter.Close();
        }
        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(about, LocRM.GetString("strAbout"));
        }
    }
}
