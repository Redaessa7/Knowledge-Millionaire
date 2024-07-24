using MillionerCLassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Knowledge_Millionaire
{
    public partial class FmInstructions : Form
    {
        frmMainScreen mainScreen;
        public FmInstructions(frmMainScreen mainScreen)
        {
            InitializeComponent();
            this.mainScreen = mainScreen;
            this.DoubleBuffered = true;
            this.Paint += new PaintEventHandler(this.FmInstructions_Paint);
        }

        private void FmInstructions_Paint(object sender, PaintEventArgs e)
        {
            if(mainScreen.backgroundImage != null)
            {
                e.Graphics.DrawImage(mainScreen.backgroundImage, new Rectangle(0, 0, this.Width, this.Height));
            }
        }
        private void FmInstructions_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainScreen.Show();
        }

        private void FmInstructions_Load(object sender, EventArgs e)
        {
            this.Size = this.mainScreen.Size;
            this.WindowState = this.mainScreen.WindowState;
            this.StartPosition = this.mainScreen.StartPosition;
            this.Icon = this.mainScreen.Icon;
            this.Text = this.mainScreen.Text;
            this.Font = this.mainScreen.Font;
            this.AutoScaleMode = this.mainScreen.AutoScaleMode;
            this.plBackground.FillColor = this.plBackground.FillColor2 = Color.Transparent;
            initInstructionsTxt();
            //this.lblInstructionsText.Text = mainScreen.instruction;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void initInstructionsTxt()
        {

            string pathFile = @"D:\C#ProjectsApp\Knowledge Millionaire\Knowledge Millionaire\bin\DebugInstructions.txt";
            if (File.Exists(pathFile))
            {
                string Instructions = clsText.Load(pathFile);
                label1.Text = Instructions;
            }
        }
    }
}
