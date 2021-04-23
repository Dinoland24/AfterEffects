
namespace AfterEffects
{
    partial class Form_Ofira
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
            this.label1 = new System.Windows.Forms.Label();
            this.chk_Hebrew = new System.Windows.Forms.CheckBox();
            this.FormatComboBox = new System.Windows.Forms.ComboBox();
            this.lbl_Output = new System.Windows.Forms.Label();
            this.txt_Output = new System.Windows.Forms.TextBox();
            this.chk_Animation = new System.Windows.Forms.CheckBox();
            this.lbl_Filename = new System.Windows.Forms.Label();
            this.txt_Filename = new System.Windows.Forms.TextBox();
            this.lbl_Subject = new System.Windows.Forms.Label();
            this.txt_Subject = new System.Windows.Forms.TextBox();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.txt_Title = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.SubjectBackgroundPBox = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SubjectPBox = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TitleBackgroundPBox = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TitlePBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectBackgroundPBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectPBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitleBackgroundPBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitlePBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Format:";
            // 
            // chk_Hebrew
            // 
            this.chk_Hebrew.AutoSize = true;
            this.chk_Hebrew.Location = new System.Drawing.Point(511, 143);
            this.chk_Hebrew.Name = "chk_Hebrew";
            this.chk_Hebrew.Size = new System.Drawing.Size(63, 17);
            this.chk_Hebrew.TabIndex = 42;
            this.chk_Hebrew.Text = "Hebrew";
            this.chk_Hebrew.UseVisualStyleBackColor = true;
            // 
            // FormatComboBox
            // 
            this.FormatComboBox.FormattingEnabled = true;
            this.FormatComboBox.Items.AddRange(new object[] {
            "PNG Sequence",
            "QT Alpha",
            "Quicktime (Animation)"});
            this.FormatComboBox.Location = new System.Drawing.Point(94, 171);
            this.FormatComboBox.Name = "FormatComboBox";
            this.FormatComboBox.Size = new System.Drawing.Size(155, 21);
            this.FormatComboBox.TabIndex = 41;
            // 
            // lbl_Output
            // 
            this.lbl_Output.AutoSize = true;
            this.lbl_Output.Location = new System.Drawing.Point(31, 147);
            this.lbl_Output.Name = "lbl_Output";
            this.lbl_Output.Size = new System.Drawing.Size(42, 13);
            this.lbl_Output.TabIndex = 40;
            this.lbl_Output.Text = "Output:";
            // 
            // txt_Output
            // 
            this.txt_Output.Location = new System.Drawing.Point(94, 144);
            this.txt_Output.Name = "txt_Output";
            this.txt_Output.Size = new System.Drawing.Size(193, 20);
            this.txt_Output.TabIndex = 39;
            this.txt_Output.Text = "D:\\1\\";
            // 
            // chk_Animation
            // 
            this.chk_Animation.AutoSize = true;
            this.chk_Animation.Location = new System.Drawing.Point(511, 121);
            this.chk_Animation.Name = "chk_Animation";
            this.chk_Animation.Size = new System.Drawing.Size(72, 17);
            this.chk_Animation.TabIndex = 38;
            this.chk_Animation.Text = "Animation";
            this.chk_Animation.UseVisualStyleBackColor = true;
            // 
            // lbl_Filename
            // 
            this.lbl_Filename.AutoSize = true;
            this.lbl_Filename.Location = new System.Drawing.Point(31, 121);
            this.lbl_Filename.Name = "lbl_Filename";
            this.lbl_Filename.Size = new System.Drawing.Size(52, 13);
            this.lbl_Filename.TabIndex = 37;
            this.lbl_Filename.Text = "Filename:";
            // 
            // txt_Filename
            // 
            this.txt_Filename.Location = new System.Drawing.Point(94, 118);
            this.txt_Filename.Name = "txt_Filename";
            this.txt_Filename.Size = new System.Drawing.Size(193, 20);
            this.txt_Filename.TabIndex = 36;
            // 
            // lbl_Subject
            // 
            this.lbl_Subject.AutoSize = true;
            this.lbl_Subject.Location = new System.Drawing.Point(31, 95);
            this.lbl_Subject.Name = "lbl_Subject";
            this.lbl_Subject.Size = new System.Drawing.Size(46, 13);
            this.lbl_Subject.TabIndex = 35;
            this.lbl_Subject.Text = "Subject:";
            // 
            // txt_Subject
            // 
            this.txt_Subject.Location = new System.Drawing.Point(94, 92);
            this.txt_Subject.Name = "txt_Subject";
            this.txt_Subject.Size = new System.Drawing.Size(193, 20);
            this.txt_Subject.TabIndex = 34;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Location = new System.Drawing.Point(31, 69);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(30, 13);
            this.lbl_Title.TabIndex = 33;
            this.lbl_Title.Text = "Title:";
            // 
            // txt_Title
            // 
            this.txt_Title.Location = new System.Drawing.Point(94, 66);
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Title.Size = new System.Drawing.Size(193, 20);
            this.txt_Title.TabIndex = 32;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(34, 26);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 44;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "קרדיט אדיבות",
            "קרדיט שם ",
            "פלאח "});
            this.checkedListBox1.Location = new System.Drawing.Point(447, 174);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox1.TabIndex = 45;
            // 
            // SubjectBackgroundPBox
            // 
            this.SubjectBackgroundPBox.BackColor = System.Drawing.Color.Teal;
            this.SubjectBackgroundPBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SubjectBackgroundPBox.Location = new System.Drawing.Point(418, 82);
            this.SubjectBackgroundPBox.Name = "SubjectBackgroundPBox";
            this.SubjectBackgroundPBox.Size = new System.Drawing.Size(18, 18);
            this.SubjectBackgroundPBox.TabIndex = 53;
            this.SubjectBackgroundPBox.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(436, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Subject Background Color";
            // 
            // SubjectPBox
            // 
            this.SubjectPBox.BackColor = System.Drawing.Color.Black;
            this.SubjectPBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SubjectPBox.Location = new System.Drawing.Point(418, 58);
            this.SubjectPBox.Name = "SubjectPBox";
            this.SubjectPBox.Size = new System.Drawing.Size(18, 18);
            this.SubjectPBox.TabIndex = 51;
            this.SubjectPBox.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(436, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Subject Color";
            // 
            // TitleBackgroundPBox
            // 
            this.TitleBackgroundPBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TitleBackgroundPBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TitleBackgroundPBox.Location = new System.Drawing.Point(418, 34);
            this.TitleBackgroundPBox.Name = "TitleBackgroundPBox";
            this.TitleBackgroundPBox.Size = new System.Drawing.Size(18, 18);
            this.TitleBackgroundPBox.TabIndex = 49;
            this.TitleBackgroundPBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(436, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Title Background Color";
            // 
            // TitlePBox
            // 
            this.TitlePBox.BackColor = System.Drawing.Color.Gray;
            this.TitlePBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TitlePBox.Location = new System.Drawing.Point(418, 10);
            this.TitlePBox.Name = "TitlePBox";
            this.TitlePBox.Size = new System.Drawing.Size(18, 18);
            this.TitlePBox.TabIndex = 47;
            this.TitlePBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(436, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Title Color";
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(94, 208);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(37, 13);
            this.lbl_Status.TabIndex = 55;
            this.lbl_Status.Text = "Status";
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Location = new System.Drawing.Point(37, 208);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(40, 13);
            this.lbl_1.TabIndex = 54;
            this.lbl_1.Text = "Status:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(293, 69);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 56;
            this.label6.Text = "פלאח:";
            // 
            // Form_Ofira
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 335);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.lbl_1);
            this.Controls.Add(this.SubjectBackgroundPBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SubjectPBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TitleBackgroundPBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TitlePBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chk_Hebrew);
            this.Controls.Add(this.FormatComboBox);
            this.Controls.Add(this.lbl_Output);
            this.Controls.Add(this.txt_Output);
            this.Controls.Add(this.chk_Animation);
            this.Controls.Add(this.lbl_Filename);
            this.Controls.Add(this.txt_Filename);
            this.Controls.Add(this.lbl_Subject);
            this.Controls.Add(this.txt_Subject);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.txt_Title);
            this.Name = "Form_Ofira";
            this.Text = "Form_Ofira";
            ((System.ComponentModel.ISupportInitialize)(this.SubjectBackgroundPBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectPBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitleBackgroundPBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitlePBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chk_Hebrew;
        private System.Windows.Forms.ComboBox FormatComboBox;
        private System.Windows.Forms.Label lbl_Output;
        private System.Windows.Forms.TextBox txt_Output;
        private System.Windows.Forms.CheckBox chk_Animation;
        private System.Windows.Forms.Label lbl_Filename;
        private System.Windows.Forms.TextBox txt_Filename;
        private System.Windows.Forms.Label lbl_Subject;
        private System.Windows.Forms.TextBox txt_Subject;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.TextBox txt_Title;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.PictureBox SubjectBackgroundPBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox SubjectPBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox TitleBackgroundPBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox TitlePBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.Label label6;
    }
}