using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Knowledge_Millionaire
{
    public partial class FmSettings : Form
    {
        frmMainScreen mainScreen;
        private Image backGroundImage;
        public FmSettings(frmMainScreen mainScreen)
        {
            InitializeComponent();
            this.mainScreen = mainScreen;
            this.DoubleBuffered = true;
            this.Paint += new PaintEventHandler(this.FmSettings_Paint);
            this.backGroundImage = mainScreen.backgroundImage;
        }

        private void FmMultiPurposes_Load(object sender, EventArgs e)
        {
            this.Size = this.mainScreen.Size;
            this.WindowState = this.mainScreen.WindowState;
            this.StartPosition = this.mainScreen.StartPosition;
            this.Icon = this.mainScreen.Icon;
            this.Text = this.mainScreen.Text;
            this.Font = this.mainScreen.Font;
            this.AutoScaleMode = this.mainScreen.AutoScaleMode;

            plBackground.FillColor = plBackground.FillColor2 = Color.Transparent;
            plBackground.UseTransparentBackground = true;

            LoadSettings();
        }

        private void FmSettings_Paint(object sender, PaintEventArgs e)
        {
            if(backGroundImage != null)
            {
                e.Graphics.DrawImage(backGroundImage, new Rectangle(0,0,this.Width,this.Height));
            }
        }

        private void FmMultiPurposes_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainScreen.Show();
        }

        private void btnCancelSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UpdateSettings();
            // save new settings in json file
            mainScreen.settings.Save();
            MessageBox.Show("تم حفظ الاعدادات");
            mainScreen.RefershData();
            this.Close();
        }


        // load settings info
        private void LoadSettings()
        {
            // load settings from json file and add to controls
            this.txtBoxName.Text = mainScreen.settings.settings.Player_Name;
            this.txtBoxFriendName.Text = mainScreen.settings.settings.FriendPlayer_Name;
            this.txtBoxQuestionsData.Text = mainScreen.settings.settings.Data_Source;
            this.chBoxVoiceOver.Checked = mainScreen.settings.settings.Voice_Over;
            this.chBoxSoundEfficts.Checked = mainScreen.settings.settings.Sound_Effects;
        }

        // update Settings info
        private void UpdateSettings()
        {
            mainScreen.settings.settings.Player_Name = this.txtBoxName.Text;
            mainScreen.settings.settings.FriendPlayer_Name = this.txtBoxFriendName.Text;
            mainScreen.settings.settings.Data_Source = this.txtBoxQuestionsData.Text;
            mainScreen.settings.settings.Voice_Over = this.chBoxVoiceOver.Checked;
            mainScreen.settings.settings.Sound_Effects = this.chBoxSoundEfficts.Checked;
        }

        private void btnImportDataFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog importData = new OpenFileDialog();
            importData.Title = "Import Questions File";
            importData.Filter = "JSON Source File |*.json";

            if(importData.ShowDialog() == DialogResult.OK)
            {
                
                txtBoxQuestionsData.Text = importData.FileName;
            }

        }
    }
}
