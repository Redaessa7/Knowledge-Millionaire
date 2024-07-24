namespace KMillionaireDashboard
{
    partial class FmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmDashboard));
            this.tabNavebar = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPageListOfQues = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plTop = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.txtBoxSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmBoxClassQuestions = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tabPageAddNewQue = new System.Windows.Forms.TabPage();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnSaveQuestionNew = new Guna.UI2.WinForms.Guna2Button();
            this.cmBoxDefficultQuestion = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtBoxAnswer1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBoxAnswer2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBoxAnswer3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBoxAnswer4 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBoxQuestionTitle = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBoxAnswerCorrect = new Guna.UI2.WinForms.Guna2TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabNavebar.SuspendLayout();
            this.tabPageListOfQues.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.plTop.SuspendLayout();
            this.tabPageAddNewQue.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tabNavebar
            // 
            this.tabNavebar.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.tabNavebar.Controls.Add(this.tabPageListOfQues);
            this.tabNavebar.Controls.Add(this.tabPageAddNewQue);
            this.tabNavebar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabNavebar.Font = new System.Drawing.Font("Almarai Bold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabNavebar.ItemSize = new System.Drawing.Size(150, 40);
            this.tabNavebar.Location = new System.Drawing.Point(0, 0);
            this.tabNavebar.Name = "tabNavebar";
            this.tabNavebar.SelectedIndex = 0;
            this.tabNavebar.Size = new System.Drawing.Size(1010, 607);
            this.tabNavebar.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tabNavebar.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(216)))), ((int)(((byte)(67)))));
            this.tabNavebar.TabButtonHoverState.Font = new System.Drawing.Font("Almarai Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabNavebar.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tabNavebar.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(211)))));
            this.tabNavebar.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tabNavebar.TabButtonIdleState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.tabNavebar.TabButtonIdleState.Font = new System.Drawing.Font("Almarai Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabNavebar.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tabNavebar.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tabNavebar.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tabNavebar.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(211)))));
            this.tabNavebar.TabButtonSelectedState.Font = new System.Drawing.Font("Almarai Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabNavebar.TabButtonSelectedState.ForeColor = System.Drawing.Color.MintCream;
            this.tabNavebar.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(216)))), ((int)(((byte)(67)))));
            this.tabNavebar.TabButtonSize = new System.Drawing.Size(150, 40);
            this.tabNavebar.TabIndex = 0;
            this.tabNavebar.TabMenuBackColor = System.Drawing.Color.WhiteSmoke;
            this.tabNavebar.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.VerticalRight;
            this.tabNavebar.SelectedIndexChanged += new System.EventHandler(this.tabNavebar_SelectedIndexChanged);
            // 
            // tabPageListOfQues
            // 
            this.tabPageListOfQues.BackColor = System.Drawing.Color.Transparent;
            this.tabPageListOfQues.Controls.Add(this.dataGridView1);
            this.tabPageListOfQues.Controls.Add(this.plTop);
            this.tabPageListOfQues.Location = new System.Drawing.Point(4, 4);
            this.tabPageListOfQues.Name = "tabPageListOfQues";
            this.tabPageListOfQues.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageListOfQues.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPageListOfQues.Size = new System.Drawing.Size(852, 599);
            this.tabPageListOfQues.TabIndex = 0;
            this.tabPageListOfQues.Text = "قائمة الاسئلة";
            this.tabPageListOfQues.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.Location = new System.Drawing.Point(3, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(846, 521);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DataGridView_MouseDown);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Question";
            this.Column2.HeaderText = "Question";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Answer1";
            this.Column3.HeaderText = "Answer1";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Answer2";
            this.Column4.HeaderText = "Answer2";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Answer3";
            this.Column5.HeaderText = "Answer3";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Answer4";
            this.Column6.HeaderText = "Answer4";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Correct Answer";
            this.Column7.HeaderText = "Correct Answer";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 125;
            // 
            // plTop
            // 
            this.plTop.Controls.Add(this.txtBoxSearch);
            this.plTop.Controls.Add(this.cmBoxClassQuestions);
            this.plTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.plTop.Location = new System.Drawing.Point(3, 3);
            this.plTop.Name = "plTop";
            this.plTop.Padding = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.plTop.Size = new System.Drawing.Size(846, 72);
            this.plTop.TabIndex = 0;
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.BorderRadius = 5;
            this.txtBoxSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxSearch.DefaultText = "";
            this.txtBoxSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtBoxSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxSearch.Location = new System.Drawing.Point(462, 20);
            this.txtBoxSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.PasswordChar = '\0';
            this.txtBoxSearch.PlaceholderText = "بحث";
            this.txtBoxSearch.SelectedText = "";
            this.txtBoxSearch.Size = new System.Drawing.Size(374, 32);
            this.txtBoxSearch.TabIndex = 5;
            this.txtBoxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBoxSearch.TextChanged += new System.EventHandler(this.txtBoxSearch_TextChanged);
            // 
            // cmBoxClassQuestions
            // 
            this.cmBoxClassQuestions.BackColor = System.Drawing.Color.Transparent;
            this.cmBoxClassQuestions.BorderRadius = 5;
            this.cmBoxClassQuestions.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmBoxClassQuestions.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmBoxClassQuestions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBoxClassQuestions.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmBoxClassQuestions.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmBoxClassQuestions.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmBoxClassQuestions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmBoxClassQuestions.ItemHeight = 30;
            this.cmBoxClassQuestions.Items.AddRange(new object[] {
            "سهل",
            "متوسط",
            "صعب"});
            this.cmBoxClassQuestions.Location = new System.Drawing.Point(10, 20);
            this.cmBoxClassQuestions.Name = "cmBoxClassQuestions";
            this.cmBoxClassQuestions.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmBoxClassQuestions.Size = new System.Drawing.Size(197, 36);
            this.cmBoxClassQuestions.TabIndex = 4;
            this.cmBoxClassQuestions.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cmBoxClassQuestions.SelectedIndexChanged += new System.EventHandler(this.cmBoxClassQuestions_SelectedIndexChanged);
            // 
            // tabPageAddNewQue
            // 
            this.tabPageAddNewQue.Controls.Add(this.guna2Panel1);
            this.tabPageAddNewQue.Controls.Add(this.cmBoxDefficultQuestion);
            this.tabPageAddNewQue.Controls.Add(this.guna2GroupBox1);
            this.tabPageAddNewQue.Controls.Add(this.txtBoxQuestionTitle);
            this.tabPageAddNewQue.Controls.Add(this.txtBoxAnswerCorrect);
            this.tabPageAddNewQue.Location = new System.Drawing.Point(4, 4);
            this.tabPageAddNewQue.Name = "tabPageAddNewQue";
            this.tabPageAddNewQue.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddNewQue.Size = new System.Drawing.Size(852, 599);
            this.tabPageAddNewQue.TabIndex = 1;
            this.tabPageAddNewQue.Text = "إضافة سؤال";
            this.tabPageAddNewQue.UseVisualStyleBackColor = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btnCancel);
            this.guna2Panel1.Controls.Add(this.btnSaveQuestionNew);
            this.guna2Panel1.Location = new System.Drawing.Point(74, 451);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Padding = new System.Windows.Forms.Padding(5);
            this.guna2Panel1.Size = new System.Drawing.Size(745, 62);
            this.guna2Panel1.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.Animated = true;
            this.btnCancel.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.BorderRadius = 5;
            this.btnCancel.BorderThickness = 2;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCancel.FillColor = System.Drawing.Color.White;
            this.btnCancel.Font = new System.Drawing.Font("Almarai Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.LightGray;
            this.btnCancel.HoverState.FillColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(5, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(349, 52);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "إلغاء";
            this.btnCancel.UseTransparentBackground = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveQuestionNew
            // 
            this.btnSaveQuestionNew.Animated = true;
            this.btnSaveQuestionNew.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnSaveQuestionNew.BorderRadius = 5;
            this.btnSaveQuestionNew.BorderThickness = 2;
            this.btnSaveQuestionNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveQuestionNew.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveQuestionNew.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveQuestionNew.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaveQuestionNew.DisabledState.ForeColor = System.Drawing.Color.White;
            this.btnSaveQuestionNew.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSaveQuestionNew.FillColor = System.Drawing.Color.White;
            this.btnSaveQuestionNew.Font = new System.Drawing.Font("Almarai Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveQuestionNew.ForeColor = System.Drawing.Color.LightGray;
            this.btnSaveQuestionNew.HoverState.FillColor = System.Drawing.Color.White;
            this.btnSaveQuestionNew.Location = new System.Drawing.Point(391, 5);
            this.btnSaveQuestionNew.Name = "btnSaveQuestionNew";
            this.btnSaveQuestionNew.Size = new System.Drawing.Size(349, 52);
            this.btnSaveQuestionNew.TabIndex = 6;
            this.btnSaveQuestionNew.Text = "حفظ";
            this.btnSaveQuestionNew.UseTransparentBackground = true;
            this.btnSaveQuestionNew.Click += new System.EventHandler(this.btnSaveQuestionNew_Click);
            // 
            // cmBoxDefficultQuestion
            // 
            this.cmBoxDefficultQuestion.BackColor = System.Drawing.Color.Transparent;
            this.cmBoxDefficultQuestion.BorderRadius = 5;
            this.cmBoxDefficultQuestion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmBoxDefficultQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBoxDefficultQuestion.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmBoxDefficultQuestion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmBoxDefficultQuestion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmBoxDefficultQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmBoxDefficultQuestion.ItemHeight = 30;
            this.cmBoxDefficultQuestion.Items.AddRange(new object[] {
            "سهل",
            "متوسط",
            "صعب"});
            this.cmBoxDefficultQuestion.Location = new System.Drawing.Point(74, 358);
            this.cmBoxDefficultQuestion.Name = "cmBoxDefficultQuestion";
            this.cmBoxDefficultQuestion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmBoxDefficultQuestion.Size = new System.Drawing.Size(349, 36);
            this.cmBoxDefficultQuestion.TabIndex = 3;
            this.cmBoxDefficultQuestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GroupBox1.BorderRadius = 5;
            this.guna2GroupBox1.Controls.Add(this.flowLayoutPanel1);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Almarai Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(74, 159);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(745, 162);
            this.guna2GroupBox1.TabIndex = 1;
            this.guna2GroupBox1.Text = "الاختيارات";
            this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.txtBoxAnswer1);
            this.flowLayoutPanel1.Controls.Add(this.txtBoxAnswer2);
            this.flowLayoutPanel1.Controls.Add(this.txtBoxAnswer3);
            this.flowLayoutPanel1.Controls.Add(this.txtBoxAnswer4);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 40);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(745, 122);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // txtBoxAnswer1
            // 
            this.txtBoxAnswer1.BorderRadius = 5;
            this.txtBoxAnswer1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxAnswer1.DefaultText = "";
            this.txtBoxAnswer1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxAnswer1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxAnswer1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxAnswer1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxAnswer1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxAnswer1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxAnswer1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxAnswer1.Location = new System.Drawing.Point(373, 14);
            this.txtBoxAnswer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxAnswer1.Name = "txtBoxAnswer1";
            this.txtBoxAnswer1.PasswordChar = '\0';
            this.txtBoxAnswer1.PlaceholderText = "الاختيار رقم 1";
            this.txtBoxAnswer1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBoxAnswer1.SelectedText = "";
            this.txtBoxAnswer1.Size = new System.Drawing.Size(349, 38);
            this.txtBoxAnswer1.TabIndex = 4;
            this.txtBoxAnswer1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBoxAnswer2
            // 
            this.txtBoxAnswer2.BorderRadius = 5;
            this.txtBoxAnswer2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxAnswer2.DefaultText = "";
            this.txtBoxAnswer2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxAnswer2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxAnswer2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxAnswer2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxAnswer2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxAnswer2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxAnswer2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxAnswer2.Location = new System.Drawing.Point(18, 14);
            this.txtBoxAnswer2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxAnswer2.Name = "txtBoxAnswer2";
            this.txtBoxAnswer2.PasswordChar = '\0';
            this.txtBoxAnswer2.PlaceholderText = "الاختيار رقم 2";
            this.txtBoxAnswer2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBoxAnswer2.SelectedText = "";
            this.txtBoxAnswer2.Size = new System.Drawing.Size(349, 38);
            this.txtBoxAnswer2.TabIndex = 5;
            this.txtBoxAnswer2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBoxAnswer3
            // 
            this.txtBoxAnswer3.BorderRadius = 5;
            this.txtBoxAnswer3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxAnswer3.DefaultText = "";
            this.txtBoxAnswer3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxAnswer3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxAnswer3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxAnswer3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxAnswer3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxAnswer3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxAnswer3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxAnswer3.Location = new System.Drawing.Point(373, 60);
            this.txtBoxAnswer3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxAnswer3.Name = "txtBoxAnswer3";
            this.txtBoxAnswer3.PasswordChar = '\0';
            this.txtBoxAnswer3.PlaceholderText = "الاختيار رقم 3";
            this.txtBoxAnswer3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBoxAnswer3.SelectedText = "";
            this.txtBoxAnswer3.Size = new System.Drawing.Size(349, 38);
            this.txtBoxAnswer3.TabIndex = 6;
            this.txtBoxAnswer3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBoxAnswer4
            // 
            this.txtBoxAnswer4.BorderRadius = 5;
            this.txtBoxAnswer4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxAnswer4.DefaultText = "";
            this.txtBoxAnswer4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxAnswer4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxAnswer4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxAnswer4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxAnswer4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxAnswer4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxAnswer4.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxAnswer4.Location = new System.Drawing.Point(18, 60);
            this.txtBoxAnswer4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxAnswer4.Name = "txtBoxAnswer4";
            this.txtBoxAnswer4.PasswordChar = '\0';
            this.txtBoxAnswer4.PlaceholderText = "الاختيار رقم 4";
            this.txtBoxAnswer4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBoxAnswer4.SelectedText = "";
            this.txtBoxAnswer4.Size = new System.Drawing.Size(349, 38);
            this.txtBoxAnswer4.TabIndex = 7;
            this.txtBoxAnswer4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBoxQuestionTitle
            // 
            this.txtBoxQuestionTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxQuestionTitle.BorderRadius = 5;
            this.txtBoxQuestionTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxQuestionTitle.DefaultText = "";
            this.txtBoxQuestionTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxQuestionTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxQuestionTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxQuestionTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxQuestionTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxQuestionTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxQuestionTitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxQuestionTitle.Location = new System.Drawing.Point(74, 84);
            this.txtBoxQuestionTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxQuestionTitle.Name = "txtBoxQuestionTitle";
            this.txtBoxQuestionTitle.PasswordChar = '\0';
            this.txtBoxQuestionTitle.PlaceholderText = "نص السؤال";
            this.txtBoxQuestionTitle.SelectedText = "";
            this.txtBoxQuestionTitle.Size = new System.Drawing.Size(745, 38);
            this.txtBoxQuestionTitle.TabIndex = 0;
            this.txtBoxQuestionTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBoxAnswerCorrect
            // 
            this.txtBoxAnswerCorrect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxAnswerCorrect.BorderRadius = 5;
            this.txtBoxAnswerCorrect.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxAnswerCorrect.DefaultText = "";
            this.txtBoxAnswerCorrect.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxAnswerCorrect.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxAnswerCorrect.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxAnswerCorrect.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxAnswerCorrect.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxAnswerCorrect.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxAnswerCorrect.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxAnswerCorrect.Location = new System.Drawing.Point(470, 356);
            this.txtBoxAnswerCorrect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxAnswerCorrect.Name = "txtBoxAnswerCorrect";
            this.txtBoxAnswerCorrect.PasswordChar = '\0';
            this.txtBoxAnswerCorrect.PlaceholderText = "الاجابة الصحيحة";
            this.txtBoxAnswerCorrect.SelectedText = "";
            this.txtBoxAnswerCorrect.Size = new System.Drawing.Size(349, 38);
            this.txtBoxAnswerCorrect.TabIndex = 2;
            this.txtBoxAnswerCorrect.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Almarai Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(122, 60);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(121, 28);
            this.updateToolStripMenuItem.Text = "تعديل";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(121, 28);
            this.deleteToolStripMenuItem.Text = "حذف";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1010, 607);
            this.Controls.Add(this.tabNavebar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FmDashboard";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Knowledge Millionaire Creator";
            this.Load += new System.EventHandler(this.FmDashboard_Load);
            this.tabNavebar.ResumeLayout(false);
            this.tabPageListOfQues.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.plTop.ResumeLayout(false);
            this.tabPageAddNewQue.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2GroupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl tabNavebar;
        private System.Windows.Forms.TabPage tabPageListOfQues;
        private System.Windows.Forms.TabPage tabPageAddNewQue;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2GradientPanel plTop;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxQuestionTitle;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2ComboBox cmBoxDefficultQuestion;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxAnswerCorrect;
        private Guna.UI2.WinForms.Guna2ComboBox cmBoxClassQuestions;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxSearch;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxAnswer2;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxAnswer1;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxAnswer4;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxAnswer3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnSaveQuestionNew;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

