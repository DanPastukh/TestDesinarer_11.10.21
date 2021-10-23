
namespace TestClient
{
    partial class UserTestForm
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
            this.comboBoxUserGroups = new System.Windows.Forms.ComboBox();
            this.groupBoxQuestion = new System.Windows.Forms.GroupBox();
            this.buttonAnswer = new System.Windows.Forms.Button();
            this.buttonNextQuestion = new System.Windows.Forms.Button();
            this.labelAnswer = new System.Windows.Forms.Label();
            this.labelAnswers = new System.Windows.Forms.Label();
            this.listBoxAnswers = new System.Windows.Forms.ListBox();
            this.textBoxQuestDescr = new System.Windows.Forms.TextBox();
            this.textBoxLName = new System.Windows.Forms.TextBox();
            this.textBoxFName = new System.Windows.Forms.TextBox();
            this.labelGroup = new System.Windows.Forms.Label();
            this.labelLName = new System.Windows.Forms.Label();
            this.labelFName = new System.Windows.Forms.Label();
            this.dataGridViewTests = new System.Windows.Forms.DataGridView();
            this.buttonPassTest = new System.Windows.Forms.Button();
            this.buttonLoadTest = new System.Windows.Forms.Button();
            this.groupBoxQuestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTests)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxUserGroups
            // 
            this.comboBoxUserGroups.FormattingEnabled = true;
            this.comboBoxUserGroups.Location = new System.Drawing.Point(419, 3);
            this.comboBoxUserGroups.Name = "comboBoxUserGroups";
            this.comboBoxUserGroups.Size = new System.Drawing.Size(96, 21);
            this.comboBoxUserGroups.TabIndex = 20;
            this.comboBoxUserGroups.SelectedIndexChanged += new System.EventHandler(this.comboBoxUserGroups_SelectedIndexChanged);
            // 
            // groupBoxQuestion
            // 
            this.groupBoxQuestion.Controls.Add(this.buttonAnswer);
            this.groupBoxQuestion.Controls.Add(this.buttonNextQuestion);
            this.groupBoxQuestion.Controls.Add(this.labelAnswer);
            this.groupBoxQuestion.Controls.Add(this.labelAnswers);
            this.groupBoxQuestion.Controls.Add(this.listBoxAnswers);
            this.groupBoxQuestion.Controls.Add(this.textBoxQuestDescr);
            this.groupBoxQuestion.Enabled = false;
            this.groupBoxQuestion.Location = new System.Drawing.Point(521, 2);
            this.groupBoxQuestion.Name = "groupBoxQuestion";
            this.groupBoxQuestion.Size = new System.Drawing.Size(238, 349);
            this.groupBoxQuestion.TabIndex = 19;
            this.groupBoxQuestion.TabStop = false;
            // 
            // buttonAnswer
            // 
            this.buttonAnswer.Enabled = false;
            this.buttonAnswer.Location = new System.Drawing.Point(5, 320);
            this.buttonAnswer.Name = "buttonAnswer";
            this.buttonAnswer.Size = new System.Drawing.Size(102, 23);
            this.buttonAnswer.TabIndex = 5;
            this.buttonAnswer.Text = "Answer";
            this.buttonAnswer.UseVisualStyleBackColor = true;
            this.buttonAnswer.Click += new System.EventHandler(this.buttonAnswer_Click);
            // 
            // buttonNextQuestion
            // 
            this.buttonNextQuestion.Enabled = false;
            this.buttonNextQuestion.Location = new System.Drawing.Point(132, 320);
            this.buttonNextQuestion.Name = "buttonNextQuestion";
            this.buttonNextQuestion.Size = new System.Drawing.Size(99, 23);
            this.buttonNextQuestion.TabIndex = 4;
            this.buttonNextQuestion.Text = "Next Question";
            this.buttonNextQuestion.UseVisualStyleBackColor = true;
            this.buttonNextQuestion.Click += new System.EventHandler(this.buttonNextQuestion_Click);
            // 
            // labelAnswer
            // 
            this.labelAnswer.AutoSize = true;
            this.labelAnswer.Location = new System.Drawing.Point(6, 16);
            this.labelAnswer.Name = "labelAnswer";
            this.labelAnswer.Size = new System.Drawing.Size(52, 13);
            this.labelAnswer.TabIndex = 3;
            this.labelAnswer.Text = "Question:";
            // 
            // labelAnswers
            // 
            this.labelAnswers.AutoSize = true;
            this.labelAnswers.Location = new System.Drawing.Point(6, 131);
            this.labelAnswers.Name = "labelAnswers";
            this.labelAnswers.Size = new System.Drawing.Size(50, 13);
            this.labelAnswers.TabIndex = 2;
            this.labelAnswers.Text = "Answers:";
            // 
            // listBoxAnswers
            // 
            this.listBoxAnswers.FormattingEnabled = true;
            this.listBoxAnswers.Location = new System.Drawing.Point(6, 147);
            this.listBoxAnswers.Name = "listBoxAnswers";
            this.listBoxAnswers.Size = new System.Drawing.Size(225, 160);
            this.listBoxAnswers.TabIndex = 1;
            this.listBoxAnswers.SelectedIndexChanged += new System.EventHandler(this.listBoxAnswers_SelectedIndexChanged);
            // 
            // textBoxQuestDescr
            // 
            this.textBoxQuestDescr.Location = new System.Drawing.Point(5, 32);
            this.textBoxQuestDescr.Multiline = true;
            this.textBoxQuestDescr.Name = "textBoxQuestDescr";
            this.textBoxQuestDescr.ReadOnly = true;
            this.textBoxQuestDescr.Size = new System.Drawing.Size(226, 85);
            this.textBoxQuestDescr.TabIndex = 0;
            // 
            // textBoxLName
            // 
            this.textBoxLName.Location = new System.Drawing.Point(251, 2);
            this.textBoxLName.Name = "textBoxLName";
            this.textBoxLName.Size = new System.Drawing.Size(100, 20);
            this.textBoxLName.TabIndex = 18;
            // 
            // textBoxFName
            // 
            this.textBoxFName.Location = new System.Drawing.Point(74, 3);
            this.textBoxFName.Name = "textBoxFName";
            this.textBoxFName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFName.TabIndex = 17;
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Location = new System.Drawing.Point(374, 9);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(44, 13);
            this.labelGroup.TabIndex = 16;
            this.labelGroup.Text = "Groups:";
            // 
            // labelLName
            // 
            this.labelLName.AutoSize = true;
            this.labelLName.Location = new System.Drawing.Point(184, 9);
            this.labelLName.Name = "labelLName";
            this.labelLName.Size = new System.Drawing.Size(61, 13);
            this.labelLName.TabIndex = 15;
            this.labelLName.Text = "Last Name:";
            // 
            // labelFName
            // 
            this.labelFName.AutoSize = true;
            this.labelFName.Location = new System.Drawing.Point(12, 9);
            this.labelFName.Name = "labelFName";
            this.labelFName.Size = new System.Drawing.Size(60, 13);
            this.labelFName.TabIndex = 14;
            this.labelFName.Text = "First Name:";
            // 
            // dataGridViewTests
            // 
            this.dataGridViewTests.AllowUserToAddRows = false;
            this.dataGridViewTests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTests.Location = new System.Drawing.Point(12, 38);
            this.dataGridViewTests.Name = "dataGridViewTests";
            this.dataGridViewTests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTests.Size = new System.Drawing.Size(503, 252);
            this.dataGridViewTests.TabIndex = 13;
            this.dataGridViewTests.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewTests_MouseClick);
            // 
            // buttonPassTest
            // 
            this.buttonPassTest.Enabled = false;
            this.buttonPassTest.Location = new System.Drawing.Point(348, 307);
            this.buttonPassTest.Name = "buttonPassTest";
            this.buttonPassTest.Size = new System.Drawing.Size(167, 44);
            this.buttonPassTest.TabIndex = 12;
            this.buttonPassTest.TabStop = false;
            this.buttonPassTest.Text = "Pass Test";
            this.buttonPassTest.UseVisualStyleBackColor = true;
            this.buttonPassTest.Click += new System.EventHandler(this.buttonPassTest_Click);
            // 
            // buttonLoadTest
            // 
            this.buttonLoadTest.Location = new System.Drawing.Point(12, 307);
            this.buttonLoadTest.Name = "buttonLoadTest";
            this.buttonLoadTest.Size = new System.Drawing.Size(162, 44);
            this.buttonLoadTest.TabIndex = 11;
            this.buttonLoadTest.Text = "Load Tests";
            this.buttonLoadTest.UseVisualStyleBackColor = true;
            this.buttonLoadTest.Click += new System.EventHandler(this.buttonLoadTest_Click);
            // 
            // UserTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 357);
            this.Controls.Add(this.comboBoxUserGroups);
            this.Controls.Add(this.groupBoxQuestion);
            this.Controls.Add(this.textBoxLName);
            this.Controls.Add(this.textBoxFName);
            this.Controls.Add(this.labelGroup);
            this.Controls.Add(this.labelLName);
            this.Controls.Add(this.labelFName);
            this.Controls.Add(this.dataGridViewTests);
            this.Controls.Add(this.buttonPassTest);
            this.Controls.Add(this.buttonLoadTest);
            this.Name = "UserTestForm";
            this.Text = "UserTestForm";
            this.groupBoxQuestion.ResumeLayout(false);
            this.groupBoxQuestion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxUserGroups;
        private System.Windows.Forms.GroupBox groupBoxQuestion;
        private System.Windows.Forms.Button buttonNextQuestion;
        private System.Windows.Forms.Label labelAnswer;
        private System.Windows.Forms.Label labelAnswers;
        private System.Windows.Forms.ListBox listBoxAnswers;
        private System.Windows.Forms.TextBox textBoxQuestDescr;
        private System.Windows.Forms.TextBox textBoxLName;
        private System.Windows.Forms.TextBox textBoxFName;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.Label labelLName;
        private System.Windows.Forms.Label labelFName;
        private System.Windows.Forms.DataGridView dataGridViewTests;
        private System.Windows.Forms.Button buttonPassTest;
        private System.Windows.Forms.Button buttonLoadTest;
        private System.Windows.Forms.Button buttonAnswer;
    }
}