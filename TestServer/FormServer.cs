using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestServer
{
    public partial class FormServer : Form
    {
        DataGridView gridViewMain = new DataGridView();
        public FormServer()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // dataGridView1 = gridViewMain;
            //DataGridView dataGridView = new DataGridView();
            //dataGridView.AutoSize = true;
            dataGridView1.Visible = true;
            dataGridView1.Size = new Size(702, 262);
           
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //dataGridViewMain.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.Fill);
            //dataGridViewMain.Dock = DockStyle.Left;
            //dataGridView2 = gridViewMain;
            //dataGridView1.Visible = false;
            dataGridView1.Size = new Size(490, 262);
           
            groupBoxEditGroup.Visible = false;
            groupBoxDeleteGroup.Visible = false;
            groupBoxAddGroup.Visible = true;
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //dataGridView1.Visible = false;
            dataGridView1.Size = new Size(490, 262);
            groupBoxAddGroup.Visible = false;
            groupBoxDeleteGroup.Visible = false;
            groupBoxEditGroup.Visible = true;
            
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //dataGridView1.Visible = false;
            dataGridView1.Size = new Size(490, 262);
            groupBoxEditGroup.Visible = false;
            groupBoxAddGroup.Visible = false;
            groupBoxDeleteGroup.Visible = true;
        }

        private void buttonAddGroupe_Click(object sender, EventArgs e)
        {

        }
    }
}
