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

using Google.Apis.Auth.OAuth2;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Color = System.Drawing.Color;

namespace AfterEffects
{
    public partial class Form_Ofira : Form
    {
        #region Initilize Parameters
        const string WorkingFolder = @"D:\Projects\Ofira\Ofira_GFX\";
        readonly string outputJsonFile = $@"{WorkingFolder}\(Footage)\CSV\Colors.json";
        readonly string _ProjectLocation = $@"{WorkingFolder}\Ofira_GFX_V4.aep";
        string _CompName = string.Empty;
        string DesktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

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
        static readonly string x1 = "\"" + "Adobe After Effects 2020" + "\"";
        static readonly string x2 = "\"" + "Support Files" + "\"";
        readonly string AErender = $@"D:\WindowsInstallations\Adobe\{x1}\{x2}\aerender.exe";
        #endregion

        #region Color Pick
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

        }

        private void TitleBackgroundPBox_Click(object sender, EventArgs e)
        {

        }

        private void SubjectPBox_Click(object sender, EventArgs e)
        {

        }

        private void SubjectBackgroundPBox_Click(object sender, EventArgs e)
        {

        }
        #endregion
        public Form_Ofira()
        {
            InitializeComponent();

            FormatComboBox.SelectedIndex = 0;

            txt_Title.Text = "Companies עברית destructions";
            txt_Subject.Text = "Why is there so many elctronic stuff?";
            txt_Filename.Text = "Test_File";
            txt_Output.Text = DesktopPath + "\\";

            GoogleCredential credential;
            using (var stream = new FileStream("client_secrets.json", FileMode.Open, FileAccess.Read))
            {
                credential = GoogleCredential.FromStream(stream).CreateScoped(Scopes);
            }

            service = new SheetsService(new Google.Apis.Services.BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName
            }); ;

        }

        private async void btnRun_Click(object sender, EventArgs e)
        {
            var titleText = HebrewStringModify_New(txt_Title.Text);
            var format = FormatComboBox.Text;
            var filename = txt_Filename.Text;
            var outputFolder = txt_Output.Text;
            var hebrew = chk_Hebrew.Checked;

            await RenderFiles(titleText, filename, format, outputFolder);
        }

        private async Task RenderFiles(string _title, string _fileName, string _format, string _outpFolder)
        {
            await Task.Run(() =>
            {
                _CompName = "Flach_Template";

                //UpdateJsonFile();
                UpdateTextFile("ofira", _title, "");

                string outputFolder = @_outpFolder;
                string outFilename = _fileName + "_[#####].png";

                Directory.CreateDirectory(outputFolder + _fileName);
                outputFolder = outputFolder + _fileName + "\\";

                string Command;

                #region need fix because of sourceTimeAtSource
                if (chk_Animation.Checked)
                {
                    Command = $" -project {_ProjectLocation} -comp \"{_CompName}\" -s 1 -e 50 -output {outputFolder}{outFilename}";
                }
                else
                {
                    //outFilename = _fileName + ".png";
                    Command = $" -project {_ProjectLocation} -comp \"{_CompName}\" -s 40 -e 40 -output {outputFolder}{outFilename}";
                }
                #endregion

                Command = $" -project {_ProjectLocation} -comp \"{_CompName}\" -RStemplate \"Best Settings\" -OMtemplate \"{_format}\" -s 1 -e 50 -output {outputFolder}{outFilename}";

                {
                    //ProcessStartInfo ps = new ProcessStartInfo
                    //{
                    //    FileName = "cmd.exe",
                    //    CreateNoWindow = false,
                    //    WindowStyle = ProcessWindowStyle.Normal,
                    //    Arguments = @"/K " + AErender + Command,
                    //    Verb = "runas"
                    //};
                } // Show Window

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
                });

            });
        }

        #region Hebrew Manipulation

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
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

                if (tempWord.Contains("?"))
                {
                    string x = tempWord.Replace("?", "");
                    string y = "?" + x;
                    tempWord = y;
                }
                
                FullText.Add(tempWord);
            }
            FullText.Reverse();
            string combindedString = string.Join(" ", FullText.ToArray());
            //combindedString = Reverse(combindedString);
            return combindedString;
        }

        static string HebrewStringModify(string s)
        {
            List<string> list = new List<string>();
            List<string> mix_string_list = new List<string>();
            var line = s.Split(' ');
            foreach (string word in line)
            {
                if (word.Contains("-"))
                {
                    var MixString = word.Split('-');
                    foreach (string inner_word in MixString)
                    {
                        //MessageBox.Show(inner_word);
                        try
                        {
                            Convert.ToInt32(inner_word);
                            string rString = Reverse(inner_word);
                            mix_string_list.Add(rString);
                        }
                        catch (Exception)
                        {
                            mix_string_list.Add(inner_word);
                        }
                    }
                    string combindedString2 = string.Join("-", mix_string_list.ToArray());
                    list.Add(combindedString2);
                }
                else
                {
                    try
                    {
                        Convert.ToInt32(word);
                        string rString = Reverse(word);
                        list.Add(rString);
                    }
                    catch (Exception)
                    {
                        list.Add(word);
                    }
                }
            }
            string combindedString = string.Join(" ", list.ToArray());
            combindedString = Reverse(combindedString);
            return combindedString;
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
        #endregion
        #region Update text files
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
        private void UpdateTextFile(string filename, string _title, string _subject)
        {
            // Create a string array that consists of three lines.
            string[] lines = { "title", _title, _subject };
            // WriteAllLines creates a file, writes a collection of strings to the file,
            // and then closes the file.  You do NOT need to call Flush() or Close().
            File.WriteAllLines($@"{WorkingFolder}\{filename}.txt", lines);
            //File.WriteAllLines($@"C:\Users\Avid5\Desktop\Auto_GFX\{filename}.txt", lines);
            Thread.Sleep(500);
        }
        #endregion
    }
}
