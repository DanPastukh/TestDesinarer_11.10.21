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
            //using (Context context = new Context(conStr))
            //{
            //    Group group = new Group() { Name = "sas" };
            //    context.Groups.Add(group);
            //    context.SaveChanges();
            //}
        }
    }
}
