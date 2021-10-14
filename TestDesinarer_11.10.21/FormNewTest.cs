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
//using Xml2CSharp;

namespace TestDesinarer_11._10._21
{
    public partial class FormNewTest : Form
    {
        TestDll test = new TestDll();
        
        //List<QuestionDLL> questions = new List<QuestionDLL>();
        QuestionDLL question = new QuestionDLL();
       // List<AnswerDLL> answers = new List<AnswerDLL>();
        AnswerDLL answer= new AnswerDLL();
        public string FileName { get; set; }
        public FormNewTest()
        {
            InitializeComponent();
            
        }

        private void textBoxAuthor_TextChanged(object sender, EventArgs e)
        {
            test.Author = textBoxAuthor.Text;
        }

        private void textBoxTitle_TextChanged(object sender, EventArgs e)
        {
            test.TestName = textBoxTitle.Text;
        }

        private void textBoxQuestion_TextChanged(object sender, EventArgs e)
        {
            question.Description = textBoxQuestion.Text;
        }

        private void numericUpDownDificulty_ValueChanged(object sender, EventArgs e)
        {
            question.Difficulty = numericUpDownDificulty.Value.ToString();
        }

        private void buttonAddCuestion_Click(object sender, EventArgs e)
        {
            test.Questions.Add(question);
            groupBoxAnswer.Enabled = true;
            buttonAddQuestion.Enabled = false;
           
        }

        private void textBoxAnswer_TextChanged(object sender, EventArgs e)
        {
            answer.Description = textBoxAnswer.Text;
            answer.IsRight = "false";
        }

        private void checkBoxIsRight_CheckedChanged(object sender, EventArgs e)
        {
            answer.IsRight = checkBoxIsRight.Checked.ToString().ToLower();
            
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
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
            //textBoxAnswer.Text = "";
            listBoxAnswers.Items.Clear();
            question = new QuestionDLL();

        }
        private void textBoxFileName_TextChanged(object sender, EventArgs e)
        {
            
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
