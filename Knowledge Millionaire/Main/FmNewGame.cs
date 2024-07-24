using Guna.UI2.WinForms;
using MillionerCLassLibrary.cQuestions;
using MillionerCLassLibrary.cSettings;
using NAudio.SoundFont;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Knowledge_Millionaire
{
    public struct stPlayer
    {
        public string Name;
        public string FriendName;
        public int Money;
        public short Levels;
    }

    public partial class FmNewGame : Form
    {
        // Main screen of the application
        frmMainScreen mainScreen;
        // Random number generator for selecting question
        private Random randomGenerator = new Random();
        // HashSet to store questions that have already been used
        private HashSet<Question> usedQuestions = new HashSet<Question>();
        // The current question begin presented to the player 
        private Question currentQuestion;
        // Information about the current player
        private stPlayer currentPlayer;
        // Flag indicating whether the "remove two answers" help has been used
        private bool isUsedRemoveTwoAnswerHelp = false;
        // Number of questions displayed so far
        private short countQuestionsDisplayed = 0;

        // Player for playing sound effects
        private SoundPlayer _correctAnswerSound;
        private SoundPlayer _WorngAnswerSound;
        private SoundPlayer _winSound;
        private SoundPlayer _GameBackSound;
        private SoundPlayer _CallingSound;

        // Store AppLication Background Image
        private Image backgroundImage;


        public FmNewGame(frmMainScreen fr)
        {
            InitializeComponent();
            this.mainScreen = fr;
            this.Resize += new System.EventHandler(this.FmNewGame_Resize);
            this.Paint += new PaintEventHandler(this.FmNewGame_Paint);
            this.DoubleBuffered = true;
        }


        private void FmNewGame_Paint(object sender, PaintEventArgs e)
        {
            if(backgroundImage != null)
            {
                e.Graphics.DrawImage(backgroundImage, new Rectangle(0, 0, this.Width, this.Height));
            }
        }

        private void FmNewGame_Load(object sender, EventArgs e)
        {
            this.Icon = this.mainScreen.Icon;
            this.Text = this.mainScreen.Text;
            this.WindowState = this.mainScreen.WindowState;
            this.StartPosition = this.mainScreen.StartPosition;
            this.AutoScaleMode = this.mainScreen.AutoScaleMode;
            try
            {
                backgroundImage = mainScreen.backgroundImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في تحميل صورة الخلفية: " + ex.Message);
            }
            this.plGameBoard.FillColor = plGameBoard.FillColor2 = Color.Transparent;
            plGameBoard.UseTransparentBackground = true;

            this.currentPlayer.Name = this.mainScreen.settings.settings.Player_Name;
            this.currentPlayer.FriendName = this.mainScreen.settings.settings.FriendPlayer_Name;
            this.currentPlayer.Levels = 0;

            //initTimerBetweenQuestion();
            initVoice_Over(mainScreen.settings.settings.Voice_Over);
            StartGame();
        }

        private void FmNewGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainScreen.BackSound.PlayLooping();
            mainScreen.Show();
        }

        private void FmNewGame_Resize(object sender, EventArgs e)
        {

            AdjustFlowLayoutPanelPadding();
            this.Invalidate();
        }

        private void AdjustFlowLayoutPanelPadding()
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                // ضبط الـ Padding عند التكبير
                flowLayoutPanelHelpTools.Padding = new Padding((flowLayoutPanelHelpTools.ClientSize.Width - 180) / 2,8,5,5);
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                
                // ضبط الـ Padding عند التصغير
                flowLayoutPanelHelpTools.Padding = new Padding(350, 8, 5, 5);
            }
        }



        // For Testing :Sounds
        private void initVoice_Over(bool onSoundEffect)
        {
            _correctAnswerSound = new SoundPlayer();
            _WorngAnswerSound = new SoundPlayer();
            _winSound = new SoundPlayer();
            _GameBackSound = new SoundPlayer();
            _CallingSound = new SoundPlayer();
            if (onSoundEffect)
            {
                _correctAnswerSound.SoundLocation = @"D:\C#ProjectsApp\Knowledge Millionaire\Knowledge Millionaire\Sounds\CorrectAnswer.wav";
                _WorngAnswerSound.SoundLocation = @"D:\C#ProjectsApp\Knowledge Millionaire\Knowledge Millionaire\Sounds\WrongAnswer.wav";
                _GameBackSound.SoundLocation = @"D:\C#ProjectsApp\Knowledge Millionaire\Knowledge Millionaire\Sounds\QuestionEffect.wav";
                _winSound.SoundLocation = @"D:\C#ProjectsApp\Knowledge Millionaire\Knowledge Millionaire\Sounds\WinEffect.wav";
                _CallingSound.SoundLocation = @"D:\C#ProjectsApp\Knowledge Millionaire\Knowledge Millionaire\Sounds\callsound.mkv";
            }
        }



        //_________ Helps Tools _____________
        private void Gametimer_Tick(object sender, EventArgs e)
        {
            int time = int.Parse(btnStopTimer.Text);
            time--;
            btnStopTimer.Text = time.ToString();
            if (time == 0)
            {
                Gametimer.Stop();
                GameEnd();
            }
        }

        //___ Remove Two Answers
        private void resetAnswersBtns()
        {
            Guna2GradientButton[] btns = { btnAnswer1, btnAnswer2, btnAnswer3, btnAnswer4}; 

            foreach(Guna2GradientButton btn in btns)
            {
                btn.Enabled = true;
                btn.Visible = true;
                btn.FillColor = btn.FillColor2  = Color.Transparent;
            }
        }
        private void RandomRemoveTwoAnswer(string correct_Answer)
        {
            Guna2GradientButton[] btns = { btnAnswer1, btnAnswer2, btnAnswer3, btnAnswer4 };
            int incorrectRemoved = 0; // Track incorrect buttons removed
            Guna2GradientButton btn;
            do
            {
                btn = btns[randomGenerator.Next(0, 4)];
                if(btn.Text != correct_Answer && btn.Enabled == true)
                {
                    btn.Enabled = false;
                    btn.Visible = false;
                    incorrectRemoved++;
                }
            } while (incorrectRemoved < 2);
        }
        private void btnHelpTool1_Click(object sender, EventArgs e)
        {
            RandomRemoveTwoAnswer(currentQuestion.correct_answer);
            btnHelpTool1.Enabled = false;
            isUsedRemoveTwoAnswerHelp = true;
        }

        private void btnHelpTool2_Click(object sender, EventArgs e)
        {
            _CallingSound.Play();
            Thread.Sleep(5000);
            _correctAnswerSound.Stop();
            MessageBox.Show($"يعتقد أن الاجابة الصحيحه هى : {currentQuestion.correct_answer}  {currentPlayer.FriendName} صاحبك\n", "الاتصال بصديق");
            btnHelpTool2.Enabled = false;
            _GameBackSound.Play();
        }

        private void btnHelpTool3_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"يعتقد الجمهور أن الاجابة الصحيحه هى : {currentQuestion.correct_answer}", "مساعدة الجمهور");
            btnHelpTool3.Enabled = false;
        }
        //_____ Withdrawal
        private void btnHelpTool14_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show($"هل تريد حقاً الانسحاب والاحتفاظ بالمبلغ الذى ربحته {currentPlayer.Money}؟", "إنسحاب", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                GameEnd();
            }
        }




        //_____ Questions And Answers Handling ______
        private void loadQuestion(Question question)
        {
            if (question != null)
            {
                lblQustionsText.Text = question.question;
                btnAnswer1.Text = question.options[0];
                btnAnswer2.Text = question.options[1];
                btnAnswer3.Text = question.options[2];
                btnAnswer4.Text = question.options[3];
            }
        }
        private Question GetRandomQuestion(enClassificationQuestions enClassification)
        {
            
            var question = mainScreen.ListQuesitons.GetQuestionsList(enClassification);
            
            // filter out question that have already been used
            var availableQuestions = question.Where(que => !usedQuestions.Contains(que)).ToList();

            if (availableQuestions.Count == 0)
            {
                // Reset used questions set when all question have been used
                usedQuestions.Clear();
                availableQuestions = question; // Get All Questions Again
            }

            // Selecte Random Question from Available Questions
            var randomQuestion = availableQuestions[randomGenerator.Next(0,availableQuestions.Count)];

            // Mark The Selected Question As Used
            usedQuestions.Add(randomQuestion);

            return randomQuestion;
        }
        private bool CheckAnswer(string userAnswer, string CorrectAnswer)
        {
            return userAnswer.Equals(CorrectAnswer);
        }
        private void CorrectAnswerEffect(Guna2GradientButton btnplayerAnswer)
        {
            btnplayerAnswer.FillColor = Color.SpringGreen;
            btnplayerAnswer.FillColor2 = Color.DarkGreen;
            _correctAnswerSound.Play();
            WinnerMsg(enAnswerResultMsg.CorrectAnswer);
        }
        private void IncorrectAnswerEffect(Guna2GradientButton btnplayerAnswer)
        {
            
            btnplayerAnswer.FillColor = Color.Crimson;
            btnplayerAnswer.FillColor2 =Color.DarkRed;
            _WorngAnswerSound.Play();
            WinnerMsg(enAnswerResultMsg.IncorrectAnswer);
        }

        private enClassificationQuestions DetermineLevelOfQuestions(short _countOfQuestions)
        {
            if (_countOfQuestions >= 1 && _countOfQuestions <= 5)
                return enClassificationQuestions.Eesy;
            else if (_countOfQuestions >= 6 && _countOfQuestions <= 10)
                return enClassificationQuestions.Medium;
            else if (_countOfQuestions <= 15)
                return enClassificationQuestions.Hard;
            else return enClassificationQuestions.All;
        }

        private void StartGame()
        {
            _GameBackSound.PlayLooping();
            countQuestionsDisplayed++;
            currentQuestion = GetRandomQuestion(DetermineLevelOfQuestions(countQuestionsDisplayed));
            loadQuestion(currentQuestion);
            btnStopTimer.Text = "60";
            Gametimer.Start();
        }

        // Method to continue the game after receiving the player's answer
        private void ContinueGame(Guna2GradientButton btnplayerAnswer, Question question)
        {
            Gametimer.Stop();
            if (CheckAnswer(btnplayerAnswer.Text, question.correct_answer))
            {
                // Correct Answer Case:
                CorrectAnswerEffect(btnplayerAnswer);
                currentPlayer.Levels++;
                ColorizedEarnMoney(currentPlayer.Levels);
                Application.DoEvents(); // Force UI update
                
                if (currentPlayer.Levels == 15)
                {
                    GameEnd();
                    return;
                }

                resetAnswersBtns();
                StartGame(); // Load the next question

            }
            else
            {
                IncorrectAnswerEffect(btnplayerAnswer);
                // Incorrect Answer Case:  
                Application.DoEvents();
                 Thread.Sleep(1000);
                GameEnd();
            }
        }
        private void submitButtonAnswer_Click(object sender, EventArgs e)
        {
            var btnAnswer = (Guna2GradientButton) sender;
            ContinueGame(btnAnswer, currentQuestion);
        }

        private void ColorizedEarnMoney(short Level)
        {
            switch (Level)
            {
                case 1:
                    currentPlayer.Money = int.Parse(lblMoneyTxt1.Tag.ToString());
                    lblMoneyTxt1.BackColor = Color.FromArgb(254, 216, 67);
                    break;
                case 2:
                    currentPlayer.Money = int.Parse(lblMoneyTxt2.Tag.ToString());
                    lblMoneyTxt2.BackColor = Color.FromArgb(254, 216, 67);
                    break;
                case 3:
                    currentPlayer.Money = int.Parse(lblMoneyTxt3.Tag.ToString());
                    lblMoneyTxt3.BackColor = Color.FromArgb(254, 216, 67);
                    break;
                case 4:
                    currentPlayer.Money = int.Parse(lblMoneyTxt4.Tag.ToString());
                    lblMoneyTxt4.BackColor = Color.FromArgb(254, 216, 67);
                    break;
                case 5:
                    currentPlayer.Money = int.Parse(lblMoneyTxt5.Tag.ToString());
                    lblMoneyTxt5.BackColor = Color.FromArgb(231, 165, 46);
                    break;
                case 6:
                    currentPlayer.Money = int.Parse(lblMoneyTxt6.Tag.ToString());
                    lblMoneyTxt6.BackColor = Color.FromArgb(254, 216, 67);
                    break;
                case 7:
                    currentPlayer.Money = int.Parse(lblMoneyTxt7.Tag.ToString());
                    lblMoneyTxt7.BackColor = Color.FromArgb(254, 216, 67);
                    break;
                case 8:
                    currentPlayer.Money = int.Parse(lblMoneyTxt8.Tag.ToString());
                    lblMoneyTxt8.BackColor = Color.FromArgb(254, 216, 67);
                    break;
                case 9:
                    currentPlayer.Money = int.Parse(lblMoneyTxt9.Tag.ToString());
                    lblMoneyTxt9.BackColor = Color.FromArgb(254, 216, 67);
                    break;
                case 10:
                    currentPlayer.Money = int.Parse(lblMoneyTxt10.Tag.ToString());
                    lblMoneyTxt10.BackColor = Color.FromArgb(231, 165, 46);
                    break;
                case 11:
                    currentPlayer.Money = int.Parse(lblMoneyTxt11.Tag.ToString());
                    lblMoneyTxt11.BackColor = Color.FromArgb(254, 216, 67);
                    break;
                case 12:
                    currentPlayer.Money = int.Parse(lblMoneyTxt12.Tag.ToString());
                    lblMoneyTxt12.BackColor = Color.FromArgb(254, 216, 67);
                    break;

                case 13:
                    currentPlayer.Money = int.Parse(lblMoneyTxt13.Tag.ToString());
                    lblMoneyTxt13.BackColor = Color.FromArgb(254, 216, 67);
                    break;
                case 14:
                    currentPlayer.Money = int.Parse(lblMoneyTxt14.Tag.ToString());
                    lblMoneyTxt14.BackColor = Color.FromArgb(254, 216, 67);
                    break;
                case 15:
                    currentPlayer.Money = int.Parse(lblMoneyTxt15.Tag.ToString());
                    lblMoneyTxt15.BackColor = Color.FromArgb(231, 165, 46);
                    break;
                default:break;
            }
        }

        private void GameEnd()
        {
            this.Controls.Clear();
            FmGameResult fmGameResult = new FmGameResult(currentPlayer, backgroundImage, _winSound);
            fmGameResult.ShowDialog();
            this.Close();
        }

        private void WinnerMsg(enAnswerResultMsg resultMsg)
        {
            FmWinerMsg winerMsg = new FmWinerMsg(resultMsg);
            winerMsg.ShowDialog();
        }

    }
}
