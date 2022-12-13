
namespace AfterEffects
{
    partial class Form3
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
            this.button4 = new System.Windows.Forms.Button();
            this.lbl_Subject = new System.Windows.Forms.Label();
            this.txt_Subject = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Replace = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FormatComboBox = new System.Windows.Forms.ComboBox();
            this.lbl_Output = new System.Windows.Forms.Label();
            this.txt_Output = new System.Windows.Forms.TextBox();
            this.lbl_Filename = new System.Windows.Forms.Label();
            this.txt_Filename = new System.Windows.Forms.TextBox();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.chk_Hidden = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Frames = new System.Windows.Forms.TextBox();
            this.chk_OneFrame = new System.Windows.Forms.CheckBox();
            this.combo_kind = new System.Windows.Forms.ComboBox();
            this.chk_LeftSide = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_NameTitle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_NameRelated = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_Flach = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Render = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(315, 119);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Ofira";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lbl_Subject
            // 
            this.lbl_Subject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Subject.AutoSize = true;
            this.lbl_Subject.Location = new System.Drawing.Point(228, 24);
            this.lbl_Subject.Name = "lbl_Subject";
            this.lbl_Subject.Size = new System.Drawing.Size(73, 13);
            this.lbl_Subject.TabIndex = 50;
            this.lbl_Subject.Text = "משפט ראשון";
            // 
            // txt_Subject
            // 
            this.txt_Subject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Subject.Location = new System.Drawing.Point(29, 21);
            this.txt_Subject.Name = "txt_Subject";
            this.txt_Subject.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Subject.Size = new System.Drawing.Size(193, 20);
            this.txt_Subject.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "משפט שני";
            // 
            // txt_Replace
            // 
            this.txt_Replace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Replace.Location = new System.Drawing.Point(29, 47);
            this.txt_Replace.Name = "txt_Replace";
            this.txt_Replace.Size = new System.Drawing.Size(193, 20);
            this.txt_Replace.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "Format:";
            // 
            // FormatComboBox
            // 
            this.FormatComboBox.FormattingEnabled = true;
            this.FormatComboBox.Items.AddRange(new object[] {
            "PNG Sequence",
            "QT Alpha",
            "Quicktime (Animation)"});
            this.FormatComboBox.Location = new System.Drawing.Point(75, 63);
            this.FormatComboBox.Name = "FormatComboBox";
            this.FormatComboBox.Size = new System.Drawing.Size(155, 21);
            this.FormatComboBox.TabIndex = 58;
            // 
            // lbl_Output
            // 
            this.lbl_Output.AutoSize = true;
            this.lbl_Output.Location = new System.Drawing.Point(25, 39);
            this.lbl_Output.Name = "lbl_Output";
            this.lbl_Output.Size = new System.Drawing.Size(39, 13);
            this.lbl_Output.TabIndex = 57;
            this.lbl_Output.Text = "Folder:";
            // 
            // txt_Output
            // 
            this.txt_Output.Location = new System.Drawing.Point(75, 36);
            this.txt_Output.Name = "txt_Output";
            this.txt_Output.Size = new System.Drawing.Size(155, 20);
            this.txt_Output.TabIndex = 56;
            // 
            // lbl_Filename
            // 
            this.lbl_Filename.AutoSize = true;
            this.lbl_Filename.Location = new System.Drawing.Point(12, 13);
            this.lbl_Filename.Name = "lbl_Filename";
            this.lbl_Filename.Size = new System.Drawing.Size(52, 13);
            this.lbl_Filename.TabIndex = 55;
            this.lbl_Filename.Text = "Filename:";
            // 
            // txt_Filename
            // 
            this.txt_Filename.Location = new System.Drawing.Point(75, 10);
            this.txt_Filename.Name = "txt_Filename";
            this.txt_Filename.Size = new System.Drawing.Size(155, 20);
            this.txt_Filename.TabIndex = 54;
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(140, 160);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(37, 13);
            this.lbl_Status.TabIndex = 60;
            this.lbl_Status.Text = "Status";
            // 
            // chk_Hidden
            // 
            this.chk_Hidden.AutoSize = true;
            this.chk_Hidden.Checked = true;
            this.chk_Hidden.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_Hidden.Location = new System.Drawing.Point(23, 119);
            this.chk_Hidden.Name = "chk_Hidden";
            this.chk_Hidden.Size = new System.Drawing.Size(60, 17);
            this.chk_Hidden.TabIndex = 61;
            this.chk_Hidden.Text = "Hidden";
            this.chk_Hidden.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 63;
            this.label3.Text = "Frames:";
            this.label3.Visible = false;
            // 
            // txt_Frames
            // 
            this.txt_Frames.Location = new System.Drawing.Point(75, 90);
            this.txt_Frames.Name = "txt_Frames";
            this.txt_Frames.Size = new System.Drawing.Size(155, 20);
            this.txt_Frames.TabIndex = 62;
            this.txt_Frames.Text = "300";
            this.txt_Frames.Visible = false;
            // 
            // chk_OneFrame
            // 
            this.chk_OneFrame.AutoSize = true;
            this.chk_OneFrame.Checked = true;
            this.chk_OneFrame.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_OneFrame.Location = new System.Drawing.Point(282, 96);
            this.chk_OneFrame.Name = "chk_OneFrame";
            this.chk_OneFrame.Size = new System.Drawing.Size(89, 17);
            this.chk_OneFrame.TabIndex = 64;
            this.chk_OneFrame.Text = "No Animation";
            this.chk_OneFrame.UseVisualStyleBackColor = true;
            // 
            // combo_kind
            // 
            this.combo_kind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_kind.DropDownWidth = 50;
            this.combo_kind.FormattingEnabled = true;
            this.combo_kind.Items.AddRange(new object[] {
            "סופר שם",
            "פלאח",
            "פאלח מתחלף",
            "באדיבות"});
            this.combo_kind.Location = new System.Drawing.Point(250, 56);
            this.combo_kind.Name = "combo_kind";
            this.combo_kind.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.combo_kind.Size = new System.Drawing.Size(121, 21);
            this.combo_kind.TabIndex = 65;
            this.combo_kind.SelectedIndexChanged += new System.EventHandler(this.combo_kind_SelectedIndexChanged);
            // 
            // chk_LeftSide
            // 
            this.chk_LeftSide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_LeftSide.AutoSize = true;
            this.chk_LeftSide.Location = new System.Drawing.Point(36, 100);
            this.chk_LeftSide.Name = "chk_LeftSide";
            this.chk_LeftSide.Size = new System.Drawing.Size(74, 17);
            this.chk_LeftSide.TabIndex = 66;
            this.chk_LeftSide.Text = "צד שמאל";
            this.chk_LeftSide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chk_LeftSide.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 70;
            this.label4.Text = "שם";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(38, 48);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(102, 20);
            this.txt_Name.TabIndex = 68;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 69;
            this.label5.Text = "תפקיד";
            // 
            // txt_NameTitle
            // 
            this.txt_NameTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_NameTitle.Location = new System.Drawing.Point(37, 22);
            this.txt_NameTitle.Name = "txt_NameTitle";
            this.txt_NameTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_NameTitle.Size = new System.Drawing.Size(102, 20);
            this.txt_NameTitle.TabIndex = 67;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(146, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 72;
            this.label6.Text = "שיוך";
            // 
            // txt_NameRelated
            // 
            this.txt_NameRelated.Location = new System.Drawing.Point(38, 74);
            this.txt_NameRelated.Name = "txt_NameRelated";
            this.txt_NameRelated.Size = new System.Drawing.Size(102, 20);
            this.txt_NameRelated.TabIndex = 71;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_Subject);
            this.groupBox1.Controls.Add(this.lbl_Subject);
            this.groupBox1.Controls.Add(this.txt_Replace);
            this.groupBox1.Location = new System.Drawing.Point(375, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(319, 84);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "פלאח מתחלף";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_NameRelated);
            this.groupBox2.Controls.Add(this.txt_NameTitle);
            this.groupBox2.Controls.Add(this.chk_LeftSide);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_Name);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(396, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(198, 129);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "סופר שם";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_Flach);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(59, 184);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(275, 52);
            this.groupBox3.TabIndex = 74;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "פלאח";
            // 
            // txt_Flach
            // 
            this.txt_Flach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Flach.Location = new System.Drawing.Point(16, 21);
            this.txt_Flach.Name = "txt_Flach";
            this.txt_Flach.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Flach.Size = new System.Drawing.Size(201, 20);
            this.txt_Flach.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(223, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 50;
            this.label8.Text = "טקסט";
            // 
            // btn_Render
            // 
            this.btn_Render.Location = new System.Drawing.Point(59, 155);
            this.btn_Render.Name = "btn_Render";
            this.btn_Render.Size = new System.Drawing.Size(75, 23);
            this.btn_Render.TabIndex = 75;
            this.btn_Render.Text = "Render";
            this.btn_Render.UseVisualStyleBackColor = true;
            this.btn_Render.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 286);
            this.Controls.Add(this.btn_Render);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.combo_kind);
            this.Controls.Add(this.chk_OneFrame);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Frames);
            this.Controls.Add(this.chk_Hidden);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FormatComboBox);
            this.Controls.Add(this.lbl_Output);
            this.Controls.Add(this.txt_Output);
            this.Controls.Add(this.lbl_Filename);
            this.Controls.Add(this.txt_Filename);
            this.Controls.Add(this.button4);
            this.Name = "Form3";
            this.Text = "Form3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lbl_Subject;
        private System.Windows.Forms.TextBox txt_Subject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Replace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox FormatComboBox;
        private System.Windows.Forms.Label lbl_Output;
        private System.Windows.Forms.TextBox txt_Output;
        private System.Windows.Forms.Label lbl_Filename;
        private System.Windows.Forms.TextBox txt_Filename;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.CheckBox chk_Hidden;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Frames;
        private System.Windows.Forms.CheckBox chk_OneFrame;
        private System.Windows.Forms.ComboBox combo_kind;
        private System.Windows.Forms.CheckBox chk_LeftSide;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_NameTitle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_NameRelated;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_Flach;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_Render;
    }
}