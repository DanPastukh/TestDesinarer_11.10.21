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
using System.Xml.Serialization;
using TestDesignerDLL;

namespace TestDesinarer_11._10._21
{
    public partial class FormNewTest : Form
    {
        TestDll test = new TestDll();
        QuestionDLL question = new QuestionDLL();
        AnswerDLL answer= new AnswerDLL();
        public string FileName { get; set; }
        public FormNewTest()
        {
            InitializeComponent();
        }
        private void buttonAddCuestion_Click(object sender, EventArgs e)
        {
            test.Author = textBoxAuthor.Text;
            test.TestName = textBoxTitle.Text;
            question.Description = textBoxQuestion.Text;
            question.Difficulty = numericUpDownDificulty.Value.ToString();
            test.Questions.Add(question);
            groupBoxAnswer.Enabled = true;
            buttonAddQuestion.Enabled = false;
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            answer.Description = textBoxAnswer.Text;
            answer.IsRight = checkBoxIsRight.Checked.ToString().ToLower();
            test.Questions[test.Questions.Count-1].Answers.Add(answer);
            listBoxAnswers.Items.Add(answer.Description);
            if (test.Questions[test.Questions.Count - 1].Answers.Count>1)
            {
                buttonNextQuest.Enabled = true;
                groupBoxSaveFile.Enabled = true;
            }
            if (checkBoxIsRight.Checked == true)
            {
                checkBoxIsRight.Enabled = false;
            }
            answer = new AnswerDLL();
            textBoxAnswer.Text = "";
            checkBoxIsRight.Checked = false;
        }

        private void buttonNextQuest_Click(object sender, EventArgs e)
        {
            buttonAddQuestion.Enabled = true;
            buttonNextQuest.Enabled = false;
            textBoxQuestion.Text = "";
            groupBoxAnswer.Enabled = false;
            numericUpDownDificulty.Value = 0;
            checkBoxIsRight.Enabled = true;
            listBoxAnswers.Items.Clear();
            question = new QuestionDLL();
        }
        
        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            if (textBoxFileName.Text!="")
            {
                FileName = textBoxFileName.Text;
                buttonSaveFile.Enabled = true;
                XmlSerializer formatter = new XmlSerializer(typeof(TestDll));
                using (FileStream fs = new FileStream($"Tests/{FileName}", FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, test);
                }
                textBoxFileName.Text = "";
                textBoxAuthor.Text = "";
                textBoxQuestion.Text = "";
                numericUpDownDificulty.Value = 0;
                textBoxTitle.Text = "";
                listBoxAnswers.Items.Clear();
                buttonNextQuest.Enabled = false;
                buttonAddQuestion.Enabled = true;
            }
            else
            {
                MessageBox.Show("Enter name of file!");
            }
           
        }

        
    }
}
