using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using MillionerCLassLibrary.cQuestions;
namespace KMillionaireDashboard
{
    public partial class FmDashboard : Form
    {
        public CLsQuesitons clsQuestionsObj;
        private DataGridViewRow row;
        private int Id;
        private bool isUpdate = false; 
        public FmDashboard()
        { 
            InitializeComponent();

            string path = FmStart.ExistFilePath;
            clsQuestionsObj = new CLsQuesitons(path);
            clsQuestionsObj.Load();
        }


        private void FmDashboard_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();
            cmBoxClassQuestions.SelectedIndex = 0;
            cmBoxDefficultQuestion.SelectedIndex = 0;

        }

        // Show Questions List Page

        private DataTable ConvertListOfQuestionsToDataTable(List<Question> list)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Question", typeof(string));
            dt.Columns.Add("Answer1", typeof(string));
            dt.Columns.Add("Answer2", typeof(string));
            dt.Columns.Add("Answer3", typeof(string));
            dt.Columns.Add("Answer4", typeof(string));
            dt.Columns.Add("Correct Answer", typeof(string));

            foreach (Question q in list)
            {
                dt.Rows.Add(q.id, q.question, q.options[0], q.options[1], q.options[2], q.options[3],q.correct_answer);
            }

            return dt;
        }
        private void InitializeDataGridView(enClassificationQuestions enClassification = enClassificationQuestions.Eesy)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;

            Console.WriteLine(clsQuestionsObj.questions.ListOfEasy.Count);
            var ListOfQuestions = new List<Question>();
            ListOfQuestions = clsQuestionsObj.GetQuestionsList(enClassification);
            dataGridView1.DataSource = ConvertListOfQuestionsToDataTable(ListOfQuestions);



            dataGridView1.CellValueChanged += DataGridView1_CellValueChanged;
            dataGridView1.CellClick += DataGridView1_CellClick;

        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show($"Value changed in column {e.ColumnIndex}, row {e.RowIndex}");
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show($"Cell clicked in column {e.ColumnIndex}, row {e.RowIndex}");
        }
    
    
        // Add Questions Page
        private Question CreateQuesition(int ID)
        {
            Question question = new Question();
            question.id = ID;
            question.question = txtBoxQuestionTitle.Text;
            List<string> tempOps = new List<string>();

            tempOps.Add(txtBoxAnswer1.Text);
            tempOps.Add(txtBoxAnswer2.Text);
            tempOps.Add(txtBoxAnswer3.Text);
            tempOps.Add(txtBoxAnswer4.Text);

            question.options = tempOps;
            question.correct_answer = txtBoxAnswerCorrect.Text;

            return question;
        }

        private void AddNewQuestion()
        {
           var classificationQues = (enClassificationQuestions)cmBoxDefficultQuestion.SelectedIndex;
           int Id = clsQuestionsObj.GetNextID(classificationQues);
           Question question = CreateQuesition(Id);
           clsQuestionsObj.Add(question, classificationQues);
        }

        private void ClearFilds()
        {
            txtBoxQuestionTitle.Clear();
            txtBoxAnswer1.Clear();
            txtBoxAnswer2.Clear();
            txtBoxAnswer3.Clear();
            txtBoxAnswer4.Clear();
            txtBoxAnswerCorrect.Clear();

            txtBoxQuestionTitle.Focus();
        }

        private void btnSaveQuestionNew_Click(object sender, EventArgs e)
        {
            if(!ValidateInputs()) return;

            if (isUpdate)
            {
                UpdateQuestion();
                MessageBox.Show("تم تحديث السؤال بنجاح");
                isUpdate = false;
                tabNavebar.SelectedIndex = 0;
                cmBoxDefficultQuestion.Enabled = true;
            }
            else
            {
                AddNewQuestion();
                MessageBox.Show("تم إضافة السؤال بنجاح");
            }
            ClearFilds();
        }

        // Update
        private void UpdateQuestion()
        {
            var classificationQues = (enClassificationQuestions)cmBoxDefficultQuestion.SelectedIndex;
            
            Question question = CreateQuesition(Id);
            clsQuestionsObj.Update(question, classificationQues);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tabNavebar.SelectedIndex = 0;
            ClearFilds();
            isUpdate = false;
            cmBoxDefficultQuestion.Enabled = true;
        }

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBoxSearch.Text))
            { 
                var c = int.Parse(txtBoxSearch.Text);
                SearchOnQuestion(c);
            }
            else
            {
                dataGridView1.DataSource = ConvertListOfQuestionsToDataTable(clsQuestionsObj.GetQuestionsList((enClassificationQuestions) cmBoxClassQuestions.SelectedIndex));
            }
        }

        private void DataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            // Check if the right mouse button was clicked
            if (e.Button == MouseButtons.Right)
            {
                // Get the position of the mouse click
                var hitTestInfo = dataGridView1.HitTest(e.X, e.Y);

                // Check if the click was on a cell (not on the header or an empty area)
                if (hitTestInfo.Type == DataGridViewHitTestType.Cell)
                {
                    // Clear any previous selection in the DataGridView
                    dataGridView1.ClearSelection();

                    // Select the entire row where the cell was clicked
                    dataGridView1.Rows[hitTestInfo.RowIndex].Selected = true;

                    // Show the context menu at the mouse click location
                    contextMenuStrip1.Show(dataGridView1, e.Location);

                    // Store the selected row in a variable for further use
                    row = dataGridView1.Rows[hitTestInfo.RowIndex];
                }
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Id = int.Parse(row.Cells[0].Value.ToString());
            txtBoxQuestionTitle.Text = row.Cells[1].Value.ToString();
            txtBoxAnswer1.Text = row.Cells[2].Value.ToString();
            txtBoxAnswer2.Text = row.Cells[3].Value.ToString();
            txtBoxAnswer3.Text = row.Cells[4].Value.ToString();
            txtBoxAnswer4.Text = row.Cells[5].Value.ToString();
            txtBoxAnswerCorrect.Text = row.Cells[6].Value.ToString();
            cmBoxDefficultQuestion.SelectedIndex = cmBoxClassQuestions.SelectedIndex;

            cmBoxDefficultQuestion.Enabled = false;

            tabNavebar.SelectedIndex = 1;
            isUpdate = true;
            
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حقا حذف هذ السؤال؟","حذف سؤال",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                clsQuestionsObj.Remove((int)row.Cells[0].Value, (enClassificationQuestions)cmBoxClassQuestions.SelectedIndex);
                InitializeDataGridView((enClassificationQuestions)cmBoxClassQuestions.SelectedIndex);

            }
        }
    
        
        // Search
        private void SearchOnQuestion(int Id)
        {
            Question question = clsQuestionsObj.Search(Id, (enClassificationQuestions)cmBoxClassQuestions.SelectedIndex);
            if (question != null)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("ID", typeof(int));
                dt.Columns.Add("Question", typeof(string));
                dt.Columns.Add("Answer1", typeof(string));
                dt.Columns.Add("Answer2", typeof(string));
                dt.Columns.Add("Answer3", typeof(string));
                dt.Columns.Add("Answer4", typeof(string));
                dt.Columns.Add("Correct Answer", typeof(string));

                dt.Rows.Add(question.id, question.question, question.options[0], question.options[1], question.options[2], question.options[3],question.correct_answer);

                // Desplay result
                dataGridView1.DataSource = dt;
            }
        }

        private void cmBoxClassQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitializeDataGridView((enClassificationQuestions)cmBoxClassQuestions.SelectedIndex);
        }

        private void tabNavebar_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitializeDataGridView((enClassificationQuestions)cmBoxClassQuestions.SelectedIndex);
            if (tabNavebar.SelectedIndex == 1) ClearErroProvider();
        }
        
        private bool ValidateInputs()
        {
            bool isValid = true;
            Guna2TextBox[] arrayOfTextBoxs = {txtBoxQuestionTitle,txtBoxAnswer1,txtBoxAnswer2,txtBoxAnswer3,txtBoxAnswer4,txtBoxAnswerCorrect}; 
            
            foreach(Guna2TextBox textBox in arrayOfTextBoxs)
            {
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    errorProvider.SetError(textBox, "هذا الحقل مطلوب.");
                    isValid = false;
                }
                else
                {
                    errorProvider.SetError(textBox, string.Empty);
                }
            }
            return isValid;
        }

        private void ClearErroProvider()
        {
            Guna2TextBox[] arrayOfTextBoxs = { txtBoxQuestionTitle, txtBoxAnswer1, txtBoxAnswer2, txtBoxAnswer3, txtBoxAnswer4, txtBoxAnswerCorrect };
            foreach (Guna2TextBox textBox in arrayOfTextBoxs)
            {
                errorProvider.SetError(textBox, string.Empty);
            }
        }


    }


}
