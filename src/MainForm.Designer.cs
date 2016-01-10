namespace quake_ServerStarter
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.cbAddreses = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.tbCfgName = new System.Windows.Forms.TextBox();
            this.btnSetCfg = new System.Windows.Forms.Button();
            this.openfdialog = new System.Windows.Forms.OpenFileDialog();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbHostName = new System.Windows.Forms.TextBox();
            this.rtbOut = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // cbAddreses
            // 
            this.cbAddreses.BackColor = System.Drawing.SystemColors.WindowText;
            this.cbAddreses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAddreses.ForeColor = System.Drawing.SystemColors.Window;
            this.cbAddreses.FormattingEnabled = true;
            resources.ApplyResources(this.cbAddreses, "cbAddreses");
            this.cbAddreses.Name = "cbAddreses";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.SystemColors.MenuText;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Name = "label3";
            // 
            // tbPort
            // 
            this.tbPort.BackColor = System.Drawing.SystemColors.MenuText;
            resources.ApplyResources(this.tbPort, "tbPort");
            this.tbPort.ForeColor = System.Drawing.SystemColors.Info;
            this.tbPort.Name = "tbPort";
            // 
            // tbCfgName
            // 
            this.tbCfgName.BackColor = System.Drawing.SystemColors.WindowText;
            this.tbCfgName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.tbCfgName, "tbCfgName");
            this.tbCfgName.ForeColor = System.Drawing.SystemColors.Window;
            this.tbCfgName.Name = "tbCfgName";
            this.tbCfgName.ReadOnly = true;
            // 
            // btnSetCfg
            // 
            resources.ApplyResources(this.btnSetCfg, "btnSetCfg");
            this.btnSetCfg.Name = "btnSetCfg";
            this.btnSetCfg.UseVisualStyleBackColor = true;
            this.btnSetCfg.Click += new System.EventHandler(this.btnSetCfg_Click);
            // 
            // openfdialog
            // 
            this.openfdialog.DefaultExt = "cfg";
            this.openfdialog.FileName = "openFileDialog1";
            resources.ApplyResources(this.openfdialog, "openfdialog");
            // 
            // btnAbout
            // 
            resources.ApplyResources(this.btnAbout, "btnAbout");
            this.btnAbout.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnStart
            // 
            resources.ApplyResources(this.btnStart, "btnStart");
            this.btnStart.ForeColor = System.Drawing.SystemColors.Window;
            this.btnStart.Name = "btnStart";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            resources.ApplyResources(this.btnStop, "btnStop");
            this.btnStop.Name = "btnStop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // tbHostName
            // 
            resources.ApplyResources(this.tbHostName, "tbHostName");
            this.tbHostName.Name = "tbHostName";
            // 
            // rtbOut
            // 
            this.rtbOut.BackColor = System.Drawing.SystemColors.HotTrack;
            this.rtbOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbOut.DetectUrls = false;
            resources.ApplyResources(this.rtbOut, "rtbOut");
            this.rtbOut.ForeColor = System.Drawing.SystemColors.Window;
            this.rtbOut.Name = "rtbOut";
            this.rtbOut.ReadOnly = true;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.Controls.Add(this.rtbOut);
            this.Controls.Add(this.tbHostName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnSetCfg);
            this.Controls.Add(this.tbCfgName);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbAddreses);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbAddreses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.TextBox tbCfgName;
        private System.Windows.Forms.Button btnSetCfg;
        private System.Windows.Forms.OpenFileDialog openfdialog;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox tbHostName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtbOut;
    }
}

