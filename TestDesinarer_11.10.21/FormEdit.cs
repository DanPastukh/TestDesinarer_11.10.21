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
    public partial class FormEdit : Form
    {
        TestDll editTest = new TestDll();
        public string FileName { get; set; }
        public FormEdit()
        {
            InitializeComponent();
        }

        private void buttonOpenTest_Click(object sender, EventArgs e)
        {
            
            if (openFileDialogOpeTest.ShowDialog()==DialogResult.Cancel)
            {
                return;
            }
            FileName= openFileDialogOpeTest.FileName;
            if (FileName!=null)
            {
                XmlSerializer formatter = new XmlSerializer(typeof(TestDll));
                using (FileStream fs = new FileStream(FileName, FileMode.Open))
                {
                    editTest = (TestDll)formatter.Deserialize(fs);
                }
                listBoxQuestions.Items.Clear();
                textBoxAuthor.Text = editTest.Author;
                textBoxTitle.Text = editTest.TestName;
                foreach (var question in editTest.Questions)
                {
                    listBoxQuestions.Items.Add(question.Description);
                }
            }
        }

        private void listBoxQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxQuestion.Text = listBoxQuestions.SelectedItem.ToString();
            numericUpDownDificulty.Value =Convert.ToInt32(editTest.Questions[listBoxQuestions.SelectedIndex].Difficulty);
            comboBoxAnswers.Text = "";
            comboBoxAnswers.Items.Clear();
            textBoxAnswer.Text = "";
            checkBoxIsRight.Checked = false;
            foreach (var answer in editTest.Questions[listBoxQuestions.SelectedIndex].Answers)
            {
                comboBoxAnswers.Items.Add(answer.Description);
            }
        }

        private void buttonEditQuestion_Click(object sender, EventArgs e)
        {
            editTest.Questions[listBoxQuestions.SelectedIndex].Description = textBoxQuestion.Text;
            editTest.Questions[listBoxQuestions.SelectedIndex].Difficulty=numericUpDownDificulty.Value.ToString();
            listBoxQuestions.Items.Clear();
            foreach (var question in editTest.Questions)
            {
                listBoxQuestions.Items.Add(question.Description);
            }
            textBoxQuestion.Text = "";
            numericUpDownDificulty.Value = 0;
            editTest.Author = textBoxAuthor.Text;
            editTest.TestName = textBoxTitle.Text;
            comboBoxAnswers.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            editTest.Questions.RemoveAt(listBoxQuestions.SelectedIndex);
            listBoxQuestions.Items.Clear();
            foreach (var question in editTest.Questions)
            {
                listBoxQuestions.Items.Add(question.Description);
            }
            comboBoxAnswers.Items.Clear();
            textBoxAnswer.Text = "";
            comboBoxAnswers.Text = "";
            textBoxQuestion.Text = "";
        }

        private void comboBoxAnswers_SelectedIndexChanged(object sender, EventArgs e)
        {
             textBoxAnswer.Text = editTest.Questions[listBoxQuestions.SelectedIndex].Answers[comboBoxAnswers.SelectedIndex].Description;
             checkBoxIsRight.Checked =Convert.ToBoolean(editTest.Questions[listBoxQuestions.SelectedIndex].Answers[comboBoxAnswers.SelectedIndex].IsRight);
        }

        private void checkBoxIsRight_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var answer in editTest.Questions[listBoxQuestions.SelectedIndex].Answers)
            {
                answer.IsRight = "false";
            }
            editTest.Questions[listBoxQuestions.SelectedIndex].Answers[comboBoxAnswers.SelectedIndex].IsRight = "true";
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            editTest.Questions[listBoxQuestions.SelectedIndex].Answers[comboBoxAnswers.SelectedIndex].Description = textBoxAnswer.Text;
            editTest.Questions[listBoxQuestions.SelectedIndex].Answers[comboBoxAnswers.SelectedIndex].IsRight = checkBoxIsRight.Checked.ToString().ToLower();
            if (editTest.Questions[listBoxQuestions.SelectedIndex].Answers[comboBoxAnswers.SelectedIndex].IsRight == "true")
            {
                foreach (var answer in editTest.Questions[listBoxQuestions.SelectedIndex].Answers)
                {
                    answer.IsRight = "false";
                }
                editTest.Questions[listBoxQuestions.SelectedIndex].Answers[comboBoxAnswers.SelectedIndex].IsRight = "true";
            }
            comboBoxAnswers.Items.Clear();
            foreach (var answer in editTest.Questions[listBoxQuestions.SelectedIndex].Answers)
            {
                comboBoxAnswers.Items.Add(answer.Description);
            }
            textBoxAnswer.Text = "";
            checkBoxIsRight.Checked = false;
            comboBoxAnswers.Text = "";
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            editTest.Questions[listBoxQuestions.SelectedIndex].Answers.RemoveAt(comboBoxAnswers.SelectedIndex);
            comboBoxAnswers.Items.Clear();
            foreach (var answer in editTest.Questions[listBoxQuestions.SelectedIndex].Answers)
            {
                comboBoxAnswers.Items.Add(answer.Description);
            }
            textBoxAnswer.Text = "";
            checkBoxIsRight.Checked = false;
            comboBoxAnswers.Text = "";
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            editTest.Author = textBoxAuthor.Text;
            editTest.TestName = textBoxTitle.Text;
           
            XmlSerializer formatter = new XmlSerializer(typeof(TestDll));
            using (FileStream fs = new FileStream(FileName, FileMode.Create))
            {
                formatter.Serialize(fs, editTest);
            }
            textBoxAnswer.Text = "";
            textBoxAuthor.Text = "";
            textBoxQuestion.Text = "";
            textBoxTitle.Text = "";
            listBoxQuestions.Items.Clear();
            comboBoxAnswers.Items.Clear();
            numericUpDownDificulty.Value = 0;
            comboBoxAnswers.Items.Clear();
            comboBoxAnswers.Text = "";
            checkBoxIsRight.Checked = false;
        }

      
    }
}
