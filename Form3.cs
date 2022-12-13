using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Newtonsoft.Json;

namespace AfterEffects
{
    public partial class Form3 : Form
    {
        #region Initilize Parameters
        const string WorkingFolder = @"D:\Projects\Ofira\Ofira_GFX\";
        const string _ProjectFileName = "Ofira_GFX_V4";

        readonly string outputJsonFile = $@"{WorkingFolder}\Settings.json";
        readonly string _ProjectLocation = $@"{WorkingFolder}\{_ProjectFileName}.aep";
        string _CompName = "TEST"; // Render_HEB 

        //const string WorkingFolder = @"D:\Projects\Automation\";
        //readonly string outputJsonFile = $@"{WorkingFolder}\Colors.json";
        //readonly string _ProjectLocation = $@"{WorkingFolder}\AutoV1.aep";
        //string _CompName = "Render_ENG"; // Render_HEB

        int jobId = 1;
        #endregion

        #region Google Spreadsheets
        static readonly string[] Scopes = { SheetsService.Scope.Spreadsheets };
        static readonly string ApplicationName = "Application Name";
        static readonly string SpreadSheetId = "1a6wnlb70JjpRli9WzUOoSVTndqusqwFHqTb9Qvx5n1M";
        static readonly string Sheet = "Titles";
        static SheetsService service;
        #endregion

        #region AE_Render
        static readonly string x0 = "\"" + "Program Files" + "\"";
        static readonly string x1 = "\"" + "Adobe After Effects 2021" + "\"";
        static readonly string x2 = "\"" + "Support Files" + "\"";
        readonly string AErender2 = $@"D:\WindowsInstallations\Adobe\{x1}\{x2}\aerender.exe";
        readonly string AErender = $@"C:\{x0}\Adobe\{x1}\{x2}\aerender.exe";
        #endregion

        public Form3()
        {
            InitializeComponent();
            FormatComboBox.SelectedIndex = 0;
            txt_Output.Text = WorkingFolder + "Renders\\";
            txt_Filename.Text = "Test";
        }


        private void UpdateJsonFile()
        {
            Ofira_Info entry = new Ofira_Info
            {
                TitleText1 = Reverse(HebrewStringModify_New(txt_Subject.Text)),
                TitleText2 = Reverse(HebrewStringModify_New(txt_Replace.Text)),
                Title = "",
                Name = "",
                Related = "",
                LeftSide = chk_LeftSide.Checked

            };

            string x = JsonConvert.SerializeObject(entry, Formatting.Indented);

            File.WriteAllText(outputJsonFile, x);
        }
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        static bool HebrewDetection(string value)
        {
            bool found = false;
            #region Adding hebrew letters to Char List
            List<Char> hebrewLettersList = new List<char>();
            string hebrewLetters = "אבגדהוזחטיכךלמםנןסעפףצץקרשת";
            foreach (var letter in hebrewLetters)
            {
                hebrewLettersList.Add(letter);
            }
            #endregion

            //txtInputString.Text = "abcאdבef";
            var input = value;

            for (int i = 0; i < hebrewLettersList.Count; i++)
            {
                if (input.Contains(hebrewLettersList[i]))
                {
                    found = true;
                    break;
                }
            }

            //foreach (var item in input)
            //{
            //    for (int i = 0; i < hebrewLettersList.Count; i++)
            //    {
            //        if (item == hebrewLettersList[i])
            //        {
            //            found = true;
            //            break;
            //        }
            //    }
            //}

            //if (found)
            //    return true;
            //else
            //    return false;
            return found;
        }
        static string HebrewStringModify_New(string s)
        {
            List<string> FullText = new List<string>();
            var txtInput = s;
            var line = txtInput.Split(' ');
            foreach (string word in line)
            {
                string tempWord = string.Empty;

                if (HebrewDetection(word))
                {
                    tempWord = Reverse(word);

                    //txtTestOutput.Text = "Hebrew Found";
                }
                else
                {
                    tempWord = word;
                }

                if (tempWord.Contains(","))
                {
                    string x = tempWord.Replace(",", "");
                    string y = "," + x;
                    tempWord = y;
                }


                if (tempWord.Contains("-"))
                {
                    var MixString = word.Split('-');

                    List<string> DevidedString = new List<string>();
                    foreach (string inner_word in MixString)
                    {
                        try
                        {
                            var x = Convert.ToDouble(inner_word);
                            DevidedString.Add(inner_word);
                        }
                        catch (Exception)
                        {
                            DevidedString.Reverse();
                            DevidedString.Add(inner_word);
                        }
                    }

                    DevidedString.Reverse();
                    string combindedString2 = string.Join("-", DevidedString.ToArray());
                    tempWord = combindedString2;
                }


                if (tempWord.Contains(":"))
                {
                    // Split and reverse number if double????
                }

                FullText.Add(tempWord);
            }
            FullText.Reverse();
            string combindedString = string.Join(" ", FullText.ToArray());
            combindedString = Reverse(combindedString);
            return combindedString;
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            UpdateJsonFile();
            lbl_Status.Text = "Preparing GFX";

            var titleText1 = Reverse(HebrewStringModify_New(txt_Subject.Text));
            var titleText2 = Reverse(HebrewStringModify_New(txt_Replace.Text));
            var format = FormatComboBox.Text;
            var filename = txt_Filename.Text;
            var outputFolder = txt_Output.Text;

            if (string.IsNullOrEmpty(txt_Replace.Text))
            {
                await Task.Run(() => { RenderFiles_Flach(format, filename, outputFolder); });
            }
            else
            {
                await Task.Run(() => { RenderFiles_Change(format, filename, outputFolder); });

            }
        }
        private async void RenderFiles()
        {
            var titleText = Reverse(HebrewStringModify_New(txt_Subject.Text));
            var titleText2 = Reverse(HebrewStringModify_New(txt_Replace.Text));

            var format = FormatComboBox.Text;
            var filename = txt_Filename.Text;
            var outputFolder = txt_Output.Text;

            _CompName = "TEST";

            string outFilename = filename + "_[#####].png";
            int frames = Convert.ToInt32(txt_Frames.Text);

            Directory.CreateDirectory(outputFolder + filename);
            outputFolder = outputFolder + filename + "\\";

            string Command;

            Command = $" -project {_ProjectLocation} -comp \"{_CompName}\" -RStemplate \"Best Settings\" -OMtemplate \"{format}\" -s 1 -e {frames} -output {outputFolder}{outFilename}";

            ProcessStartInfo ps = new ProcessStartInfo();

            if (chk_Hidden.Checked)
            {
                ps.FileName = "cmd.exe";
                ps.CreateNoWindow = true;
                ps.WindowStyle = ProcessWindowStyle.Hidden;
                ps.Arguments = @"/C " + AErender + Command;
                ps.Verb = "runas";
            }
            else
            {
                ps.FileName = "cmd.exe";
                ps.CreateNoWindow = false;
                ps.WindowStyle = ProcessWindowStyle.Normal;
                ps.Arguments = @"/C " + AErender + Command;
                ps.Verb = "runas";
            }

            Process.Start(ps).WaitForExit();
            this.BeginInvoke((Action)delegate ()
            {
                lbl_Status.Text = "Finished";
            });
        }
        private async void RenderFiles_Flach(string format, string filename, string outputFolder)
        {
            _CompName = "flach";
            int frames = 175;
            string outFilename = filename + "_[#####].png";

            if (chk_OneFrame.Checked)
            {
                _CompName = "static";
                frames = 1;
                outFilename = filename + "_STATIC";
                format = "PNG Sequence Frame";
            }
            
            Directory.CreateDirectory(outputFolder + filename);
            outputFolder = outputFolder + filename + "\\";

            string Command;

            Command = $" -project {_ProjectLocation} -comp \"{_CompName}\" -RStemplate \"Best Settings\" -OMtemplate \"{format}\" -s 1 -e {frames} -output {outputFolder}{outFilename}";

            ProcessStartInfo ps = new ProcessStartInfo();

            if (chk_Hidden.Checked)
            {
                ps.FileName = "cmd.exe";
                ps.CreateNoWindow = true;
                ps.WindowStyle = ProcessWindowStyle.Hidden;
                ps.Arguments = @"/C " + AErender + Command;
                ps.Verb = "runas";
            }
            else
            {
                ps.FileName = "cmd.exe";
                ps.CreateNoWindow = false;
                ps.WindowStyle = ProcessWindowStyle.Normal;
                ps.Arguments = @"/C " + AErender + Command;
                ps.Verb = "runas";
            }

            Process.Start(ps).WaitForExit();
            this.BeginInvoke((Action)delegate ()
            {
                lbl_Status.Text = "Finished";
            });
        }

        private async void RenderFiles_Change(string format, string filename, string outputFolder)
        {
            _CompName = "change";
            int frames = 300;
            //int frames = Convert.ToInt32(txt_Frames.Text);

            string outFilename = filename + "_[#####].png";

            Directory.CreateDirectory(outputFolder + filename);
            outputFolder = outputFolder + filename + "\\";

            string Command;

            Command = $" -project {_ProjectLocation} -comp \"{_CompName}\" -RStemplate \"Best Settings\" -OMtemplate \"{format}\" -s 1 -e {frames} -output {outputFolder}{outFilename}";

            ProcessStartInfo ps = new ProcessStartInfo();

            if (chk_Hidden.Checked)
            {
                ps.FileName = "cmd.exe";
                ps.CreateNoWindow = true;
                ps.WindowStyle = ProcessWindowStyle.Hidden;
                ps.Arguments = @"/C " + AErender + Command;
                ps.Verb = "runas";
            }
            else
            {
                ps.FileName = "cmd.exe";
                ps.CreateNoWindow = false;
                ps.WindowStyle = ProcessWindowStyle.Normal;
                ps.Arguments = @"/C " + AErender + Command;
                ps.Verb = "runas";
            }

            Process.Start(ps).WaitForExit();
            this.BeginInvoke((Action)delegate ()
            {
                lbl_Status.Text = "Finished";
            });
        }

        private void combo_kind_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(combo_kind.Text);


            //if (combo_kind.Text == "פלאח")
            //    MessageBox.Show("פלאח");
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            UpdateJsonFile();
            lbl_Status.Text = "Preparing GFX";

            var titleText1 = Reverse(HebrewStringModify_New(txt_Flach.Text));
            //var titleText2 = Reverse(HebrewStringModify_New(txt_Replace.Text));
            var format = FormatComboBox.Text;
            var filename = txt_Filename.Text;
            var outputFolder = txt_Output.Text;

            await Task.Run(() => { RenderFiles_Flach(format, filename, outputFolder); });
            
        }
    }
}
