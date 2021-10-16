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
    public partial class FormTestServer : Form
    {
        GenericUnitOfWork work = new GenericUnitOfWork(new Context(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString));
        IGenericRepository<Group> repGroup;
        Group group;
        IGenericRepository<User> repUser;
        User user;
        public void FillDatagreeds()
        {
            dataGridAllGroups.DataSource = repGroup.GetAllData().Select(x => new { Id = x.Id, Name = x.Name }).ToList();
            dataGridAddG.DataSource = repGroup.GetAllData().Select(x => new { Id = x.Id, Name = x.Name }).ToList();
            dataGridEditG.DataSource = repGroup.GetAllData().Select(x => new { Id = x.Id, Name = x.Name }).ToList();
            dataGridDelG.DataSource = repGroup.GetAllData().Select(x => new { Id = x.Id, Name = x.Name }).ToList();
            dataGridViewUforG.DataSource = repUser.GetAllData().Select(x => new {
                Id = x.Id,
                FirsName = x.FName,
                LastName = x.LName,
                Login = x.Login,
                Password = x.Password,
                IsAdmin = x.IsAdmin
            }).ToList();
            comboBoxAdUtoG.Items.Clear();
            comboBoxAdUtoG.Items.AddRange(repGroup.GetAllData().Select(x => x.Name).ToArray());
        }
        public FormTestServer()
        {
            InitializeComponent();
        }
        public FormTestServer(User user)
        {
            InitializeComponent();

            
            repGroup = work.Repository<Group>();
            repUser = work.Repository<User>();
            FillDatagreeds();

            //repGroup.Add(new Group() { Name = "Group1" });
            //repGroup.Add(new Group() { Name = "Group2" });
            //repGroup.Add(new Group() { Name = "Group3" });
            //repGroup.Add(new Group() { Name = "Group4" });
            //repGroup.Add(new Group() { Name = "Group5" });

            //IGenericRepository<User> repUser = work.Repository<User>();
            //repUser.Add(new User() { FName = "u1", LName = "user1", Login = "u1", Password = "u1", IsAdmin = false });
            //repUser.Add(new User() { FName = "u2", LName = "user2", Login = "u2", Password = "u2", IsAdmin = false });
            //repUser.Add(new User() { FName = "u3", LName = "user3", Login = "u3", Password = "u3", IsAdmin = false });
            //repUser.Add(new User() { FName = "u4", LName = "user4", Login = "u4", Password = "u4", IsAdmin = false });
            //repUser.Add(new User() { FName = "u5", LName = "user5", Login = "u5", Password = "u5", IsAdmin = false });
            
            
        }

        private void buttonAddGroupe_Click(object sender, EventArgs e)
        {
            Group group = new Group()
            {
                Name = textBoxAddGroupe.Text
            };
            repGroup = work.Repository<Group>();
            repGroup.Add(group);
            dataGridAddG.DataSource = repGroup.GetAllData().Select(x => new
            {
                Id = x.Id,
                Name = x.Name,
            }).ToList();
            FillDatagreeds();
        }

        private void dataGridEditG_MouseClick(object sender, MouseEventArgs e)
        {
            repGroup = work.Repository<Group>();
            var id = dataGridEditG.SelectedRows[0].Cells[0].Value;
            group = repGroup.FindById(id);
            textBoxEditGroupe.Text = group.Name;
        }
        private void textBoxEditGroupe_TextChanged(object sender, EventArgs e)
        {
            group.Name = textBoxEditGroupe.Text;
        }
        private void buttonEditGroupe_Click(object sender, EventArgs e)
        {
            repGroup = work.Repository<Group>();
            repGroup.Update(group);
            dataGridEditG.DataSource = repGroup.GetAllData().Select(x => new { Id = x.Id, Name = x.Name }).ToList();
            group = null;
            FillDatagreeds();
        }

        private void dataGridDelG_MouseClick(object sender, MouseEventArgs e)
        {
            repGroup = work.Repository<Group>();
            var id = dataGridDelG.SelectedRows[0].Cells[0].Value;
            group = repGroup.FindById(id);
            textBoxDelGr.Text = group.Name;
        }
        private void buttonDelGr_Click(object sender, EventArgs e)
        {
            repGroup = work.Repository<Group>();
            repGroup.Remove(group);
            dataGridDelG.DataSource = repGroup.GetAllData().Select(x => new { Id = x.Id, Name = x.Name }).ToList();
            textBoxDelGr.Text = "";
            group = null;
            FillDatagreeds();
        }

        private void comboBoxAdUtoG_SelectedIndexChanged(object sender, EventArgs e)
        {
            repGroup = work.Repository<Group>();
            group= repGroup.FindAll(x => x.Name == comboBoxAdUtoG.SelectedItem.ToString()).FirstOrDefault();
            dataGridViewUinG.DataSource = group.Users.Select(x => new
            {
                Id = x.Id,
                FirstName = x.FName,
                LastName = x.LName,
                IsAdmin = x.IsAdmin,
                Group = group.Name
            }).ToList();
        }
        private void dataGridViewUforG_MouseClick(object sender, MouseEventArgs e)
        {
            buttonAddUinG.Enabled = true;
            buttonDelUserfromGr.Enabled = false;
            repUser = work.Repository<User>();
            var id = dataGridViewUforG.SelectedRows[0].Cells[0].Value;
            user = repUser.FindById(id);
        }
        private void buttonAddUinG_Click(object sender, EventArgs e)
        {
            repGroup = work.Repository<Group>();
            if (group.Users.Contains(user))
            {
                MessageBox.Show("There is such user, try another one!");
            }
            else
            {
                group.Users.Add(user);
                repGroup.Update(group);
                dataGridViewUinG.DataSource = group.Users.Select(x => new
                {
                    Id = x.Id,
                    FirstName = x.FName,
                    LastName = x.LName,
                    IsAdmin = x.IsAdmin,
                    Group = group.Name
                }).ToList();
            }
        }

        private void dataGridViewUinG_MouseClick(object sender, MouseEventArgs e)
        {
            buttonDelUserfromGr.Enabled = true;
            buttonAddUinG.Enabled = false;
            repUser = work.Repository<User>();
            var id = dataGridViewUinG.SelectedRows[0].Cells[0].Value;
            user = repUser.FindById(id);
        }

        private void buttonDelUserfromGr_Click(object sender, EventArgs e)
        {
            repGroup = work.Repository<Group>();
            group.Users.Remove(user);
            repGroup.Update(group);
            dataGridViewUinG.DataSource = group.Users.Select(x => new
            {
                Id = x.Id,
                FirstName = x.FName,
                LastName = x.LName,
                IsAdmin = x.IsAdmin,
                Group = group.Name
            }).ToList();
        }
    }
}
