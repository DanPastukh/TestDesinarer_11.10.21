
namespace TestDesinarer_11._10._21
{
    partial class FormNewTest
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
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxAnswer = new System.Windows.Forms.GroupBox();
            this.groupBoxQuestion = new System.Windows.Forms.GroupBox();
            this.buttonAddCuestion = new System.Windows.Forms.Button();
            this.numericUpDownDificulty = new System.Windows.Forms.NumericUpDown();
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.checkBoxIsRight = new System.Windows.Forms.CheckBox();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.groupBoxSaveFile = new System.Windows.Forms.GroupBox();
            this.buttonSaveFile = new System.Windows.Forms.Button();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.listBoxAnswers = new System.Windows.Forms.ListBox();
            this.groupBoxInfo.SuspendLayout();
            this.groupBoxAnswer.SuspendLayout();
            this.groupBoxQuestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDificulty)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBoxSaveFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.textBoxTitle);
            this.groupBoxInfo.Controls.Add(this.textBoxAuthor);
            this.groupBoxInfo.Controls.Add(this.label2);
            this.groupBoxInfo.Controls.Add(this.label1);
            this.groupBoxInfo.Location = new System.Drawing.Point(12, 12);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(200, 86);
            this.groupBoxInfo.TabIndex = 0;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Info";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(71, 53);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(123, 20);
            this.textBoxTitle.TabIndex = 4;
            this.textBoxTitle.TextChanged += new System.EventHandler(this.textBoxTitle_TextChanged);
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(71, 22);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(123, 20);
            this.textBoxAuthor.TabIndex = 3;
            this.textBoxAuthor.TextChanged += new System.EventHandler(this.textBoxAuthor_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Author";
            // 
            // groupBoxAnswer
            // 
            this.groupBoxAnswer.Controls.Add(this.listBoxAnswers);
            this.groupBoxAnswer.Location = new System.Drawing.Point(12, 117);
            this.groupBoxAnswer.Name = "groupBoxAnswer";
            this.groupBoxAnswer.Size = new System.Drawing.Size(200, 167);
            this.groupBoxAnswer.TabIndex = 1;
            this.groupBoxAnswer.TabStop = false;
            this.groupBoxAnswer.Text = "Answers";
            // 
            // groupBoxQuestion
            // 
            this.groupBoxQuestion.Controls.Add(this.buttonAddCuestion);
            this.groupBoxQuestion.Controls.Add(this.numericUpDownDificulty);
            this.groupBoxQuestion.Controls.Add(this.textBoxQuestion);
            this.groupBoxQuestion.Controls.Add(this.label4);
            this.groupBoxQuestion.Location = new System.Drawing.Point(237, 12);
            this.groupBoxQuestion.Name = "groupBoxQuestion";
            this.groupBoxQuestion.Size = new System.Drawing.Size(383, 125);
            this.groupBoxQuestion.TabIndex = 2;
            this.groupBoxQuestion.TabStop = false;
            this.groupBoxQuestion.Text = "Question";
            // 
            // buttonAddCuestion
            // 
            this.buttonAddCuestion.Enabled = false;
            this.buttonAddCuestion.Location = new System.Drawing.Point(140, 82);
            this.buttonAddCuestion.Name = "buttonAddCuestion";
            this.buttonAddCuestion.Size = new System.Drawing.Size(237, 37);
            this.buttonAddCuestion.TabIndex = 5;
            this.buttonAddCuestion.Text = "Add Question";
            this.buttonAddCuestion.UseVisualStyleBackColor = true;
            this.buttonAddCuestion.Click += new System.EventHandler(this.buttonAddCuestion_Click);
            // 
            // numericUpDownDificulty
            // 
            this.numericUpDownDificulty.Location = new System.Drawing.Point(69, 92);
            this.numericUpDownDificulty.Name = "numericUpDownDificulty";
            this.numericUpDownDificulty.Size = new System.Drawing.Size(38, 20);
            this.numericUpDownDificulty.TabIndex = 4;
            this.numericUpDownDificulty.ValueChanged += new System.EventHandler(this.numericUpDownDificulty_ValueChanged);
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.Location = new System.Drawing.Point(6, 19);
            this.textBoxQuestion.Multiline = true;
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.Size = new System.Drawing.Size(371, 52);
            this.textBoxQuestion.TabIndex = 3;
            this.textBoxQuestion.TextChanged += new System.EventHandler(this.textBoxQuestion_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Dificulty";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonNext);
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Controls.Add(this.checkBoxIsRight);
            this.groupBox1.Controls.Add(this.textBoxAnswer);
            this.groupBox1.Location = new System.Drawing.Point(237, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 76);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Answer";
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(246, 46);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(131, 23);
            this.buttonNext.TabIndex = 6;
            this.buttonNext.Text = "Next Answer";
            this.buttonNext.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(110, 46);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(130, 23);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add Answer";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // checkBoxIsRight
            // 
            this.checkBoxIsRight.AutoSize = true;
            this.checkBoxIsRight.Location = new System.Drawing.Point(9, 50);
            this.checkBoxIsRight.Name = "checkBoxIsRight";
            this.checkBoxIsRight.Size = new System.Drawing.Size(62, 17);
            this.checkBoxIsRight.TabIndex = 5;
            this.checkBoxIsRight.Text = "Is Right";
            this.checkBoxIsRight.UseVisualStyleBackColor = true;
            this.checkBoxIsRight.CheckedChanged += new System.EventHandler(this.checkBoxIsRight_CheckedChanged);
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Location = new System.Drawing.Point(9, 19);
            this.textBoxAnswer.Multiline = true;
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(368, 25);
            this.textBoxAnswer.TabIndex = 4;
            this.textBoxAnswer.TextChanged += new System.EventHandler(this.textBoxAnswer_TextChanged);
            // 
            // groupBoxSaveFile
            // 
            this.groupBoxSaveFile.Controls.Add(this.buttonSaveFile);
            this.groupBoxSaveFile.Controls.Add(this.textBoxFileName);
            this.groupBoxSaveFile.Location = new System.Drawing.Point(237, 225);
            this.groupBoxSaveFile.Name = "groupBoxSaveFile";
            this.groupBoxSaveFile.Size = new System.Drawing.Size(383, 59);
            this.groupBoxSaveFile.TabIndex = 6;
            this.groupBoxSaveFile.TabStop = false;
            this.groupBoxSaveFile.Text = "Save File";
            // 
            // buttonSaveFile
            // 
            this.buttonSaveFile.Location = new System.Drawing.Point(268, 19);
            this.buttonSaveFile.Name = "buttonSaveFile";
            this.buttonSaveFile.Size = new System.Drawing.Size(107, 25);
            this.buttonSaveFile.TabIndex = 6;
            this.buttonSaveFile.Text = "SaveFile";
            this.buttonSaveFile.UseVisualStyleBackColor = true;
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(9, 19);
            this.textBoxFileName.Multiline = true;
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(253, 25);
            this.textBoxFileName.TabIndex = 4;
            // 
            // listBoxAnswers
            // 
            this.listBoxAnswers.FormattingEnabled = true;
            this.listBoxAnswers.Location = new System.Drawing.Point(3, 16);
            this.listBoxAnswers.Name = "listBoxAnswers";
            this.listBoxAnswers.Size = new System.Drawing.Size(191, 147);
            this.listBoxAnswers.TabIndex = 0;
            // 
            // FormNewTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 293);
            this.Controls.Add(this.groupBoxSaveFile);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxQuestion);
            this.Controls.Add(this.groupBoxAnswer);
            this.Controls.Add(this.groupBoxInfo);
            this.Name = "FormNewTest";
            this.Text = "FormNewTest";
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.groupBoxAnswer.ResumeLayout(false);
            this.groupBoxQuestion.ResumeLayout(false);
            this.groupBoxQuestion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDificulty)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxSaveFile.ResumeLayout(false);
            this.groupBoxSaveFile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxAnswer;
        private System.Windows.Forms.GroupBox groupBoxQuestion;
        private System.Windows.Forms.Button buttonAddCuestion;
        private System.Windows.Forms.NumericUpDown numericUpDownDificulty;
        private System.Windows.Forms.TextBox textBoxQuestion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.CheckBox checkBoxIsRight;
        private System.Windows.Forms.GroupBox groupBoxSaveFile;
        private System.Windows.Forms.Button buttonSaveFile;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.ListBox listBoxAnswers;
    }
}