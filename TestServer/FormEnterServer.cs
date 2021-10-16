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

namespace TestServer
{
    public partial class FormEnterServer : Form
    {
        public FormEnterServer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conStr = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
            GenericUnitOfWork work = new GenericUnitOfWork(new Context(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString));
            IGenericRepository<User> repUser = work.Repository<User>();
            User user = new User() { Login = textBoxLogin.Text, Password = textBoxPassWord.Text };
            User tmpUser = null;
            tmpUser = repUser.FindAll(x => x.Login == user.Login && x.Password == user.Password).FirstOrDefault();
            if (tmpUser != null)
            {
                textBoxLogin.Text = null;
                textBoxPassWord.Text = null;
                FormTestServer formTestServer = new FormTestServer(tmpUser);
                formTestServer.ShowDialog();
            }
            else
            {
                MessageBox.Show("You enter wrong data.\nEnter correct data or register new profile.");
            }
            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
