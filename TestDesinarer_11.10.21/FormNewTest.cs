using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestDesignerDLL;
//using Xml2CSharp;

namespace TestDesinarer_11._10._21
{
    public partial class FormNewTest : Form
    {
        Test test = new Test();
        List<Question> questions = new List<Question>();
        Question question = new Question();
        List<Answer> answers = new List<Answer>();
        Answer answer= new Answer();
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

        }

        private void textBoxAnswer_TextChanged(object sender, EventArgs e)
        {
            answer.Description = textBoxAnswer.Text;
        }

        private void checkBoxIsRight_CheckedChanged(object sender, EventArgs e)
        {
            answer.IsRight = checkBoxIsRight.Checked.ToString();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            answers.Add(answer);
            listBoxAnswers.Items.Add(answer.Description);
        }
    }
}
