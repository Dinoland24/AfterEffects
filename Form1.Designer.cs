
namespace AfterEffects
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_Title = new System.Windows.Forms.TextBox();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_Subject = new System.Windows.Forms.Label();
            this.txt_Subject = new System.Windows.Forms.TextBox();
            this.lbl_Filename = new System.Windows.Forms.Label();
            this.txt_Filename = new System.Windows.Forms.TextBox();
            this.chk_Animation = new System.Windows.Forms.CheckBox();
            this.lbl_Output = new System.Windows.Forms.Label();
            this.txt_Output = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Run = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.chk_Hebrew = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.TitlePBox = new System.Windows.Forms.PictureBox();
            this.TitleBackgroundPBox = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SubjectPBox = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SubjectBackgroundPBox = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_SubjectSample = new System.Windows.Forms.Label();
            this.lbl_TitleSample = new System.Windows.Forms.Label();
            this.jobIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitlePBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitleBackgroundPBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectPBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectBackgroundPBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_Title
            // 
            this.txt_Title.Location = new System.Drawing.Point(115, 41);
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.Size = new System.Drawing.Size(193, 20);
            this.txt_Title.TabIndex = 1;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Location = new System.Drawing.Point(52, 44);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(30, 13);
            this.lbl_Title.TabIndex = 4;
            this.lbl_Title.Text = "Title:";
            // 
            // lbl_Subject
            // 
            this.lbl_Subject.AutoSize = true;
            this.lbl_Subject.Location = new System.Drawing.Point(52, 70);
            this.lbl_Subject.Name = "lbl_Subject";
            this.lbl_Subject.Size = new System.Drawing.Size(46, 13);
            this.lbl_Subject.TabIndex = 6;
            this.lbl_Subject.Text = "Subject:";
            // 
            // txt_Subject
            // 
            this.txt_Subject.Location = new System.Drawing.Point(115, 67);
            this.txt_Subject.Name = "txt_Subject";
            this.txt_Subject.Size = new System.Drawing.Size(193, 20);
            this.txt_Subject.TabIndex = 5;
            // 
            // lbl_Filename
            // 
            this.lbl_Filename.AutoSize = true;
            this.lbl_Filename.Location = new System.Drawing.Point(52, 96);
            this.lbl_Filename.Name = "lbl_Filename";
            this.lbl_Filename.Size = new System.Drawing.Size(52, 13);
            this.lbl_Filename.TabIndex = 8;
            this.lbl_Filename.Text = "Filename:";
            // 
            // txt_Filename
            // 
            this.txt_Filename.Location = new System.Drawing.Point(115, 93);
            this.txt_Filename.Name = "txt_Filename";
            this.txt_Filename.Size = new System.Drawing.Size(193, 20);
            this.txt_Filename.TabIndex = 7;
            // 
            // chk_Animation
            // 
            this.chk_Animation.AutoSize = true;
            this.chk_Animation.Location = new System.Drawing.Point(314, 44);
            this.chk_Animation.Name = "chk_Animation";
            this.chk_Animation.Size = new System.Drawing.Size(72, 17);
            this.chk_Animation.TabIndex = 9;
            this.chk_Animation.Text = "Animation";
            this.chk_Animation.UseVisualStyleBackColor = true;
            // 
            // lbl_Output
            // 
            this.lbl_Output.AutoSize = true;
            this.lbl_Output.Location = new System.Drawing.Point(52, 122);
            this.lbl_Output.Name = "lbl_Output";
            this.lbl_Output.Size = new System.Drawing.Size(42, 13);
            this.lbl_Output.TabIndex = 11;
            this.lbl_Output.Text = "Output:";
            // 
            // txt_Output
            // 
            this.txt_Output.Location = new System.Drawing.Point(115, 119);
            this.txt_Output.Name = "txt_Output";
            this.txt_Output.Size = new System.Drawing.Size(193, 20);
            this.txt_Output.TabIndex = 10;
            this.txt_Output.Text = "D:\\1\\";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "PNG (Image)",
            "PNG (Animation)",
            "Quicktime (Animation)"});
            this.comboBox1.Location = new System.Drawing.Point(115, 146);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(155, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Location = new System.Drawing.Point(55, 183);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(40, 13);
            this.lbl_1.TabIndex = 13;
            this.lbl_1.Text = "Status:";
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(112, 183);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(40, 13);
            this.lbl_Status.TabIndex = 14;
            this.lbl_Status.Text = "Status:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jobIDDataGridViewTextBoxColumn,
            this.filenameDataGridViewTextBoxColumn,
            this.titleTextDataGridViewTextBoxColumn,
            this.mainTextDataGridViewTextBoxColumn,
            this.Delete,
            this.Run});
            this.dataGridView1.DataSource = this.jobBindingSource;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(58, 239);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(600, 150);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // Run
            // 
            this.Run.HeaderText = "Run";
            this.Run.Name = "Run";
            this.Run.Text = "Run";
            this.Run.UseColumnTextForButtonValue = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(146, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // chk_Hebrew
            // 
            this.chk_Hebrew.AutoSize = true;
            this.chk_Hebrew.Location = new System.Drawing.Point(314, 66);
            this.chk_Hebrew.Name = "chk_Hebrew";
            this.chk_Hebrew.Size = new System.Drawing.Size(63, 17);
            this.chk_Hebrew.TabIndex = 18;
            this.chk_Hebrew.Text = "Hebrew";
            this.chk_Hebrew.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Format:";
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(492, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Title Color";
            // 
            // TitlePBox
            // 
            this.TitlePBox.BackColor = System.Drawing.Color.Gray;
            this.TitlePBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TitlePBox.Location = new System.Drawing.Point(474, 39);
            this.TitlePBox.Name = "TitlePBox";
            this.TitlePBox.Size = new System.Drawing.Size(18, 18);
            this.TitlePBox.TabIndex = 26;
            this.TitlePBox.TabStop = false;
            this.TitlePBox.Click += new System.EventHandler(this.TitlePBox_Click);
            // 
            // TitleBackgroundPBox
            // 
            this.TitleBackgroundPBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TitleBackgroundPBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TitleBackgroundPBox.Location = new System.Drawing.Point(474, 63);
            this.TitleBackgroundPBox.Name = "TitleBackgroundPBox";
            this.TitleBackgroundPBox.Size = new System.Drawing.Size(18, 18);
            this.TitleBackgroundPBox.TabIndex = 28;
            this.TitleBackgroundPBox.TabStop = false;
            this.TitleBackgroundPBox.Click += new System.EventHandler(this.TitleBackgroundPBox_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(492, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Title Background Color";
            // 
            // SubjectPBox
            // 
            this.SubjectPBox.BackColor = System.Drawing.Color.Black;
            this.SubjectPBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SubjectPBox.Location = new System.Drawing.Point(474, 87);
            this.SubjectPBox.Name = "SubjectPBox";
            this.SubjectPBox.Size = new System.Drawing.Size(18, 18);
            this.SubjectPBox.TabIndex = 30;
            this.SubjectPBox.TabStop = false;
            this.SubjectPBox.Click += new System.EventHandler(this.SubjectPBox_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(492, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Subject Color";
            // 
            // SubjectBackgroundPBox
            // 
            this.SubjectBackgroundPBox.BackColor = System.Drawing.Color.Teal;
            this.SubjectBackgroundPBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SubjectBackgroundPBox.Location = new System.Drawing.Point(474, 111);
            this.SubjectBackgroundPBox.Name = "SubjectBackgroundPBox";
            this.SubjectBackgroundPBox.Size = new System.Drawing.Size(18, 18);
            this.SubjectBackgroundPBox.TabIndex = 32;
            this.SubjectBackgroundPBox.TabStop = false;
            this.SubjectBackgroundPBox.Click += new System.EventHandler(this.SubjectBackgroundPBox_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(492, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Subject Background Color";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_SubjectSample);
            this.groupBox1.Controls.Add(this.lbl_TitleSample);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(434, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 73);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Text Sample:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Title:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Subject:";
            // 
            // lbl_SubjectSample
            // 
            this.lbl_SubjectSample.AutoSize = true;
            this.lbl_SubjectSample.Location = new System.Drawing.Point(82, 47);
            this.lbl_SubjectSample.Name = "lbl_SubjectSample";
            this.lbl_SubjectSample.Size = new System.Drawing.Size(81, 13);
            this.lbl_SubjectSample.TabIndex = 3;
            this.lbl_SubjectSample.Text = "Subject Sample";
            // 
            // lbl_TitleSample
            // 
            this.lbl_TitleSample.AutoSize = true;
            this.lbl_TitleSample.Location = new System.Drawing.Point(82, 25);
            this.lbl_TitleSample.Name = "lbl_TitleSample";
            this.lbl_TitleSample.Size = new System.Drawing.Size(65, 13);
            this.lbl_TitleSample.TabIndex = 2;
            this.lbl_TitleSample.Text = "Title Sample";
            // 
            // jobIDDataGridViewTextBoxColumn
            // 
            this.jobIDDataGridViewTextBoxColumn.DataPropertyName = "JobID";
            this.jobIDDataGridViewTextBoxColumn.HeaderText = "JobID";
            this.jobIDDataGridViewTextBoxColumn.Name = "jobIDDataGridViewTextBoxColumn";
            this.jobIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // filenameDataGridViewTextBoxColumn
            // 
            this.filenameDataGridViewTextBoxColumn.DataPropertyName = "Filename";
            this.filenameDataGridViewTextBoxColumn.HeaderText = "Filename";
            this.filenameDataGridViewTextBoxColumn.Name = "filenameDataGridViewTextBoxColumn";
            // 
            // titleTextDataGridViewTextBoxColumn
            // 
            this.titleTextDataGridViewTextBoxColumn.DataPropertyName = "TitleText";
            this.titleTextDataGridViewTextBoxColumn.HeaderText = "TitleText";
            this.titleTextDataGridViewTextBoxColumn.Name = "titleTextDataGridViewTextBoxColumn";
            // 
            // mainTextDataGridViewTextBoxColumn
            // 
            this.mainTextDataGridViewTextBoxColumn.DataPropertyName = "MainText";
            this.mainTextDataGridViewTextBoxColumn.HeaderText = "MainText";
            this.mainTextDataGridViewTextBoxColumn.Name = "mainTextDataGridViewTextBoxColumn";
            // 
            // jobBindingSource
            // 
            this.jobBindingSource.DataSource = typeof(AfterEffects.Job);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 401);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SubjectBackgroundPBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SubjectPBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TitleBackgroundPBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TitlePBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chk_Hebrew);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.lbl_1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbl_Output);
            this.Controls.Add(this.txt_Output);
            this.Controls.Add(this.chk_Animation);
            this.Controls.Add(this.lbl_Filename);
            this.Controls.Add(this.txt_Filename);
            this.Controls.Add(this.lbl_Subject);
            this.Controls.Add(this.txt_Subject);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.txt_Title);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "After Effects Render";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitlePBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitleBackgroundPBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectPBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectBackgroundPBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_Title;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_Subject;
        private System.Windows.Forms.TextBox txt_Subject;
        private System.Windows.Forms.Label lbl_Filename;
        private System.Windows.Forms.TextBox txt_Filename;
        private System.Windows.Forms.CheckBox chk_Animation;
        private System.Windows.Forms.Label lbl_Output;
        private System.Windows.Forms.TextBox txt_Output;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource jobBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewButtonColumn Run;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox chk_Hebrew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox TitlePBox;
        private System.Windows.Forms.PictureBox TitleBackgroundPBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox SubjectPBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox SubjectBackgroundPBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_SubjectSample;
        private System.Windows.Forms.Label lbl_TitleSample;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

