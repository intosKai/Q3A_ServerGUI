#region namespaces
using System;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Diagnostics;
using System.Resources;
using Enum;
#endregion

namespace quake_ServerStarter
{
    public partial class MainForm : Form
    {
        const string iniFile = "params.ini";

        IPAddress[] addr;
        Process quake;
        StreamWriter sWriter;
        StreamReader sReader;

        //Localization resource manager
        ResourceManager LocRM = new ResourceManager("quake_ServerStarter.Resources.Strings", typeof(Resources.Strings).Assembly);

        string dnsName; //dns host name
        string cfgPath; //full path to .cfg file
        string serverPath = Environment.CurrentDirectory; //directory with server
        string options; //str with all options to start Quake3.exe
        string about;

        bool isRun = false;

        //constructors:
        public MainForm()
        {
            //To test another language
            //System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo("en");

            InitializeComponent();

            initIP();
            execCheck();
            loadSettingsFromFile();
        }

        //public:


        //private:
        private void execCheck()
        {
            if (!File.Exists("quake3.exe"))
            {
                MsgShow("strNotFoundExe", DialogType.Error);
                Environment.Exit(0);
            }
        }
        private void initIP()
        {
            //defaul local ip and available
            dnsName = Dns.GetHostName();
            cbAddreses.Items.Add(IPAddress.Parse("127.0.0.1"));
            addr = Dns.GetHostAddresses(dnsName);
            cbAddreses.Items.AddRange(addr);
        }
        private void loadSettingsFromFile()
        {
            string temp;
            if (File.Exists(iniFile))
            {
                sReader = new StreamReader(iniFile);
                while (!sReader.EndOfStream)
                {
                    temp = sReader.ReadLine();
                    switch (temp.Substring(0, temp.IndexOf('=')))
                    {
                        default:
                            break;
                        case "ip_adress":
                            loadIPFromFile(temp);
                            break;
                        case "port":
                            loadPortFromFile(temp);
                            break;
                        case "cfg_name":
                            loadCFGNameFromFile(temp);
                            break;
                        case "hostname":
                            //load hostname from file
                            tbHostName.Text = temp.Substring(temp.IndexOf('=') + 1);
                            break;
                    }
                }
                sReader.Close();
            }
            else
                cbAddreses.SelectedIndex = 0;
        }
        private void loadPortFromFile(string strWithSetting)
        {
            try
            {
                if ((strWithSetting.Length - strWithSetting.IndexOf('=') - 1) != 5)
                    MsgShow("strPortOverload", DialogType.Warning);
                else
                    tbPort.Text = strWithSetting.Substring(strWithSetting.IndexOf('=') + 1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, LocRM.GetString("strError"));
            }
        }
        private void loadIPFromFile(string strWithSetting)
        {
            try //try add finded in .ini file ip adress
            {
                if ((cbAddreses.SelectedIndex = cbAddreses.Items.IndexOf(IPAddress.Parse(strWithSetting.Substring(strWithSetting.IndexOf('=') + 1)))) == -1)
                {
                    MsgShow("strNotFoundIP", DialogType.Warning);
                    cbAddreses.Items.Add(IPAddress.Parse(strWithSetting.Substring(strWithSetting.IndexOf('=') + 1)));
                    cbAddreses.SelectedIndex = cbAddreses.Items.Count - 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, LocRM.GetString("strError"));
                cbAddreses.SelectedIndex = 0;
            }
        }
        private void loadCFGNameFromFile(string strWithSetting)
        {
            try
            {
                if ((strWithSetting.Length - strWithSetting.IndexOf('=') - 1) == 0) //if string is empty
                {
                    return;
                }
                else if (strWithSetting.Contains(".cfg")) //if contains ".cfg" extension
                {
                    if (!File.Exists(strWithSetting.Substring(strWithSetting.IndexOf('=') + 1)))
                    {
                        MsgShow("strCantLoad", DialogType.Error);
                        return;
                    }
                    else
                    {
                        tbCfgName.Text = strWithSetting.Substring(strWithSetting.IndexOf('=') + 1);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, LocRM.GetString("strError"));
            }
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

            #region Checks for safe start
            if (isRun)
            {
                MsgShow("strSerAlrRun", DialogType.Error);
                return;
            }
            if (tbPort.Text.Length != 5)
            {
                MsgShow("strPortOverload", DialogType.Error);
                return;
            }
            if (!File.Exists(tbCfgName.Text))
            {
                MsgShow("strCantLoad", DialogType.Error);
                return;
            }
            #endregion

            quake = new Process();
            quake.StartInfo.FileName = "Quake3.exe";

            options = String.Format("+set dedicated 1 +set fs_game osp +set net_ip {0} +set net_port {1} +exec {2} +set sv_hostname {3}", 
                cbAddreses.SelectedItem.ToString(), 
                tbPort.Text, 
                tbCfgName.Text, //name of .cfg
                tbHostName.Text);

            quake.StartInfo.Arguments = options;
            isRun = quake.Start();
            btnStart.Enabled = false;
            btnStop.Enabled = true;
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                if (!quake.HasExited)
                {
                    quake.Kill();
                    quake.Close();
                    btnStart.Enabled = true;
                    btnStop.Enabled = false;
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
            about = String.Format(LocRM.GetString("strVersion") + ": {0}\n",
                System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString());
            MessageBox.Show(about, LocRM.GetString("strAbout"));
            //for v0.3 need about
        }
        private void MsgShow(string text, DialogType boxtype)
        {
            //localized text output to msgbox with typed localized title
            string type = "";
            switch (boxtype)
            {
                case DialogType.Error:
                    type = "strError";
                    break;
                case DialogType.Warning:
                    type = "strWarning";
                    break;
            }
            MessageBox.Show(LocRM.GetString(text), LocRM.GetString(type));
        }
    }
}
