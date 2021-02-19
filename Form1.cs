using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AfterEffects
{
    public partial class Form1 : Form
    {
        static readonly string x1 = "\"" + "Adobe After Effects 2020" + "\"";
        static readonly string x2 = "\"" + "Support Files" + "\"";
        readonly string AErender = $@"D:\WindowsInstallations\Adobe\{x1}\{x2}\aerender.exe";

        string _CompName = "Render_ENG"; // Render_HEB
        string outputJsonFile = @"D:\Projects\Automation\Colors.json";
        readonly string _ProjectLocation = @"D:\Projects\Automation\AutoV1.aep";

        // search AERENDER.EXE on computer. If found save location. if there's no location saved search for one.


        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            jobBindingSource.Add(new Job()
            {
                Filename = "File1",
                TitleText = "Title1",
                SubjectText = "MainText1"
            });

            jobBindingSource.Add(new Job()
            {
                Filename = "File2",
                TitleText = "Title2",
                SubjectText = "MainText2"
            });

            txt_Title.Text = "Companies destructions";
            txt_Subject.Text = "Why is there so many elctronic stuff?";
            txt_Filename.Text = "Test_File";

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if ((txt_Title.Text.Length <= 0) || (txt_Subject.Text.Length <= 0) || (txt_Filename.Text.Length <= 0) || (txt_Output.Text.Length <= 0))
            {
                return;
            }
            //if (running)
            //{
            //    lbl_Status.Text = "Process already in progress";
            //    return;
            //}
            //UpdateJsonFile();
            var x = txt_Title.Text;
            var y = txt_Subject.Text;
            var z = txt_Filename.Text;
            var w = chk_Hebrew.Checked;
            ClearForm();
            await Task.Run(() =>
            {
                RenderFiles(x, y, z, w);
            });

        }
        void ClearForm()
        {
            txt_Title.Clear();
            txt_Subject.Clear();
            txt_Filename.Clear();
            chk_Hebrew.Checked = false;

            txt_Title.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //CreateJsonFile(/*colorObject*/);
            GetColor();


            //txt_Title.Text = Reverse(txt_Title.Text);
            //txt_Subject.Text = Reverse(txt_Subject.Text);
            //dataGridView1.Rows[0].Cells[4].Value = DBNull.Value;
            //dataGridView1.Rows[0].Cells[5].Value = DBNull.Value;
            //dataGridView1.Rows[0].Cells[1].Value = DBNull.Value;
        }
        private void UpdateJsonFile()
        {
            ColorObject colorObject = new ColorObject
            {
                Title_R = TitlePBox.BackColor.R,
                Title_B = TitlePBox.BackColor.B,
                Title_G = TitlePBox.BackColor.G,

                TitleBG_R = TitleBackgroundPBox.BackColor.R,
                TitleBG_B = TitleBackgroundPBox.BackColor.B,
                TitleBG_G = TitleBackgroundPBox.BackColor.G,

                Subject_R = SubjectPBox.BackColor.R,
                Subject_B = SubjectPBox.BackColor.B,
                Subject_G = SubjectPBox.BackColor.G,

                SubjectBG_R = SubjectBackgroundPBox.BackColor.R,
                SubjectBG_B = SubjectBackgroundPBox.BackColor.B,
                SubjectBG_G = SubjectBackgroundPBox.BackColor.G
            };

            string x = JsonConvert.SerializeObject(colorObject, Formatting.Indented);

            File.WriteAllText(outputJsonFile, x);
        }
        private void UpdateTextFile(string _title, string _subject)
        {
            // Create a string array that consists of three lines.
            string[] lines = { "title", _title, _subject };
            // WriteAllLines creates a file, writes a collection of strings to the file,
            // and then closes the file.  You do NOT need to call Flush() or Close().
            System.IO.File.WriteAllLines(@"D:\Projects\Automation\file.txt", lines);
            Thread.Sleep(1500);
        }
        private void RenderFiles(string _title, string _subject, string _fileName, bool hebrew)
        {
            if (hebrew)
            {
                _title = Reverse(_title);
                _subject = Reverse(_subject);
                _CompName = "Render_HEB";
            }
            else
            {
                _CompName = "Render_ENG";
                //_CompName = "Comp1";
            }

            UpdateJsonFile();
            UpdateTextFile(_title, _subject);

            string outputFolder = @txt_Output.Text;
            string outFilename = _fileName + "_[#####].png";

            Directory.CreateDirectory(outputFolder + _fileName);
            outputFolder = outputFolder + _fileName + "\\";

            string Command;

            #region need fix because of sourceTimeAtSource
            //if (chk_Animation.Checked)
            //{
            //    Command = " -project " + _ProjectLocation + " -comp " + "\"" + _CompName + "\"" + " -s 1 -e 50 -output " + outputFolder + outFilename;
            //}
            //else
            //{
            //    //outFilename = _fileName + ".png";
            //    Command = " -project " + _ProjectLocation + " -comp " + "\"" + _CompName + "\"" + " -s 50 -e 50 -output " + outputFolder + outFilename;
            //}
            #endregion

            Command = $" -project {_ProjectLocation} -comp \"{_CompName}\" -s 1 -e 50 -output {outputFolder}{outFilename}";


            ProcessStartInfo ps = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden,
                Arguments = @"/C " + AErender + Command,
                Verb = "runas"
            };
            Process.Start(ps).WaitForExit();

            this.BeginInvoke((Action)delegate ()
            {
                lbl_Status.Text = "Finished";
            }); // Counter visable
        }
        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    jobBindingSource.RemoveCurrent();

                }
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "Run")
            {
                if (MessageBox.Show("Are you sure you want to RUN this?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var id = dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                    var filename = dataGridView1.Rows[e.RowIndex].Cells[1].Value;
                    var TitleText = dataGridView1.Rows[e.RowIndex].Cells[2].Value;
                    var MainText = dataGridView1.Rows[e.RowIndex].Cells[3].Value;

                    lbl_Status.Text = "In Progress...";

                    await Task.Run(() =>
                    {
                        //RenderFiles(TitleText.ToString(), MainText.ToString(), filename.ToString());

                        dataGridView1.Rows[e.RowIndex].Cells[4].Value = DBNull.Value;
                        dataGridView1.Rows[e.RowIndex].Cells[5].Value = "Finished";
                    });

                    //MessageBox.Show("Convert finished");


                    //jobBindingSource.RemoveCurrent();

                }
            }
        }
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }





        private Color GetColor()
        {
            if (colorDialog1.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                string rgbR = colorDialog1.Color.R.ToString();
                string rgbG = colorDialog1.Color.G.ToString();
                string rgbB = colorDialog1.Color.B.ToString();
                string rgbResult = $"{rgbR},{rgbB},{rgbG}";
                string x = JsonConvert.SerializeObject(rgbResult);
                return colorDialog1.Color;
            }
            else
                return Color.White;

        }
        private void TitlePBox_Click(object sender, EventArgs e)
        {
            var color = GetColor();
            TitlePBox.BackColor = color;
            lbl_TitleSample.ForeColor = color;
        }
        private void TitleBackgroundPBox_Click(object sender, EventArgs e)
        {
            var color = GetColor();
            TitleBackgroundPBox.BackColor = color;
            lbl_TitleSample.BackColor = color;
        }
        private void SubjectPBox_Click(object sender, EventArgs e)
        {
            var color = GetColor();
            SubjectPBox.BackColor = color;
            lbl_SubjectSample.ForeColor = color;
        }
        private void SubjectBackgroundPBox_Click(object sender, EventArgs e)
        {
            var color = GetColor();
            SubjectBackgroundPBox.BackColor = color;
            lbl_SubjectSample.BackColor = color;
        }
    }
}
