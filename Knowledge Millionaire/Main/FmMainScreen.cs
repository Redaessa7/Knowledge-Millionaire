using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Guna.UI2.WinForms;
using MillionerCLassLibrary.cQuestions;
using MillionerCLassLibrary.cSettings;
using NAudio.Wave;

namespace Knowledge_Millionaire
{
    public partial class frmMainScreen : Form
    {

        public ClsSettings settings = new ClsSettings(Application.StartupPath + "Settings.json");
        public CLsQuesitons ListQuesitons;
        public Image backgroundImage;
        public SoundPlayer BackSound;
        public frmMainScreen()
        {
            InitializeComponent();
            RefershData();
            initBackgroundSound();


            this.Paint += new PaintEventHandler(this.frmMainscreen_paint);
            this.DoubleBuffered = true;
        }

        private void frmMainscreen_paint(object sender, PaintEventArgs e)
        {
            if(backgroundImage != null)
            {
                e.Graphics.DrawImage(backgroundImage, new Rectangle(0,0,this.Width,this.Height));
            }

        }

        private async void frmMainScreen_Load(object sender, EventArgs e)
        {
            BackSound.PlayLooping();
            plBackground.FillColor = plBackground.FillColor2 = Color.Transparent;
            plBackground.UseTransparentBackground = true;

            try
            {
                backgroundImage = await Task.Run(() => Image.FromFile(@"C:\Users\speedTECH\Downloads\b73b00fad0a2f24f43739911da68741a (1).jpg"));
                this.Invalidate();
            }
            catch (Exception ex)
            {
                Console.WriteLine("خطا فى تحميل الصوره" + ex.Message);
            }
            // display version 
            this.label1.Text += " " + Application.ProductVersion; 
        }

        public void RefershData()
        {
            settings.Load();
            ListQuesitons = new CLsQuesitons(settings.settings.Data_Source);
            ListQuesitons.Load();
        }

        private void btnStartNewGame_Click(object sender, EventArgs e)
        {
            if (!ListQuesitons.isEmpty())
            {
                FmNewGame fmNewGame = new FmNewGame(this);
                this.Hide();
                fmNewGame.Show();
            }
            else
            {
                MessageBox.Show("لا يوجد اسئلة يرجى تكلم مع الادمن للاضافة بعض الاسئلة");
            }
        }

        private void BtnMlutiBottons_Clicked(object sender, EventArgs e)
        {
            FmSettings fmMultiPurposes = new FmSettings(this);
            this.Hide();
            fmMultiPurposes.Show();
        }

        private void btnDirections_Click(object sender, EventArgs e)
        {
            FmInstructions fmInstructions = new FmInstructions(this);
            this.Hide();
            fmInstructions.Show();
        }

        private void initBackgroundSound()
        {
            BackSound = new SoundPlayer();
            string FilePath = @"D:\C#ProjectsApp\Knowledge Millionaire\Knowledge Millionaire\Sounds\MainGameSound.wav";
            if (!string.IsNullOrEmpty(FilePath))
            {
                BackSound.SoundLocation = FilePath;
            }
        }

    }
}
