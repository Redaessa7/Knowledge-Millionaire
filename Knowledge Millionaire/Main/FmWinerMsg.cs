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
    public enum enAnswerResultMsg
    {
       CorrectAnswer,
       IncorrectAnswer,
    }

    public partial class FmWinerMsg : Form
    {
        private string PathCorrectImage;
        private string PathIncorrectImage;
        public FmWinerMsg(enAnswerResultMsg answerResultMsg)
        {
            InitializeComponent();
            string MainPath = Application.StartupPath;
            PathCorrectImage = MainPath.Remove(MainPath.IndexOf("Debug")) + @"Images\WinMoney.gif";
            PathIncorrectImage = MainPath.Remove(MainPath.IndexOf("Debug")) + @"Images\LoseMoney.gif";

            initMsg(answerResultMsg);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Timer.Stop();
            this.Close();
        }

        private void initMsg(enAnswerResultMsg answerResultMsg)
        {
            switch (answerResultMsg)
            {
                case enAnswerResultMsg.CorrectAnswer:
                    this.BackColor = Color.MediumSeaGreen;
                    if (File.Exists(PathCorrectImage))
                    {
                        picMsg.Image = Image.FromFile(PathCorrectImage);
                    }
                    lblMsgText.Text = "فلوووووووووووووس";
                    break;
                default:
                    this.BackColor = Color.Crimson;
                    if (File.Exists(PathIncorrectImage))
                    {
                        picMsg.Image = Image.FromFile(PathIncorrectImage);
                    }
                    lblMsgText.Text = "ضااااااااعت الفلوس";
                    break;

            }
        }

    }
}
