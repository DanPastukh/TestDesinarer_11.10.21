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

            //Groups
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
            dataGridViewUinG.DataSource = null; 
            comboBoxAdUtoG.Items.Clear();
            comboBoxAdUtoG.Items.AddRange(repGroup.GetAllData().Select(x => x.Name).ToArray());
            //Users
            dataGridAllU.DataSource = repUser.GetAllData().Select(x => new {
                Id = x.Id,
                FirstName = x.FName,
                LastName = x.LName,
                Login = x.Login,
                Password = x.Password,
                IsAdmin = x.IsAdmin
            }).ToList();
            dataGridViewAddU.DataSource = repUser.GetAllData().Select(x => new {
                Id = x.Id,
                FirsName = x.FName,
                LastName = x.LName,
                Login = x.Login,
                Password = x.Password,
                IsAdmin = x.IsAdmin
            }).ToList();
            dataGridEditU.DataSource = repUser.GetAllData().Select(x => new {
                Id = x.Id,
                FirstName = x.FName,
                LastName = x.LName,
                Login = x.Login,
                Password = x.Password,
                IsAdmin = x.IsAdmin
            }).ToList();
            dataGridDelUser.DataSource = repUser.GetAllData().Select(x => new {
                Id = x.Id,
                FirstName = x.FName,
                LastName = x.LName,
                Login = x.Login,
                Password = x.Password,
                IsAdmin = x.IsAdmin
            }).ToList();

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
            
            


        }
        #region//Groups
        private void buttonAddGroupe_Click(object sender, EventArgs e)
        {
            Group group = new Group()
            {
                Name = textBoxAddGroupe.Text
            };
            repGroup.Add(group);
            FillDatagreeds();
        }

        private void dataGridEditG_MouseClick(object sender, MouseEventArgs e)
        {
            var id = dataGridEditG.SelectedRows[0].Cells[0].Value;
            group = repGroup.FindById(id);
            textBoxEditGroupe.Text = group.Name;
        }
        private void buttonEditGroupe_Click(object sender, EventArgs e)
        {
            group.Name = textBoxEditGroupe.Text;
            repGroup.Update(group);
            group = null;
            FillDatagreeds();
            textBoxEditGroupe.Text = "";
        }

        private void dataGridDelG_MouseClick(object sender, MouseEventArgs e)
        {
            var id = dataGridDelG.SelectedRows[0].Cells[0].Value;
            group = repGroup.FindById(id);
            textBoxDelGr.Text = group.Name;
        }
        private void buttonDelGr_Click(object sender, EventArgs e)
        {
            repGroup.Remove(group);
            textBoxDelGr.Text = "";
            group = null;
            FillDatagreeds();
        }

        private void comboBoxAdUtoG_SelectedIndexChanged(object sender, EventArgs e)
        {
            group= repGroup.FindAll(x => x.Name == comboBoxAdUtoG.SelectedItem.ToString()).FirstOrDefault();
            FillDatagreeds();
            dataGridViewUinG.DataSource = group.Users.Select(x => new
            {
                Id = x.Id,
                FirstName = x.FName,
                LastName = x.LName,
                IsAdmin = x.IsAdmin,
                Group = group.Name
            }).ToList();
            //comboBoxAdUtoG.Text = group.Name;
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
        #endregion

       
        private void buttonAddU_Click(object sender, EventArgs e)
        {
            user = repUser.FindAll(x => x.Login == textBoxLogin.Text).FirstOrDefault();
            if (textBoxFName.Text != "" && textBoxLname.Text != "" && textBoxLogin.Text != "" && textBoxPwd.Text != ""&& textBoxConfPwd.Text!="") 
            {
                if (user==null||user.Login != textBoxLogin.Text)
                {
                    if (textBoxPwd.Text == textBoxConfPwd.Text)
                    {
                        user = new User()
                        {
                            FName = textBoxFName.Text,
                            LName = textBoxLname.Text,
                            Login = textBoxLogin.Text,
                            Password = textBoxPwd.Text,
                            IsAdmin = checkBoxIsAdm.Checked
                        };
                        repUser = work.Repository<User>();
                        repUser.Add(user);
                        FillDatagreeds();
                        textBoxFName.Text = "";
                        textBoxLname.Text = "";
                        textBoxLogin.Text = "";
                        textBoxPwd.Text = "";
                        textBoxConfPwd.Text = "";
                        checkBoxIsAdm.Checked = false;
                    }
                    else
                    {
                        MessageBox.Show("Enter corect pasword to confirm!");
                    }
                }
                else
                {
                    MessageBox.Show("Such login is used, try another!");
                }
            }
            else
            {
                MessageBox.Show("Fill all data of user!");
            }
            user = null;
        }

        private void dataGridEditU_MouseClick(object sender, MouseEventArgs e)
        {
            var id = dataGridEditU.SelectedRows[0].Cells[0].Value;
            user = repUser.FindById(id);
            textBoxEdFN.Text = user.FName;
            textBoxEdLN.Text = user.LName;
            textBoxELog.Text = user.Login;
            textBoxEditPwd.Text = user.Password;
            checkBoxEdIsAdm.Checked = user.IsAdmin;
            buttonEditUser.Enabled = true;
        }

        private void buttonEditUser_Click(object sender, EventArgs e)
        {
           // User  tmp = repUser.FindAll(x => x.Login == textBoxELog.Text).Where(x=>x.Login!=user.Login).FirstOrDefault();
            if (textBoxEdFN.Text != "" && textBoxEdLN.Text != "" && textBoxELog.Text != "" && textBoxEditPwd.Text != "" && textBoxEconfP.Text != "")
            {
                //if (tmp == null )
                //{
                    if (textBoxEditPwd.Text == textBoxEconfP.Text)
                    {
                    user.FName = textBoxEdFN.Text;
                    user.LName = textBoxEdLN.Text;
                    user.Login = textBoxELog.Text;
                    user.Password = textBoxEditPwd.Text;
                    user.IsAdmin = checkBoxEdIsAdm.Checked;
                    repUser.Update(user);
                    FillDatagreeds();
                    textBoxEdFN.Text = "";
                    textBoxEdLN.Text = "";
                    textBoxELog.Text = "";
                    textBoxEditPwd.Text = "";
                    textBoxEconfP.Text = "";
                    checkBoxEdIsAdm.Checked = false;
                    buttonEditUser.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Enter corect pasword to confirm!");
                    }
                //}
                //else
                //{
                //    MessageBox.Show("Such login is used, try another!");
                //}
            }
            else
            {
                MessageBox.Show("Fill all data of user!");
            }
        }

        private void dataGridDelUser_MouseClick(object sender, MouseEventArgs e)
        {
            var id = dataGridDelUser.SelectedRows[0].Cells[0].Value;
            user = repUser.FindById(id);
            buttonDelUser.Enabled = true;
        }

        private void buttonDelUser_Click(object sender, EventArgs e)
        {
            repUser.Remove(user);
            FillDatagreeds();
            buttonDelUser.Enabled = false;
        }
    }
}
