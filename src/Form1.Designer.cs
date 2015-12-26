namespace quake_ServerStarter
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.cbAddreses = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.tbCfgName = new System.Windows.Forms.TextBox();
            this.btnSetCfg = new System.Windows.Forms.Button();
            this.openfdialog = new System.Windows.Forms.OpenFileDialog();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbHostName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP:";
            // 
            // cbAddreses
            // 
            this.cbAddreses.BackColor = System.Drawing.SystemColors.WindowText;
            this.cbAddreses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAddreses.ForeColor = System.Drawing.SystemColors.Window;
            this.cbAddreses.FormattingEnabled = true;
            this.cbAddreses.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.cbAddreses.Location = new System.Drawing.Point(74, 12);
            this.cbAddreses.Name = "cbAddreses";
            this.cbAddreses.Size = new System.Drawing.Size(217, 21);
            this.cbAddreses.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.MenuText;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Config file:";
            // 
            // tbPort
            // 
            this.tbPort.BackColor = System.Drawing.SystemColors.MenuText;
            this.tbPort.ForeColor = System.Drawing.SystemColors.Info;
            this.tbPort.Location = new System.Drawing.Point(353, 12);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(52, 20);
            this.tbPort.TabIndex = 5;
            this.tbPort.Text = "27960";
            // 
            // tbCfgName
            // 
            this.tbCfgName.BackColor = System.Drawing.SystemColors.WindowText;
            this.tbCfgName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCfgName.ForeColor = System.Drawing.SystemColors.Window;
            this.tbCfgName.Location = new System.Drawing.Point(74, 60);
            this.tbCfgName.Name = "tbCfgName";
            this.tbCfgName.ReadOnly = true;
            this.tbCfgName.Size = new System.Drawing.Size(273, 20);
            this.tbCfgName.TabIndex = 6;
            this.tbCfgName.Text = "file name";
            // 
            // btnSetCfg
            // 
            this.btnSetCfg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSetCfg.BackgroundImage")));
            this.btnSetCfg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSetCfg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetCfg.Location = new System.Drawing.Point(353, 57);
            this.btnSetCfg.Name = "btnSetCfg";
            this.btnSetCfg.Size = new System.Drawing.Size(52, 23);
            this.btnSetCfg.TabIndex = 7;
            this.btnSetCfg.Text = "Set dir";
            this.btnSetCfg.UseVisualStyleBackColor = true;
            this.btnSetCfg.Click += new System.EventHandler(this.btnSetCfg_Click);
            // 
            // openfdialog
            // 
            this.openfdialog.DefaultExt = "cfg";
            this.openfdialog.FileName = "openFileDialog1";
            this.openfdialog.Filter = "CFG Files|*.cfg";
            // 
            // btnHelp
            // 
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.ForeColor = System.Drawing.SystemColors.Window;
            this.btnHelp.Location = new System.Drawing.Point(12, 175);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 23);
            this.btnHelp.TabIndex = 8;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSave.Location = new System.Drawing.Point(176, 175);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnStart
            // 
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.ForeColor = System.Drawing.SystemColors.Window;
            this.btnStart.Location = new System.Drawing.Point(338, 175);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Location = new System.Drawing.Point(257, 175);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 11;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Server name:";
            // 
            // tbHostName
            // 
            this.tbHostName.Location = new System.Drawing.Point(88, 100);
            this.tbHostName.Name = "tbHostName";
            this.tbHostName.Size = new System.Drawing.Size(317, 20);
            this.tbHostName.TabIndex = 13;
            this.tbHostName.Text = "hostname";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(425, 210);
            this.Controls.Add(this.tbHostName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnSetCfg);
            this.Controls.Add(this.tbCfgName);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbAddreses);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Server GUI for Quake3";
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
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox tbHostName;
        private System.Windows.Forms.Label label4;
    }
}

