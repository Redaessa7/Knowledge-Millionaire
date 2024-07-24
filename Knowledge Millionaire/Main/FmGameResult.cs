using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Knowledge_Millionaire
{
    public partial class FmGameResult : Form
    {
        private stPlayer player;
        private SoundPlayer _winSound;
        string ImagePath;
        private Image backgroundImage;
        public FmGameResult(stPlayer player, Image background, SoundPlayer winSound)
        {
            InitializeComponent();
            this.player = player;
            ImagePath = @"C:\Users\speedTECH\Downloads\4c6042228823e4a4657dc30425955222.jpg";
            backgroundImage = background;
            this._winSound = winSound;
            
            this.DoubleBuffered = true;
            this.Paint += new PaintEventHandler(this.FmGameResult_Paint);
        }

        private void FmGameResult_Paint(object sender, PaintEventArgs e)
        {
            if(backgroundImage != null)
            {
                e.Graphics.DrawImage(backgroundImage, new Rectangle(0,0,this.Width,this.Height));
            }
        }

        private void LaodPlayerImageAndDisplay()
        {
            if (File.Exists(ImagePath))
            {
                picBoxPlayerImage.Image = Image.FromFile(ImagePath);
            }
            else
            {
                picBoxPlayerImage.Image = null;
            }
        }


        private void FmGameResult_Load(object sender, EventArgs e)
        {
            _winSound.Play();
            LaodPlayerImageAndDisplay();
            SetPlayerInfo();
            Timer.Start();
        }

        private void SetPlayerInfo()
        {
            CultureInfo cultureInfo = new CultureInfo("ar-EG");
            cultureInfo.NumberFormat.CurrencySymbol = "";
            lblWinMoney.Text = player.Money.ToString("C", cultureInfo);

            lblPlayerName.Text = player.Name.ToString();
            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Timer.Stop();
            this.Close();
        }

        private void FmGameResult_FormClosing(object sender, FormClosingEventArgs e)
        {
            _winSound.Stop();
        }
    }
}
