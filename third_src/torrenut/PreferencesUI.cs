using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using System.IO;


namespace torrenut
{
    public partial class PreferencesUI : UserControl
    {
        public PreferencesUI()
        {
            InitializeComponent();                        
        }

       
        private void textBox_DownloadsInProgress_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox_DownloadsInProgress.Text = folderBrowserDialog1.SelectedPath;
            }
        }


        private void PreferencesUI_Load(object sender, EventArgs e)
        {
            ConfigurationStation.Load();
            LoadSettings();
        }

        private void LoadSettings()
        {
            ConfigurationStation.Load();
            textBox_DownloadsInProgress.Text = ConfigurationStation.DownloadsInProgressPath;
            checkbox_enableDHT.Checked = ConfigurationStation.EnableDHT;
            textBox_Port.Text = ConfigurationStation.Port.ToString();
            textBox1.Text = ConfigurationStation.DHTPort.ToString();
        }
        private void SaveSettings()
        {
            ConfigurationStation.DownloadsInProgressPath = textBox_DownloadsInProgress.Text;
            ConfigurationStation.Port = Int32.Parse(textBox_Port.Text );
            ConfigurationStation.EnableDHT = checkbox_enableDHT.Checked;

            ConfigurationStation.DHTPort = Int32.Parse(textBox1.Text);
            ConfigurationStation.Save();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            SaveSettings();
            LoadSettings();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            LoadSettings();
        }
    }
}
