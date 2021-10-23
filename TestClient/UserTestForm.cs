using DAL_TestSystem;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestClient
{
    public partial class UserTestForm : Form
    {
        GenericUnitOfWork work = new GenericUnitOfWork(new Context(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString));
        IGenericRepository<Group> repGroup;
        Group group;
        IGenericRepository<User> repUser;
        User user;
        IGenericRepository<Tests> repTests;
        Tests tests;
        IGenericRepository<Questions> repQuestions;
        IGenericRepository<Answers> repAnswers;
        Answers answers;
        IGenericRepository<Results> repResults;
        Results results;
        IGenericRepository<UserAnswers> repUserAnswer;
        UserAnswers userAnswers;

        int qNumber = 1;
        int perAnsPart = 0;
        int difficuliesCount = 0;
        int testMark = 0;
        List<Questions> questions = new List<Questions>();
        public UserTestForm()
        {
            InitializeComponent();
        }
        public UserTestForm(int userId)
        {

            InitializeComponent();

            repGroup = work.Repository<Group>();
            repUser = work.Repository<User>();
            repTests = work.Repository<Tests>();
            repQuestions = work.Repository<Questions>();
            repAnswers = work.Repository<Answers>();
            repResults = work.Repository<Results>();
            repUserAnswer= work.Repository<UserAnswers>();

            user = repUser.FindAll(x => x.Id == userId).FirstOrDefault();
            //MessageBox.Show(user.LName);

            textBoxFName.Text = user.FName;
            textBoxLName.Text = user.LName;
            foreach (var item in user.Groups)
            {
                comboBoxUserGroups.Items.Add(item.Name);
            }
            if (comboBoxUserGroups.Items.Count>0)
            {
                comboBoxUserGroups.SelectedIndex = 0;
            }
        }

        private void comboBoxUserGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            group = repGroup.FindAll(x => x.Name == comboBoxUserGroups.SelectedItem.ToString()).FirstOrDefault();
            dataGridViewTests.DataSource = null;
        }
      
        private void buttonLoadTest_Click(object sender, EventArgs e)
        {
            dataGridViewTests.DataSource = group.TestGroups.Select(x => new
            {
                IdTest=x.TestsId,
                Group = group.Name,
                Author = x.Tests.Author,
                Title = x.Tests.Title,
                NumberOfQuestions = x.Tests.QuestoionsCount
            }).ToList();
        }

        private void dataGridViewTests_MouseClick(object sender, MouseEventArgs e)
        {
            var id = dataGridViewTests.SelectedRows[0].Cells[0].Value;
            tests = repTests.FindById(id);
            buttonPassTest.Enabled = true;
            
        }

        private void buttonPassTest_Click(object sender, EventArgs e)
        {
            groupBoxQuestion.Enabled = true;
            groupBoxQuestion.Text = qNumber.ToString();
            questions = repQuestions.FindAll(x => x.TestsId == tests.Id).ToList();
            foreach (var q in questions)
            {
                q.Answers = repAnswers.FindAll(x => x.QuestionsId == q.Id).ToList();
            }
            if (qNumber <= questions.Count)
            {
                textBoxQuestDescr.Text = questions[qNumber-1].Discription;
                foreach (var answ in questions[qNumber-1].Answers)
                {
                    listBoxAnswers.Items.Add(answ.Discription);
                }
                foreach (var q in questions)
                {
                    difficuliesCount += Convert.ToInt32(q.Difficulty);
                }
            }
            else
            {
                MessageBox.Show($"There is no questions in this test! Try another.");
            }
            buttonPassTest.Enabled = false;
            buttonLoadTest.Enabled = false;
        }
        private void listBoxAnswers_SelectedIndexChanged(object sender, EventArgs e)
        {
            answers = repAnswers.FindAll(x => x.Discription == listBoxAnswers.SelectedItem).FirstOrDefault();
            buttonAnswer.Enabled = true;
        }

        private void buttonAnswer_Click(object sender, EventArgs e)
        {
            if (answers.IsRight)
            {
                perAnsPart = 100 / difficuliesCount * Convert.ToInt32(questions[qNumber - 1].Difficulty);
                testMark += perAnsPart;
            }
            userAnswers = new UserAnswers()
            {
                User = user,
                Answers = answers,
                DateUserAnswer = DateTime.Now
            };
            repUserAnswer.Add(userAnswers);
            work.SaveChanges();
            buttonNextQuestion.Enabled = true;
            buttonAnswer.Enabled = false;
        }

        private void buttonNextQuestion_Click(object sender, EventArgs e)
        {
            buttonNextQuestion.Enabled = false;
            qNumber += 1;
            groupBoxQuestion.Text = qNumber.ToString();
            if (qNumber<=questions.Count)
            {
                listBoxAnswers.Items.Clear();
                textBoxQuestDescr.Text = questions[qNumber-1].Discription;
                foreach (var answ in questions[qNumber-1].Answers)
                {
                    listBoxAnswers.Items.Add(answ.Discription);
                }
            }
            else
            {
                results = new Results()
                {
                    Mark = testMark,
                    Tests = tests,
                    User = user,
                    DateUserAnswer = DateTime.Now
                };
                repResults.Add(results);
                work.SaveChanges();
                MessageBox.Show($"Test finished.Your mark is {testMark}");
                groupBoxQuestion.Text = "";
                groupBoxQuestion.Enabled = false;
                qNumber = 1;
                perAnsPart = 0;
                difficuliesCount = 0;
                testMark = 0;
                textBoxQuestDescr.Text = "";
                listBoxAnswers.Items.Clear();
                buttonLoadTest.Enabled = true;
            }
            
        }

       
    }
}
