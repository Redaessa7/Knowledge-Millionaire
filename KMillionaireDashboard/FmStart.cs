using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KMillionaireDashboard
{
    public partial class FmStart : Form
    {
        public static string ExistFilePath;
        public FmStart()
        {
            InitializeComponent();
        }

        private void btnOpenExistFile_Click(object sender, EventArgs e)
        {
            OpenExistFile();
        }

        private void OpenExistFile()
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Existing Questions File";
            openFile.Filter = "Json File|*.json";
            if(openFile.ShowDialog() == DialogResult.OK )
            {
                ExistFilePath = openFile.FileName;
                MessageBox.Show(ExistFilePath, "Open Existing File");
                this.Close();
            }
        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            CreateNewFileQues();

        }

        private void CreateNewFileQues()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Create Questions File";
            saveFileDialog.Filter = "Json File|*.json";
            saveFileDialog.FilterIndex = 0;
            saveFileDialog.DefaultExt = "Json File|*.json";
            saveFileDialog.FileName = "MillionerQuestiosFile";

            if(saveFileDialog.ShowDialog() == DialogResult.OK )
            {
                ExistFilePath = saveFileDialog.FileName;
                MessageBox.Show(ExistFilePath, "Open Existing File");
                this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
