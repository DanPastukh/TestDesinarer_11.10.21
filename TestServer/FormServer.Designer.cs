
namespace TestServer
{
    partial class FormServer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.groupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBoxAddGroup = new System.Windows.Forms.GroupBox();
            this.groupBoxEditGroup = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEditGroupe = new System.Windows.Forms.TextBox();
            this.buttonEditGroupe = new System.Windows.Forms.Button();
            this.comboBoxGroupsForEdit = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAddGroupe = new System.Windows.Forms.TextBox();
            this.buttonAddGroupe = new System.Windows.Forms.Button();
            this.groupBoxDeleteGroup = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDeleteGroupe = new System.Windows.Forms.TextBox();
            this.buttonDeleteGroupe = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxAddGroup.SuspendLayout();
            this.groupBoxEditGroup.SuspendLayout();
            this.groupBoxDeleteGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStripMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.groupsToolStripMenuItem,
            this.toolStripMenuItem3});
            this.menuStripMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(63, 349);
            this.menuStripMain.TabIndex = 1;
            this.menuStripMain.Text = "menuStripMain";
            // 
            // groupsToolStripMenuItem
            // 
            this.groupsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.addUserToolStripMenuItem,
            this.showUsersToolStripMenuItem});
            this.groupsToolStripMenuItem.Name = "groupsToolStripMenuItem";
            this.groupsToolStripMenuItem.Size = new System.Drawing.Size(50, 19);
            this.groupsToolStripMenuItem.Text = "Groups";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "Show All groups";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "Add";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addUserToolStripMenuItem.Text = "Add user";
            // 
            // showUsersToolStripMenuItem
            // 
            this.showUsersToolStripMenuItem.Name = "showUsersToolStripMenuItem";
            this.showUsersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showUsersToolStripMenuItem.Text = "Show users";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(50, 19);
            this.toolStripMenuItem3.Text = " ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(82, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(506, 262);
            this.dataGridView1.TabIndex = 2;
            // 
            // groupBoxAddGroup
            // 
            this.groupBoxAddGroup.Controls.Add(this.buttonAddGroupe);
            this.groupBoxAddGroup.Controls.Add(this.textBoxAddGroupe);
            this.groupBoxAddGroup.Controls.Add(this.label1);
            this.groupBoxAddGroup.Location = new System.Drawing.Point(526, 87);
            this.groupBoxAddGroup.Name = "groupBoxAddGroup";
            this.groupBoxAddGroup.Size = new System.Drawing.Size(190, 262);
            this.groupBoxAddGroup.TabIndex = 4;
            this.groupBoxAddGroup.TabStop = false;
            this.groupBoxAddGroup.Text = "Add Group";
            this.groupBoxAddGroup.Visible = false;
            // 
            // groupBoxEditGroup
            // 
            this.groupBoxEditGroup.Controls.Add(this.label3);
            this.groupBoxEditGroup.Controls.Add(this.comboBoxGroupsForEdit);
            this.groupBoxEditGroup.Controls.Add(this.buttonEditGroupe);
            this.groupBoxEditGroup.Controls.Add(this.textBoxEditGroupe);
            this.groupBoxEditGroup.Controls.Add(this.label2);
            this.groupBoxEditGroup.Location = new System.Drawing.Point(594, 12);
            this.groupBoxEditGroup.Name = "groupBoxEditGroup";
            this.groupBoxEditGroup.Size = new System.Drawing.Size(187, 262);
            this.groupBoxEditGroup.TabIndex = 4;
            this.groupBoxEditGroup.TabStop = false;
            this.groupBoxEditGroup.Text = "Edit Group";
            this.groupBoxEditGroup.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(23, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Group Name";
            // 
            // textBoxEditGroupe
            // 
            this.textBoxEditGroupe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEditGroupe.Location = new System.Drawing.Point(23, 141);
            this.textBoxEditGroupe.Name = "textBoxEditGroupe";
            this.textBoxEditGroupe.Size = new System.Drawing.Size(145, 29);
            this.textBoxEditGroupe.TabIndex = 1;
            // 
            // buttonEditGroupe
            // 
            this.buttonEditGroupe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEditGroupe.Location = new System.Drawing.Point(23, 195);
            this.buttonEditGroupe.Name = "buttonEditGroupe";
            this.buttonEditGroupe.Size = new System.Drawing.Size(145, 39);
            this.buttonEditGroupe.TabIndex = 2;
            this.buttonEditGroupe.Text = "Edit Groupe";
            this.buttonEditGroupe.UseVisualStyleBackColor = true;
            // 
            // comboBoxGroupsForEdit
            // 
            this.comboBoxGroupsForEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxGroupsForEdit.FormattingEnabled = true;
            this.comboBoxGroupsForEdit.Location = new System.Drawing.Point(23, 50);
            this.comboBoxGroupsForEdit.Name = "comboBoxGroupsForEdit";
            this.comboBoxGroupsForEdit.Size = new System.Drawing.Size(142, 26);
            this.comboBoxGroupsForEdit.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(77, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "All Groupes";
            this.label3.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(30, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Group Name";
            // 
            // textBoxAddGroupe
            // 
            this.textBoxAddGroupe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAddGroupe.Location = new System.Drawing.Point(23, 99);
            this.textBoxAddGroupe.Name = "textBoxAddGroupe";
            this.textBoxAddGroupe.Size = new System.Drawing.Size(145, 29);
            this.textBoxAddGroupe.TabIndex = 1;
            // 
            // buttonAddGroupe
            // 
            this.buttonAddGroupe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddGroupe.Location = new System.Drawing.Point(23, 153);
            this.buttonAddGroupe.Name = "buttonAddGroupe";
            this.buttonAddGroupe.Size = new System.Drawing.Size(145, 39);
            this.buttonAddGroupe.TabIndex = 2;
            this.buttonAddGroupe.Text = "Add Groupe";
            this.buttonAddGroupe.UseVisualStyleBackColor = true;
            this.buttonAddGroupe.Click += new System.EventHandler(this.buttonAddGroupe_Click);
            // 
            // groupBoxDeleteGroup
            // 
            this.groupBoxDeleteGroup.Controls.Add(this.label4);
            this.groupBoxDeleteGroup.Controls.Add(this.comboBox1);
            this.groupBoxDeleteGroup.Controls.Add(this.buttonDeleteGroupe);
            this.groupBoxDeleteGroup.Controls.Add(this.textBoxDeleteGroupe);
            this.groupBoxDeleteGroup.Controls.Add(this.label5);
            this.groupBoxDeleteGroup.Location = new System.Drawing.Point(436, 130);
            this.groupBoxDeleteGroup.Name = "groupBoxDeleteGroup";
            this.groupBoxDeleteGroup.Size = new System.Drawing.Size(187, 262);
            this.groupBoxDeleteGroup.TabIndex = 4;
            this.groupBoxDeleteGroup.TabStop = false;
            this.groupBoxDeleteGroup.Text = "Delete Group";
            this.groupBoxDeleteGroup.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(23, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Group Name";
            // 
            // textBoxDeleteGroupe
            // 
            this.textBoxDeleteGroupe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDeleteGroupe.Location = new System.Drawing.Point(23, 141);
            this.textBoxDeleteGroupe.Name = "textBoxDeleteGroupe";
            this.textBoxDeleteGroupe.Size = new System.Drawing.Size(145, 29);
            this.textBoxDeleteGroupe.TabIndex = 1;
            // 
            // buttonDeleteGroupe
            // 
            this.buttonDeleteGroupe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteGroupe.Location = new System.Drawing.Point(23, 195);
            this.buttonDeleteGroupe.Name = "buttonDeleteGroupe";
            this.buttonDeleteGroupe.Size = new System.Drawing.Size(145, 39);
            this.buttonDeleteGroupe.TabIndex = 2;
            this.buttonDeleteGroupe.Text = "Delete Groupe";
            this.buttonDeleteGroupe.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(23, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 26);
            this.comboBox1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(54, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "All Groupes";
            // 
            // FormServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 349);
            this.Controls.Add(this.groupBoxAddGroup);
            this.Controls.Add(this.groupBoxDeleteGroup);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBoxEditGroup);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "FormServer";
            this.Text = "FormServer";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxAddGroup.ResumeLayout(false);
            this.groupBoxAddGroup.PerformLayout();
            this.groupBoxEditGroup.ResumeLayout(false);
            this.groupBoxEditGroup.PerformLayout();
            this.groupBoxDeleteGroup.ResumeLayout(false);
            this.groupBoxDeleteGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem groupsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showUsersToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.GroupBox groupBoxAddGroup;
        private System.Windows.Forms.Button buttonAddGroupe;
        private System.Windows.Forms.TextBox textBoxAddGroupe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxEditGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxGroupsForEdit;
        private System.Windows.Forms.Button buttonEditGroupe;
        private System.Windows.Forms.TextBox textBoxEditGroupe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxDeleteGroup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonDeleteGroupe;
        private System.Windows.Forms.TextBox textBoxDeleteGroupe;
        private System.Windows.Forms.Label label5;
    }
}