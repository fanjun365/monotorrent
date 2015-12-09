namespace torrenut
{
    partial class PreferencesUI
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.torrenutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1Entities3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label_Port = new System.Windows.Forms.Label();
            this.textBox_Port = new System.Windows.Forms.TextBox();
            this.textBox_DownloadsInProgress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.checkbox_enableDHT = new System.Windows.Forms.CheckBox();
            this.button_save = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_dhtPort = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.torrenutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1Entities3BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Port
            // 
            this.label_Port.AutoSize = true;
            this.label_Port.Location = new System.Drawing.Point(315, 13);
            this.label_Port.Name = "label_Port";
            this.label_Port.Size = new System.Drawing.Size(26, 13);
            this.label_Port.TabIndex = 0;
            this.label_Port.Text = "Port";
            // 
            // textBox_Port
            // 
            this.textBox_Port.Location = new System.Drawing.Point(7, 13);
            this.textBox_Port.Name = "textBox_Port";
            this.textBox_Port.Size = new System.Drawing.Size(83, 20);
            this.textBox_Port.TabIndex = 2;
            // 
            // textBox_DownloadsInProgress
            // 
            this.textBox_DownloadsInProgress.Location = new System.Drawing.Point(7, 39);
            this.textBox_DownloadsInProgress.Name = "textBox_DownloadsInProgress";
            this.textBox_DownloadsInProgress.Size = new System.Drawing.Size(302, 20);
            this.textBox_DownloadsInProgress.TabIndex = 6;
            this.textBox_DownloadsInProgress.Click += new System.EventHandler(this.textBox_DownloadsInProgress_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Downloads in progress folder";
            // 
            // checkbox_enableDHT
            // 
            this.checkbox_enableDHT.AutoSize = true;
            this.checkbox_enableDHT.Location = new System.Drawing.Point(224, 65);
            this.checkbox_enableDHT.Name = "checkbox_enableDHT";
            this.checkbox_enableDHT.Size = new System.Drawing.Size(85, 17);
            this.checkbox_enableDHT.TabIndex = 8;
            this.checkbox_enableDHT.Text = "Enable DHT";
            this.checkbox_enableDHT.UseVisualStyleBackColor = true;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(7, 141);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 9;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(88, 141);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 10;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(83, 20);
            this.textBox1.TabIndex = 11;
            // 
            // label_dhtPort
            // 
            this.label_dhtPort.AutoSize = true;
            this.label_dhtPort.Location = new System.Drawing.Point(315, 91);
            this.label_dhtPort.Name = "label_dhtPort";
            this.label_dhtPort.Size = new System.Drawing.Size(51, 13);
            this.label_dhtPort.TabIndex = 12;
            this.label_dhtPort.Text = "DHT port";
            // 
            // PreferencesUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.label_dhtPort);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.checkbox_enableDHT);
            this.Controls.Add(this.textBox_DownloadsInProgress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Port);
            this.Controls.Add(this.label_Port);
            this.Name = "PreferencesUI";
            this.Size = new System.Drawing.Size(625, 204);
            this.Load += new System.EventHandler(this.PreferencesUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.torrenutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1Entities3BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource database1Entities3BindingSource;
        private System.Windows.Forms.BindingSource torrenutBindingSource;
        private System.Windows.Forms.Label label_Port;
        private System.Windows.Forms.TextBox textBox_Port;
        private System.Windows.Forms.TextBox textBox_DownloadsInProgress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.CheckBox checkbox_enableDHT;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_dhtPort;
    }
}
