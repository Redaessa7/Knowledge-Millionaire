namespace Knowledge_Millionaire
{
    partial class FmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmSettings));
            this.plBackground = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.flowLayoutPanelSetting = new System.Windows.Forms.FlowLayoutPanel();
            this.plNameContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.txtBoxName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblText = new System.Windows.Forms.Label();
            this.plNameFriendContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.txtBoxFriendName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnImportDataFile = new Guna.UI2.WinForms.Guna2Button();
            this.txtBoxQuestionsData = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.chBoxSoundEfficts = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chBoxVoiceOver = new Guna.UI2.WinForms.Guna2CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancelSave = new Guna.UI2.WinForms.Guna2Button();
            this.picBoxLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.plBackground.SuspendLayout();
            this.flowLayoutPanelSetting.SuspendLayout();
            this.plNameContainer.SuspendLayout();
            this.plNameFriendContainer.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.flowLayoutPanelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // plBackground
            // 
            this.plBackground.BackColor = System.Drawing.Color.Transparent;
            this.plBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plBackground.Controls.Add(this.flowLayoutPanelSetting);
            this.plBackground.Controls.Add(this.picBoxLogo);
            this.plBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plBackground.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(211)))));
            this.plBackground.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(23)))), ((int)(((byte)(106)))));
            this.plBackground.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.plBackground.Location = new System.Drawing.Point(0, 0);
            this.plBackground.Name = "plBackground";
            this.plBackground.Size = new System.Drawing.Size(1055, 634);
            this.plBackground.TabIndex = 1;
            // 
            // flowLayoutPanelSetting
            // 
            this.flowLayoutPanelSetting.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.flowLayoutPanelSetting.Controls.Add(this.plNameContainer);
            this.flowLayoutPanelSetting.Controls.Add(this.plNameFriendContainer);
            this.flowLayoutPanelSetting.Controls.Add(this.guna2Panel2);
            this.flowLayoutPanelSetting.Controls.Add(this.guna2Panel1);
            this.flowLayoutPanelSetting.Controls.Add(this.flowLayoutPanelButtons);
            this.flowLayoutPanelSetting.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelSetting.Location = new System.Drawing.Point(485, 73);
            this.flowLayoutPanelSetting.MaximumSize = new System.Drawing.Size(505, 465);
            this.flowLayoutPanelSetting.Name = "flowLayoutPanelSetting";
            this.flowLayoutPanelSetting.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPanelSetting.Size = new System.Drawing.Size(475, 465);
            this.flowLayoutPanelSetting.TabIndex = 1;
            // 
            // plNameContainer
            // 
            this.plNameContainer.Controls.Add(this.txtBoxName);
            this.plNameContainer.Controls.Add(this.lblText);
            this.plNameContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.plNameContainer.Location = new System.Drawing.Point(3, 3);
            this.plNameContainer.Name = "plNameContainer";
            this.plNameContainer.Padding = new System.Windows.Forms.Padding(0, 0, 10, 5);
            this.plNameContainer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.plNameContainer.Size = new System.Drawing.Size(467, 77);
            this.plNameContainer.TabIndex = 2;
            // 
            // txtBoxName
            // 
            this.txtBoxName.BorderRadius = 2;
            this.txtBoxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxName.DefaultText = "";
            this.txtBoxName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtBoxName.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtBoxName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(134)))), ((int)(((byte)(33)))));
            this.txtBoxName.Font = new System.Drawing.Font("Almarai Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxName.ForeColor = System.Drawing.Color.Black;
            this.txtBoxName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(134)))), ((int)(((byte)(33)))));
            this.txtBoxName.Location = new System.Drawing.Point(0, 40);
            this.txtBoxName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxName.MaxLength = 200;
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.PasswordChar = '\0';
            this.txtBoxName.PlaceholderText = "";
            this.txtBoxName.SelectedText = "";
            this.txtBoxName.Size = new System.Drawing.Size(457, 32);
            this.txtBoxName.TabIndex = 1;
            // 
            // lblText
            // 
            this.lblText.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblText.Font = new System.Drawing.Font("Almarai Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblText.Location = new System.Drawing.Point(0, 0);
            this.lblText.Name = "lblText";
            this.lblText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblText.Size = new System.Drawing.Size(457, 27);
            this.lblText.TabIndex = 0;
            this.lblText.Text = ": اسم المتسابق";
            this.lblText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // plNameFriendContainer
            // 
            this.plNameFriendContainer.Controls.Add(this.txtBoxFriendName);
            this.plNameFriendContainer.Controls.Add(this.label1);
            this.plNameFriendContainer.Location = new System.Drawing.Point(3, 86);
            this.plNameFriendContainer.Name = "plNameFriendContainer";
            this.plNameFriendContainer.Padding = new System.Windows.Forms.Padding(0, 0, 10, 5);
            this.plNameFriendContainer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.plNameFriendContainer.Size = new System.Drawing.Size(467, 77);
            this.plNameFriendContainer.TabIndex = 2;
            // 
            // txtBoxFriendName
            // 
            this.txtBoxFriendName.BorderRadius = 2;
            this.txtBoxFriendName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxFriendName.DefaultText = "";
            this.txtBoxFriendName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxFriendName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxFriendName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxFriendName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxFriendName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtBoxFriendName.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtBoxFriendName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(134)))), ((int)(((byte)(33)))));
            this.txtBoxFriendName.Font = new System.Drawing.Font("Almarai Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxFriendName.ForeColor = System.Drawing.Color.Black;
            this.txtBoxFriendName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(134)))), ((int)(((byte)(33)))));
            this.txtBoxFriendName.Location = new System.Drawing.Point(0, 40);
            this.txtBoxFriendName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxFriendName.MaxLength = 200;
            this.txtBoxFriendName.Name = "txtBoxFriendName";
            this.txtBoxFriendName.PasswordChar = '\0';
            this.txtBoxFriendName.PlaceholderText = "";
            this.txtBoxFriendName.SelectedText = "";
            this.txtBoxFriendName.Size = new System.Drawing.Size(457, 32);
            this.txtBoxFriendName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Almarai Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(457, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = ": اسم صديق المتسابق";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.tableLayoutPanel1);
            this.guna2Panel2.Controls.Add(this.label4);
            this.guna2Panel2.Location = new System.Drawing.Point(3, 169);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Padding = new System.Windows.Forms.Padding(0, 0, 10, 5);
            this.guna2Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.guna2Panel2.Size = new System.Drawing.Size(467, 77);
            this.guna2Panel2.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.96499F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.03501F));
            this.tableLayoutPanel1.Controls.Add(this.btnImportDataFile, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxQuestionsData, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 30);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(457, 42);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnImportDataFile
            // 
            this.btnImportDataFile.Animated = true;
            this.btnImportDataFile.BackColor = System.Drawing.Color.Transparent;
            this.btnImportDataFile.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(134)))), ((int)(((byte)(33)))));
            this.btnImportDataFile.BorderRadius = 5;
            this.btnImportDataFile.BorderThickness = 3;
            this.btnImportDataFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImportDataFile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnImportDataFile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnImportDataFile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnImportDataFile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnImportDataFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnImportDataFile.FillColor = System.Drawing.Color.Transparent;
            this.btnImportDataFile.Font = new System.Drawing.Font("Almarai Bold", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnImportDataFile.ForeColor = System.Drawing.Color.White;
            this.btnImportDataFile.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(23)))), ((int)(((byte)(106)))));
            this.btnImportDataFile.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(215)))), ((int)(((byte)(66)))));
            this.btnImportDataFile.Image = ((System.Drawing.Image)(resources.GetObject("btnImportDataFile.Image")));
            this.btnImportDataFile.Location = new System.Drawing.Point(3, 3);
            this.btnImportDataFile.Name = "btnImportDataFile";
            this.btnImportDataFile.Size = new System.Drawing.Size(49, 36);
            this.btnImportDataFile.TabIndex = 3;
            this.btnImportDataFile.UseTransparentBackground = true;
            this.btnImportDataFile.Click += new System.EventHandler(this.btnImportDataFile_Click);
            // 
            // txtBoxQuestionsData
            // 
            this.txtBoxQuestionsData.BorderRadius = 2;
            this.txtBoxQuestionsData.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxQuestionsData.DefaultText = "";
            this.txtBoxQuestionsData.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxQuestionsData.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxQuestionsData.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxQuestionsData.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxQuestionsData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxQuestionsData.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtBoxQuestionsData.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(134)))), ((int)(((byte)(33)))));
            this.txtBoxQuestionsData.Font = new System.Drawing.Font("Almarai Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxQuestionsData.ForeColor = System.Drawing.Color.Black;
            this.txtBoxQuestionsData.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(134)))), ((int)(((byte)(33)))));
            this.txtBoxQuestionsData.Location = new System.Drawing.Point(59, 5);
            this.txtBoxQuestionsData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxQuestionsData.MaxLength = 200;
            this.txtBoxQuestionsData.Name = "txtBoxQuestionsData";
            this.txtBoxQuestionsData.PasswordChar = '\0';
            this.txtBoxQuestionsData.PlaceholderText = "";
            this.txtBoxQuestionsData.SelectedText = "";
            this.txtBoxQuestionsData.Size = new System.Drawing.Size(394, 32);
            this.txtBoxQuestionsData.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Almarai Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(457, 27);
            this.label4.TabIndex = 0;
            this.label4.Text = ": ملف الأسئلة";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.chBoxSoundEfficts);
            this.guna2Panel1.Controls.Add(this.chBoxVoiceOver);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Location = new System.Drawing.Point(3, 252);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Padding = new System.Windows.Forms.Padding(0, 0, 10, 5);
            this.guna2Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.guna2Panel1.Size = new System.Drawing.Size(467, 98);
            this.guna2Panel1.TabIndex = 2;
            // 
            // chBoxSoundEfficts
            // 
            this.chBoxSoundEfficts.AutoSize = true;
            this.chBoxSoundEfficts.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chBoxSoundEfficts.CheckedState.BorderRadius = 2;
            this.chBoxSoundEfficts.CheckedState.BorderThickness = 0;
            this.chBoxSoundEfficts.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(216)))), ((int)(((byte)(67)))));
            this.chBoxSoundEfficts.Font = new System.Drawing.Font("Almarai Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBoxSoundEfficts.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.chBoxSoundEfficts.Location = new System.Drawing.Point(65, 40);
            this.chBoxSoundEfficts.Name = "chBoxSoundEfficts";
            this.chBoxSoundEfficts.Size = new System.Drawing.Size(143, 28);
            this.chBoxSoundEfficts.TabIndex = 1;
            this.chBoxSoundEfficts.Text = "المؤثرات الصوتية";
            this.chBoxSoundEfficts.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chBoxSoundEfficts.UncheckedState.BorderRadius = 2;
            this.chBoxSoundEfficts.UncheckedState.BorderThickness = 0;
            this.chBoxSoundEfficts.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            // 
            // chBoxVoiceOver
            // 
            this.chBoxVoiceOver.AutoSize = true;
            this.chBoxVoiceOver.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chBoxVoiceOver.CheckedState.BorderRadius = 2;
            this.chBoxVoiceOver.CheckedState.BorderThickness = 0;
            this.chBoxVoiceOver.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(216)))), ((int)(((byte)(67)))));
            this.chBoxVoiceOver.Font = new System.Drawing.Font("Almarai Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBoxVoiceOver.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.chBoxVoiceOver.Location = new System.Drawing.Point(281, 40);
            this.chBoxVoiceOver.Name = "chBoxVoiceOver";
            this.chBoxVoiceOver.Size = new System.Drawing.Size(173, 28);
            this.chBoxVoiceOver.TabIndex = 1;
            this.chBoxVoiceOver.Text = "صوت مقدم المسابقة";
            this.chBoxVoiceOver.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chBoxVoiceOver.UncheckedState.BorderRadius = 2;
            this.chBoxVoiceOver.UncheckedState.BorderThickness = 0;
            this.chBoxVoiceOver.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Almarai Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(457, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = ": الأصوات";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // flowLayoutPanelButtons
            // 
            this.flowLayoutPanelButtons.Controls.Add(this.btnSave);
            this.flowLayoutPanelButtons.Controls.Add(this.btnCancelSave);
            this.flowLayoutPanelButtons.Location = new System.Drawing.Point(3, 356);
            this.flowLayoutPanelButtons.Name = "flowLayoutPanelButtons";
            this.flowLayoutPanelButtons.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanelButtons.Size = new System.Drawing.Size(467, 74);
            this.flowLayoutPanelButtons.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Animated = true;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(134)))), ((int)(((byte)(33)))));
            this.btnSave.BorderRadius = 5;
            this.btnSave.BorderThickness = 3;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSave.FillColor = System.Drawing.Color.Transparent;
            this.btnSave.Font = new System.Drawing.Font("Almarai Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(23)))), ((int)(((byte)(106)))));
            this.btnSave.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(215)))), ((int)(((byte)(66)))));
            this.btnSave.Location = new System.Drawing.Point(247, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(217, 56);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseTransparentBackground = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancelSave
            // 
            this.btnCancelSave.Animated = true;
            this.btnCancelSave.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(134)))), ((int)(((byte)(33)))));
            this.btnCancelSave.BorderRadius = 5;
            this.btnCancelSave.BorderThickness = 3;
            this.btnCancelSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelSave.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancelSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancelSave.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCancelSave.FillColor = System.Drawing.Color.Transparent;
            this.btnCancelSave.Font = new System.Drawing.Font("Almarai Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelSave.ForeColor = System.Drawing.Color.White;
            this.btnCancelSave.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(23)))), ((int)(((byte)(106)))));
            this.btnCancelSave.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(215)))), ((int)(((byte)(66)))));
            this.btnCancelSave.Location = new System.Drawing.Point(5, 3);
            this.btnCancelSave.Name = "btnCancelSave";
            this.btnCancelSave.Size = new System.Drawing.Size(236, 56);
            this.btnCancelSave.TabIndex = 2;
            this.btnCancelSave.Text = "إلغاء";
            this.btnCancelSave.UseTransparentBackground = true;
            this.btnCancelSave.Click += new System.EventHandler(this.btnCancelSave_Click);
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.picBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.picBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLogo.Image")));
            this.picBoxLogo.ImageRotate = 0F;
            this.picBoxLogo.Location = new System.Drawing.Point(78, 182);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(250, 246);
            this.picBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxLogo.TabIndex = 0;
            this.picBoxLogo.TabStop = false;
            this.picBoxLogo.UseTransparentBackground = true;
            // 
            // FmSettings
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelSave;
            this.ClientSize = new System.Drawing.Size(1055, 634);
            this.Controls.Add(this.plBackground);
            this.Name = "FmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmMultiPurposes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FmMultiPurposes_FormClosing);
            this.Load += new System.EventHandler(this.FmMultiPurposes_Load);
            this.plBackground.ResumeLayout(false);
            this.flowLayoutPanelSetting.ResumeLayout(false);
            this.plNameContainer.ResumeLayout(false);
            this.plNameFriendContainer.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.flowLayoutPanelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel plBackground;
        private Guna.UI2.WinForms.Guna2PictureBox picBoxLogo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSetting;
        private Guna.UI2.WinForms.Guna2Panel plNameContainer;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxName;
        private System.Windows.Forms.Label lblText;
        private Guna.UI2.WinForms.Guna2Panel plNameFriendContainer;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxFriendName;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2CheckBox chBoxSoundEfficts;
        private Guna.UI2.WinForms.Guna2CheckBox chBoxVoiceOver;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelButtons;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnCancelSave;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button btnImportDataFile;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxQuestionsData;
    }
}