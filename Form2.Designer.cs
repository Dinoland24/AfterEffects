
namespace AfterEffects
{
    partial class Form2
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
            this.lbl_Status = new System.Windows.Forms.Label();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_SubjectSample = new System.Windows.Forms.Label();
            this.lbl_TitleSample = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SubjectBackgroundPBox = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SubjectPBox = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TitleBackgroundPBox = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TitlePBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Magenta = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Animated = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Run = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.lblTest = new System.Windows.Forms.Label();
            this.btn_Ofira = new System.Windows.Forms.Button();
            this.txtTestInput = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button6 = new System.Windows.Forms.Button();
            this.txtTestOutput = new System.Windows.Forms.TextBox();
            this.chk_Magenta = new System.Windows.Forms.CheckBox();
            this.chk_ShowProgress = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Test = new System.Windows.Forms.Button();
            this.txt_FilePath = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_CompName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.jobIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outputFolderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hebrewDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.JobsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectBackgroundPBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectPBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitleBackgroundPBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitlePBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JobsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(103, 192);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(40, 13);
            this.lbl_Status.TabIndex = 16;
            this.lbl_Status.Text = "Status:";
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Location = new System.Drawing.Point(45, 192);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(40, 13);
            this.lbl_1.TabIndex = 15;
            this.lbl_1.Text = "Status:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(137, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Fetch Data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Format:";
            // 
            // chk_Hebrew
            // 
            this.chk_Hebrew.AutoSize = true;
            this.chk_Hebrew.Location = new System.Drawing.Point(305, 78);
            this.chk_Hebrew.Name = "chk_Hebrew";
            this.chk_Hebrew.Size = new System.Drawing.Size(63, 17);
            this.chk_Hebrew.TabIndex = 30;
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
            this.FormatComboBox.Location = new System.Drawing.Point(106, 158);
            this.FormatComboBox.Name = "FormatComboBox";
            this.FormatComboBox.Size = new System.Drawing.Size(193, 21);
            this.FormatComboBox.TabIndex = 29;
            // 
            // lbl_Output
            // 
            this.lbl_Output.AutoSize = true;
            this.lbl_Output.Location = new System.Drawing.Point(43, 134);
            this.lbl_Output.Name = "lbl_Output";
            this.lbl_Output.Size = new System.Drawing.Size(42, 13);
            this.lbl_Output.TabIndex = 28;
            this.lbl_Output.Text = "Output:";
            // 
            // txt_Output
            // 
            this.txt_Output.Location = new System.Drawing.Point(106, 131);
            this.txt_Output.Name = "txt_Output";
            this.txt_Output.Size = new System.Drawing.Size(193, 20);
            this.txt_Output.TabIndex = 27;
            this.txt_Output.Text = "D:\\Projects\\Sport\\RENDERS\\";
            // 
            // chk_Animation
            // 
            this.chk_Animation.AutoSize = true;
            this.chk_Animation.Location = new System.Drawing.Point(305, 56);
            this.chk_Animation.Name = "chk_Animation";
            this.chk_Animation.Size = new System.Drawing.Size(72, 17);
            this.chk_Animation.TabIndex = 26;
            this.chk_Animation.Text = "Animation";
            this.chk_Animation.UseVisualStyleBackColor = true;
            // 
            // lbl_Filename
            // 
            this.lbl_Filename.AutoSize = true;
            this.lbl_Filename.Location = new System.Drawing.Point(43, 108);
            this.lbl_Filename.Name = "lbl_Filename";
            this.lbl_Filename.Size = new System.Drawing.Size(52, 13);
            this.lbl_Filename.TabIndex = 25;
            this.lbl_Filename.Text = "Filename:";
            // 
            // txt_Filename
            // 
            this.txt_Filename.Location = new System.Drawing.Point(106, 105);
            this.txt_Filename.Name = "txt_Filename";
            this.txt_Filename.Size = new System.Drawing.Size(193, 20);
            this.txt_Filename.TabIndex = 24;
            // 
            // lbl_Subject
            // 
            this.lbl_Subject.AutoSize = true;
            this.lbl_Subject.Location = new System.Drawing.Point(43, 82);
            this.lbl_Subject.Name = "lbl_Subject";
            this.lbl_Subject.Size = new System.Drawing.Size(46, 13);
            this.lbl_Subject.TabIndex = 23;
            this.lbl_Subject.Text = "Subject:";
            // 
            // txt_Subject
            // 
            this.txt_Subject.Location = new System.Drawing.Point(106, 79);
            this.txt_Subject.Name = "txt_Subject";
            this.txt_Subject.Size = new System.Drawing.Size(193, 20);
            this.txt_Subject.TabIndex = 22;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Location = new System.Drawing.Point(43, 56);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(30, 13);
            this.lbl_Title.TabIndex = 21;
            this.lbl_Title.Text = "Title:";
            // 
            // txt_Title
            // 
            this.txt_Title.Location = new System.Drawing.Point(106, 53);
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.Size = new System.Drawing.Size(193, 20);
            this.txt_Title.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_SubjectSample);
            this.groupBox1.Controls.Add(this.lbl_TitleSample);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(1012, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 73);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Text Sample:";
            this.groupBox1.Visible = false;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Subject:";
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
            // SubjectBackgroundPBox
            // 
            this.SubjectBackgroundPBox.BackColor = System.Drawing.Color.Teal;
            this.SubjectBackgroundPBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SubjectBackgroundPBox.Location = new System.Drawing.Point(430, 110);
            this.SubjectBackgroundPBox.Name = "SubjectBackgroundPBox";
            this.SubjectBackgroundPBox.Size = new System.Drawing.Size(18, 18);
            this.SubjectBackgroundPBox.TabIndex = 41;
            this.SubjectBackgroundPBox.TabStop = false;
            this.SubjectBackgroundPBox.Click += new System.EventHandler(this.SubjectBackgroundPBox_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(448, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Subject Background Color";
            // 
            // SubjectPBox
            // 
            this.SubjectPBox.BackColor = System.Drawing.Color.Black;
            this.SubjectPBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SubjectPBox.Location = new System.Drawing.Point(430, 86);
            this.SubjectPBox.Name = "SubjectPBox";
            this.SubjectPBox.Size = new System.Drawing.Size(18, 18);
            this.SubjectPBox.TabIndex = 39;
            this.SubjectPBox.TabStop = false;
            this.SubjectPBox.Click += new System.EventHandler(this.SubjectPBox_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(448, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Subject Color";
            // 
            // TitleBackgroundPBox
            // 
            this.TitleBackgroundPBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TitleBackgroundPBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TitleBackgroundPBox.Location = new System.Drawing.Point(430, 62);
            this.TitleBackgroundPBox.Name = "TitleBackgroundPBox";
            this.TitleBackgroundPBox.Size = new System.Drawing.Size(18, 18);
            this.TitleBackgroundPBox.TabIndex = 37;
            this.TitleBackgroundPBox.TabStop = false;
            this.TitleBackgroundPBox.Click += new System.EventHandler(this.TitleBackgroundPBox_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(448, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Title Background Color";
            // 
            // TitlePBox
            // 
            this.TitlePBox.BackColor = System.Drawing.Color.Gray;
            this.TitlePBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TitlePBox.Location = new System.Drawing.Point(430, 38);
            this.TitlePBox.Name = "TitlePBox";
            this.TitlePBox.Size = new System.Drawing.Size(18, 18);
            this.TitlePBox.TabIndex = 35;
            this.TitlePBox.TabStop = false;
            this.TitlePBox.Click += new System.EventHandler(this.TitlePBox_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(448, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Title Color";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jobIDDataGridViewTextBoxColumn,
            this.titleTextDataGridViewTextBoxColumn,
            this.subjectTextDataGridViewTextBoxColumn,
            this.formatDataGridViewTextBoxColumn,
            this.filenameDataGridViewTextBoxColumn,
            this.outputFolderDataGridViewTextBoxColumn,
            this.hebrewDataGridViewCheckBoxColumn,
            this.Magenta,
            this.Animated,
            this.Delete,
            this.Run,
            this.Status});
            this.dataGridView1.DataSource = this.JobsBindingSource;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridView1.Location = new System.Drawing.Point(17, 213);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1105, 292);
            this.dataGridView1.TabIndex = 43;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Magenta
            // 
            this.Magenta.DataPropertyName = "Magenta";
            this.Magenta.HeaderText = "Magenta";
            this.Magenta.Name = "Magenta";
            this.Magenta.Width = 55;
            // 
            // Animated
            // 
            this.Animated.DataPropertyName = "Animated";
            this.Animated.HeaderText = "Animated";
            this.Animated.Name = "Animated";
            this.Animated.Width = 60;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 46;
            // 
            // Run
            // 
            this.Run.HeaderText = "Run";
            this.Run.Name = "Run";
            this.Run.Text = "Run";
            this.Run.UseColumnTextForButtonValue = true;
            this.Run.Width = 40;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(224, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 44;
            this.button3.Text = "Run All";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTest.Location = new System.Drawing.Point(726, 28);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(76, 25);
            this.lblTest.TabIndex = 45;
            this.lblTest.Text = "label8";
            this.lblTest.Visible = false;
            // 
            // btn_Ofira
            // 
            this.btn_Ofira.Location = new System.Drawing.Point(407, 12);
            this.btn_Ofira.Name = "btn_Ofira";
            this.btn_Ofira.Size = new System.Drawing.Size(75, 23);
            this.btn_Ofira.TabIndex = 46;
            this.btn_Ofira.Text = "Ofira";
            this.btn_Ofira.UseVisualStyleBackColor = true;
            this.btn_Ofira.Click += new System.EventHandler(this.btn_Ofira_Click);
            // 
            // txtTestInput
            // 
            this.txtTestInput.Location = new System.Drawing.Point(6, 41);
            this.txtTestInput.Name = "txtTestInput";
            this.txtTestInput.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTestInput.Size = new System.Drawing.Size(470, 20);
            this.txtTestInput.TabIndex = 47;
            this.txtTestInput.Text = "בית ההשקעות Finance Capital (כלכלי)";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(930, 84);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(23, 23);
            this.button5.TabIndex = 48;
            this.button5.Text = "...";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(401, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 49;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // txtTestOutput
            // 
            this.txtTestOutput.Location = new System.Drawing.Point(6, 67);
            this.txtTestOutput.Name = "txtTestOutput";
            this.txtTestOutput.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTestOutput.Size = new System.Drawing.Size(470, 20);
            this.txtTestOutput.TabIndex = 50;
            // 
            // chk_Magenta
            // 
            this.chk_Magenta.AutoSize = true;
            this.chk_Magenta.Location = new System.Drawing.Point(305, 99);
            this.chk_Magenta.Name = "chk_Magenta";
            this.chk_Magenta.Size = new System.Drawing.Size(74, 17);
            this.chk_Magenta.TabIndex = 51;
            this.chk_Magenta.Text = "Magenta?";
            this.chk_Magenta.UseVisualStyleBackColor = true;
            // 
            // chk_ShowProgress
            // 
            this.chk_ShowProgress.AutoSize = true;
            this.chk_ShowProgress.Checked = true;
            this.chk_ShowProgress.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_ShowProgress.Location = new System.Drawing.Point(305, 122);
            this.chk_ShowProgress.Name = "chk_ShowProgress";
            this.chk_ShowProgress.Size = new System.Drawing.Size(97, 17);
            this.chk_ShowProgress.TabIndex = 52;
            this.chk_ShowProgress.Text = "Show Progress";
            this.chk_ShowProgress.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.txtTestInput);
            this.groupBox2.Controls.Add(this.txtTestOutput);
            this.groupBox2.Location = new System.Drawing.Point(521, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(490, 94);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            this.groupBox2.Visible = false;
            // 
            // btn_Test
            // 
            this.btn_Test.Location = new System.Drawing.Point(488, 12);
            this.btn_Test.Name = "btn_Test";
            this.btn_Test.Size = new System.Drawing.Size(75, 23);
            this.btn_Test.TabIndex = 54;
            this.btn_Test.Text = "TEST";
            this.btn_Test.UseVisualStyleBackColor = true;
            this.btn_Test.Click += new System.EventHandler(this.btn_Test_Click);
            // 
            // txt_FilePath
            // 
            this.txt_FilePath.Enabled = false;
            this.txt_FilePath.Location = new System.Drawing.Point(645, 86);
            this.txt_FilePath.Name = "txt_FilePath";
            this.txt_FilePath.Size = new System.Drawing.Size(280, 20);
            this.txt_FilePath.TabIndex = 55;
            this.txt_FilePath.Text = "D:\\Projects\\Igud_Tziburi\\IGUD_V5.aep";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(642, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 56;
            this.label8.Text = "Project File:";
            // 
            // txt_CompName
            // 
            this.txt_CompName.Location = new System.Drawing.Point(645, 127);
            this.txt_CompName.Name = "txt_CompName";
            this.txt_CompName.Size = new System.Drawing.Size(193, 20);
            this.txt_CompName.TabIndex = 57;
            this.txt_CompName.Text = "Flach_static";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(642, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 57;
            this.label9.Text = "Comp Name:";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(305, 12);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 58;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // jobIDDataGridViewTextBoxColumn
            // 
            this.jobIDDataGridViewTextBoxColumn.DataPropertyName = "JobID";
            this.jobIDDataGridViewTextBoxColumn.HeaderText = "JobID";
            this.jobIDDataGridViewTextBoxColumn.Name = "jobIDDataGridViewTextBoxColumn";
            this.jobIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // titleTextDataGridViewTextBoxColumn
            // 
            this.titleTextDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.titleTextDataGridViewTextBoxColumn.DataPropertyName = "TitleText";
            this.titleTextDataGridViewTextBoxColumn.HeaderText = "TitleText";
            this.titleTextDataGridViewTextBoxColumn.Name = "titleTextDataGridViewTextBoxColumn";
            this.titleTextDataGridViewTextBoxColumn.Width = 150;
            // 
            // subjectTextDataGridViewTextBoxColumn
            // 
            this.subjectTextDataGridViewTextBoxColumn.DataPropertyName = "SubjectText";
            this.subjectTextDataGridViewTextBoxColumn.HeaderText = "SubjectText";
            this.subjectTextDataGridViewTextBoxColumn.Name = "subjectTextDataGridViewTextBoxColumn";
            this.subjectTextDataGridViewTextBoxColumn.Width = 250;
            // 
            // formatDataGridViewTextBoxColumn
            // 
            this.formatDataGridViewTextBoxColumn.DataPropertyName = "Format";
            this.formatDataGridViewTextBoxColumn.HeaderText = "Format";
            this.formatDataGridViewTextBoxColumn.Name = "formatDataGridViewTextBoxColumn";
            // 
            // filenameDataGridViewTextBoxColumn
            // 
            this.filenameDataGridViewTextBoxColumn.DataPropertyName = "Filename";
            this.filenameDataGridViewTextBoxColumn.HeaderText = "Filename";
            this.filenameDataGridViewTextBoxColumn.Name = "filenameDataGridViewTextBoxColumn";
            // 
            // outputFolderDataGridViewTextBoxColumn
            // 
            this.outputFolderDataGridViewTextBoxColumn.DataPropertyName = "OutputFolder";
            this.outputFolderDataGridViewTextBoxColumn.HeaderText = "OutputFolder";
            this.outputFolderDataGridViewTextBoxColumn.Name = "outputFolderDataGridViewTextBoxColumn";
            // 
            // hebrewDataGridViewCheckBoxColumn
            // 
            this.hebrewDataGridViewCheckBoxColumn.DataPropertyName = "Hebrew";
            this.hebrewDataGridViewCheckBoxColumn.HeaderText = "Hebrew";
            this.hebrewDataGridViewCheckBoxColumn.Name = "hebrewDataGridViewCheckBoxColumn";
            this.hebrewDataGridViewCheckBoxColumn.Width = 50;
            // 
            // JobsBindingSource
            // 
            this.JobsBindingSource.DataSource = typeof(AfterEffects.Job);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 525);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.txt_CompName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_FilePath);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btn_Test);
            this.Controls.Add(this.chk_ShowProgress);
            this.Controls.Add(this.chk_Magenta);
            this.Controls.Add(this.btn_Ofira);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
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
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.lbl_1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectBackgroundPBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectPBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitleBackgroundPBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitlePBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JobsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_SubjectSample;
        private System.Windows.Forms.Label lbl_TitleSample;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox SubjectBackgroundPBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox SubjectPBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox TitleBackgroundPBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox TitlePBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.BindingSource JobsBindingSource;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Button btn_Ofira;
        private System.Windows.Forms.TextBox txtTestInput;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txtTestOutput;
        private System.Windows.Forms.CheckBox chk_Magenta;
        private System.Windows.Forms.CheckBox chk_ShowProgress;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn outputFolderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn hebrewDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Magenta;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Animated;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewButtonColumn Run;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Test;
        private System.Windows.Forms.TextBox txt_FilePath;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_CompName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_Clear;
    }
}