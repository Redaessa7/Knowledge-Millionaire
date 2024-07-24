namespace Knowledge_Millionaire
{
    partial class FmGameResult
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmGameResult));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.plBoard = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWinMoney = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.picBoxPlayerImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2Shapes1 = new Guna.UI2.WinForms.Guna2Shapes();
            this.plBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPlayerImage)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.AnimationInterval = 200;
            this.guna2BorderlessForm1.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_CENTER;
            this.guna2BorderlessForm1.BorderRadius = 10;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 4200;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // plBoard
            // 
            this.plBoard.BackColor = System.Drawing.Color.Transparent;
            this.plBoard.Controls.Add(this.lblPlayerName);
            this.plBoard.Controls.Add(this.label3);
            this.plBoard.Controls.Add(this.label2);
            this.plBoard.Controls.Add(this.lblWinMoney);
            this.plBoard.Controls.Add(this.guna2PictureBox1);
            this.plBoard.Controls.Add(this.picBoxPlayerImage);
            this.plBoard.Controls.Add(this.guna2Shapes1);
            this.plBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plBoard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(134)))), ((int)(((byte)(33)))));
            this.plBoard.FillColor2 = System.Drawing.Color.Transparent;
            this.plBoard.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.plBoard.Location = new System.Drawing.Point(0, 0);
            this.plBoard.Name = "plBoard";
            this.plBoard.Size = new System.Drawing.Size(948, 450);
            this.plBoard.TabIndex = 0;
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerName.Font = new System.Drawing.Font("Almarai ExtraBold", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPlayerName.Location = new System.Drawing.Point(59, 358);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPlayerName.Size = new System.Drawing.Size(212, 44);
            this.lblPlayerName.TabIndex = 7;
            this.lblPlayerName.Text = "إسم المتسابق";
            this.lblPlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Almarai ExtraBold", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(689, 284);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(158, 44);
            this.label3.TabIndex = 7;
            this.label3.Text = "جنية مصري";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Almarai ExtraBold", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(437, 83);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(304, 58);
            this.label2.TabIndex = 8;
            this.label2.Text = "مبروك لقد ربحت ";
            // 
            // lblWinMoney
            // 
            this.lblWinMoney.BackColor = System.Drawing.Color.Transparent;
            this.lblWinMoney.Font = new System.Drawing.Font("Almarai ExtraBold", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinMoney.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblWinMoney.Location = new System.Drawing.Point(285, 128);
            this.lblWinMoney.Name = "lblWinMoney";
            this.lblWinMoney.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblWinMoney.Size = new System.Drawing.Size(609, 187);
            this.lblWinMoney.TabIndex = 9;
            this.lblWinMoney.Text = "1,000,000";
            this.lblWinMoney.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(113, 262);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(109, 93);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 6;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // picBoxPlayerImage
            // 
            this.picBoxPlayerImage.BackColor = System.Drawing.Color.Transparent;
            this.picBoxPlayerImage.ImageRotate = 0F;
            this.picBoxPlayerImage.Location = new System.Drawing.Point(82, 152);
            this.picBoxPlayerImage.Name = "picBoxPlayerImage";
            this.picBoxPlayerImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picBoxPlayerImage.Size = new System.Drawing.Size(166, 163);
            this.picBoxPlayerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxPlayerImage.TabIndex = 4;
            this.picBoxPlayerImage.TabStop = false;
            this.picBoxPlayerImage.UseTransparentBackground = true;
            // 
            // guna2Shapes1
            // 
            this.guna2Shapes1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Shapes1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(216)))), ((int)(((byte)(67)))));
            this.guna2Shapes1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2Shapes1.BorderThickness = 5;
            this.guna2Shapes1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Shapes1.Location = new System.Drawing.Point(49, 121);
            this.guna2Shapes1.Name = "guna2Shapes1";
            this.guna2Shapes1.PolygonSkip = 1;
            this.guna2Shapes1.Rotate = 0F;
            this.guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Ellipse;
            this.guna2Shapes1.Size = new System.Drawing.Size(232, 224);
            this.guna2Shapes1.TabIndex = 5;
            this.guna2Shapes1.Text = "guna2Shapes1";
            this.guna2Shapes1.UseTransparentBackground = true;
            this.guna2Shapes1.Zoom = 80;
            // 
            // FmGameResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(948, 450);
            this.Controls.Add(this.plBoard);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(948, 450);
            this.MinimumSize = new System.Drawing.Size(948, 450);
            this.Name = "FmGameResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FmGameResult";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FmGameResult_FormClosing);
            this.Load += new System.EventHandler(this.FmGameResult_Load);
            this.plBoard.ResumeLayout(false);
            this.plBoard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPlayerImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Timer Timer;
        private Guna.UI2.WinForms.Guna2GradientPanel plBoard;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWinMoney;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picBoxPlayerImage;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes1;
        private System.Windows.Forms.Label lblPlayerName;
    }
}