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
using System.Windows.Forms.VisualStyles;

using Google.Apis.Auth.OAuth2;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Color = System.Drawing.Color;

namespace AfterEffects
{
    public partial class Form2 : Form
    {
        #region Initilize Parameters
        public bool IsHebrew = false;

        Dictionary<string, object> topDict = new Dictionary<string, object>();
        List<RollerInfo> rollerInfos = new List<RollerInfo>();
        List<List<string>> newList = new List<List<string>>();
        List<int> rowsList = new List<int>();

        const string WorkingFolder = @"D:\Projects\Automation\";
        readonly string outputJsonFile = $@"{WorkingFolder}\Colors.json";
        readonly string outputRollerJsonFile = $@"D:\Projects\Zigdon_Roller\Roller.json";
        readonly string _ProjectLocation = $@"{WorkingFolder}\AutoV1.aep";
        string _CompName = "Render_ENG"; // Render_HEB
        int jobId = 1;
        #endregion

        #region Google Spreadsheets
        static readonly string[] Scopes = { SheetsService.Scope.Spreadsheets };
        static readonly string ApplicationName = "Application Name";
        static readonly string SpreadSheetId = "1a6wnlb70JjpRli9WzUOoSVTndqusqwFHqTb9Qvx5n1M";
        static readonly string Sheet = "Roller";
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
        #endregion

        public Form2()
        {
            InitializeComponent();
            FormatComboBox.SelectedIndex = 0;

            txt_Title.Text = "Companies destructions";
            txt_Subject.Text = "Why is there so many elctronic stuff?";
            txt_Filename.Text = "Test_File";

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
        private void Form2_Load(object sender, EventArgs e)
        {
            //AddToQueue();
            ReadEntries_Roller();

            //UpdateRollerJsonFile(rollerInfos);
            var x = topDict.Count;
            topDict.Add("Count", x);
            if (IsHebrew)
                topDict.Add("Language", "1");
            else
                topDict.Add("Language", "0");
            UpdateRollerJsonFile(topDict);
            Close();
        }


        private async void button1_Click(object sender, EventArgs e)
        {
            await AddToQueue();

            //DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            //btn.HeaderText = "Buttons";
            //btn.Name = "TestButton";
            //btn.Text = "Click Me";
            //btn.UseColumnTextForButtonValue = true;

            //dataGridView1.Columns.Add(btn);




            //DataGridViewButtonCell btn2 = new DataGridViewButtonCell();
            ////btn2.UseColumnTextForButtonValue = true;
            //dataGridView1.Rows[0].Cells[8] = (btn2);
        }
        private void button2_Click(object sender, EventArgs e)
        {
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            await RenderAll();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            var titleText = HebrewStringCheck(txt_Title.Text);
            var format = FormatComboBox.Text;
            var filename = txt_Filename.Text;
            var outputFolder = txt_Output.Text;
            var hebrew = chk_Hebrew.Checked;

            RenderFiles(titleText, filename, format, outputFolder);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            int size = -1;
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                    size = text.Length;
                }
                catch (IOException)
                {
                }
                textBox1.Text = openFileDialog1.FileName;
            }
            MessageBox.Show(size.ToString()); // <-- Shows file size in debugging mode.
            MessageBox.Show(result.ToString()); // <-- For debugging use.
        }
        private void button6_Click(object sender, EventArgs e)
        {
            //Dictionary<int, List<string>> topDict = new Dictionary<int, List<string>>();

            //List<string> list = new List<string>();

            //List<string> existing;
            //if (!topDict.TryGetValue(key, out existing))
            //{
            //    existing = new List<string>();
            //    myDic[key] = existing;
            //}
            //// At this point we know that "existing" refers to the relevant list in the 
            //// dictionary, one way or another.
            //existing.Add(extraValue);

            var x = HebrewStringCheck(textBox1.Text);
            textBox1.Text = x;
        }
        void ClearForm()
        {
            txt_Title.Clear();
            txt_Subject.Clear();
            txt_Filename.Clear();
            chk_Hebrew.Checked = false;

            txt_Title.Focus();
        }

        #region Add to Queue
        private async Task AddToQueue()
        {
            if ((txt_Title.Text.Length <= 0) || (txt_Subject.Text.Length <= 0) || (txt_Filename.Text.Length <= 0) || (txt_Output.Text.Length <= 0))
            {
                return;
            }

            ColorObject colorObject1 = new ColorObject
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

            Job job = new Job
            {
                JobID = jobId,
                Filename = txt_Filename.Text,
                OutputFolder = txt_Output.Text,
                TitleText = txt_Title.Text,
                SubjectText = txt_Subject.Text,
                Format = FormatComboBox.Text,
                Hebrew = chk_Hebrew.Checked,
                colorObject = colorObject1
            };
            JobsBindingSource.Add(job);
            jobId += 1;

        }
        private void AddToQueue(string titleText, string subjectText, string format, string filename, string outputFolder, bool hebrew)
        {
            if ((txt_Title.Text.Length <= 0) || (txt_Subject.Text.Length <= 0) || (txt_Filename.Text.Length <= 0) || (txt_Output.Text.Length <= 0))
            {
                return;
            }

            ColorObject colorObject1 = new ColorObject
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

            Job job = new Job
            {
                JobID = jobId,
                Filename = filename,
                OutputFolder = outputFolder,
                TitleText = titleText,
                SubjectText = subjectText,
                Format = format,
                Hebrew = hebrew,
                colorObject = colorObject1
            };
            JobsBindingSource.Add(job);
            jobId += 1;

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
        private void UpdateRollerJsonFile(object obj)
        {
            string x = JsonConvert.SerializeObject(obj, Formatting.Indented);

            File.WriteAllText(outputRollerJsonFile, x);
        }

        private void UpdateTextFile(string filename, string _title, string _subject)
        {
            // Create a string array that consists of three lines.
            string[] lines = { "title", _title, _subject };
            // WriteAllLines creates a file, writes a collection of strings to the file,
            // and then closes the file.  You do NOT need to call Flush() or Close().
            File.WriteAllLines($@"{WorkingFolder}\{filename}.txt", lines);
            //File.WriteAllLines($@"C:\Users\Avid5\Desktop\Auto_GFX\{filename}.txt", lines);
            Thread.Sleep(1500);
        }
        #endregion

        #region Hebrew Manipulation
        static bool HebrewDetection(string value)
        {
            bool found = false;
            #region Adding hebrew letters to Char List
            List<Char> hebrewLettersList = new List<char>();
            string hebrewLetters = "אבגדהוזחטיכלמנסעפצקרשת";
            foreach (var letter in hebrewLetters)
            {
                hebrewLettersList.Add(letter);
            }
            #endregion

            //txtInputString.Text = "abcאdבef";
            var input = value;

            foreach (var item in input)
            {
                for (int i = 0; i < hebrewLettersList.Count; i++)
                {
                    if (item == hebrewLettersList[i])
                    {
                        found = true;
                        break;
                    }
                }
            }

            if (found)
                return true;
            else
                return false;
        }
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        static string HebrewStringCheck(string s)
        {
            //Reverse only the numbers in string
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
            return combindedString;
        }
        #endregion

        #region Datagrid Functions
        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    JobsBindingSource.RemoveCurrent();

                }
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "Run")
            {
                if (MessageBox.Show("Are you sure you want to RUN this?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var id = dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                    var titleText = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    var subjectText = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    var format = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                    var filename = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                    var outputFolder = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                    var hebrew = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[6].Value);

                    lbl_Status.Text = "In Progress...";
                    dataGridView1.Rows[e.RowIndex].Cells[9].Value = "In Progress...";
                    await Task.Run(() =>
                    {

                        RenderFiles(titleText, subjectText, filename, format, outputFolder, hebrew);
                    });

                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.LightGray;
                    dataGridView1.Rows[e.RowIndex].Cells[9].Value = "Finished";
                    JobsBindingSource.RemoveCurrent();
                }
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "TestButton")
            {
                //dataGridView1.Columns[e.ColumnIndex].Visible = false;

                MessageBox.Show("Clicked");
            }
        }

        #endregion

        #region Google Spreadsheet's
        void ReadEntries()
        {
            var range = $"Titles!A2:F80";
            var request = service.Spreadsheets.Values.Get(SpreadSheetId, range);

            var response = request.Execute();

            var values = response.Values;

            if (values != null && values.Count > 0)
            {
                foreach (var row in values)
                {
                    string title = row[0].ToString();
                    string subject = row[1].ToString();
                    string format = row[2].ToString();
                    string filename = row[3].ToString();
                    string outputFolder = row[4].ToString();
                    bool hebrew = Convert.ToBoolean(row[5]);

                    AddToQueue(title, subject, format, filename, outputFolder, hebrew);
                }
            }
            else
            {
                MessageBox.Show("No Data was found");
            }

        }

        void AddToTextBox(string s)
        {
            var result = s + Environment.NewLine;
            textBox2.Text += result;
            //MessageBox.Show(result);

        }

        void ReadEntries_Roller()
        {
            #region Convert values from spreadsheet to newList
            var range = $"{Sheet}!A1:F80";
            var request = service.Spreadsheets.Values.Get(SpreadSheetId, range);
            var response = request.Execute();
            var values = response.Values;

            if (values != null && values.Count > 0)
            {
                foreach (var row in values)
                {
                    List<string> tempList = new List<string>();
                    for (int i = 0; i < row.Count; i++)
                    {
                        string cellValue = row[i].ToString();
                        tempList.Add(cellValue);
                    }
                    newList.Add(tempList);
                }
            }
            #endregion

            // Not Neccessery??
            #region Creating rowList values
            for (int i = 0; i < newList.Count; i++)
            {
                var itemsCount = newList[i].Count;

                if (itemsCount > 0)
                {
                    try
                    {
                        int slideNumber = Convert.ToInt32(newList[i][0]);
                        var rowIndex = newList.IndexOf(newList[i]);
                        rowsList.Add(rowIndex);
                        {
                            //MessageBox.Show(slideNumber.ToString());
                            //string title = newList[i + 1][0];
                            //MessageBox.Show(title);

                            //Get slide information here

                            //Get slide information here
                            //for (int k = 2; k < 6; k++)
                            //{
                            //    string names = newList[i + k][0];

                            //    if (!string.IsNullOrEmpty(names))
                            //    {
                            //        MessageBox.Show
                            //        ("Slide Number: " +
                            //        slideNumber.ToString() +
                            //        Environment.NewLine +
                            //        title +
                            //        ": " +
                            //        names);

                            //    }
                            //}
                        }
                    }
                    catch (Exception)
                    {
                        try
                        {
                            string x = newList[i][0].ToString();
                            if (x == "End")
                            {
                                var rowIndex = newList.IndexOf(newList[i]);
                                rowsList.Add(rowIndex);
                            }
                        }
                        catch (Exception)
                        {

                        }
                    }
                }

                {
                    //if (itemsCount > 1)
                    //{

                    //}
                    //else if (itemsCount > 0) // When there's only one line
                    //{
                    //    try
                    //    {
                    //        int slideNumber = Convert.ToInt32(newList[i][0]);
                    //        string title = newList[i+1][0];

                    //        MessageBox.Show("Slide Number: " + slideNumber.ToString());
                    //        MessageBox.Show(title);
                    //        //Get slide information here

                    //        //Get slide information here


                    //    }
                    //    catch (Exception)
                    //    {
                    //        //MessageBox.Show("Values: " + newList[i][0]);

                    //    }
                    //}
                }
            }
            #endregion

            //Get_Values_From_Slide();
            Get_Values_From_newList();
        }

        void Get_Values_From_newList()
        {
            bool HebrewFound = false;
            foreach (var row in newList)
            {
                var rowCount = row.Count;
                if (rowCount > 0) // Filters out all empty rows
                {
                    var rowIndex = newList.IndexOf(row);
                    var rowType = row.GetType();

                    #region Finds Numeric Values for new Slates
                    if (row.Count == 1)
                    {
                        bool res;
                        int a;
                        string myStr = row[0];
                        res = int.TryParse(myStr, out a);

                        if (res) // Starts only for cells that are numeric
                        {
                            var newSlate = new RollerInfo();
                            newSlate.SlateNumber = a;
                            AddToTextBox($"SlateNumber: {newSlate.SlateNumber}");

                            // Getting Title from row beneath
                            int newRow = rowIndex + 1;
                            int slotCount = newList[newRow].Count;
                            newSlate.Slots = slotCount;
                            List<SlotInfo> globalSlots = new List<SlotInfo>();
                            foreach (var item in newList[newRow])
                            {
                                var slotIndex = newList[newRow].IndexOf(item);

                                var newSlot = new SlotInfo();

                                newSlot.SlotNumber = slotIndex;

                                if (HebrewDetection(item))
                                {
                                    HebrewFound = true;
                                    newSlot.Title = Reverse(item);
                                }
                                else
                                    newSlot.Title = item;

                                AddToTextBox($"SlotNumber: {newSlot.SlotNumber}");
                                AddToTextBox($"SlotTitle: {newSlot.Title}");

                                // Getting Names 
                                // (get all cells until no value or value is numeric)
                                for (int i = 1; i < 6; i++)
                                {
                                    try // In case that we run in an empty cell 
                                        //(ADD CHECK IF NUMERIC)
                                    {

                                        //bool isNum;
                                        //int Num;
                                        //string stringCheck = row[0];
                                        //isNum = int.TryParse(stringCheck, out Num);

                                        //if (isNum)
                                        //{
                                        //    MessageBox.Show($"Found Number: {Num}");
                                        //}
                                        var z = newList[newRow + i][slotIndex];

                                        if (HebrewDetection(z))
                                            z = newSlot.Names += Reverse(z) + ",";
                                        else
                                            newSlot.Names += z + ",";
                                    }
                                    catch (Exception)
                                    {
                                        break;
                                    }
                                }
                                //newSlot.Names = newSlot.Names.Substring(0, newSlot.Names.Length - 1); // canceled for list splits
                                globalSlots.Add(newSlot);

                                AddToTextBox($"SlotNames: {newSlot.Names}");
                            }
                            // End of Slate
                            AddToTextBox("");

                            if (HebrewFound)
                                globalSlots.Reverse();

                            newSlate.slotInfo = globalSlots;

                            topDict.Add($"{newSlate.SlateNumber}", newSlate);
                            rollerInfos.Add(newSlate);
                        }
                    }
                    #endregion
                }
            }
        }

        #endregion

        #region Render Commands
        private async Task RenderAll()
        {
            var rowCount = dataGridView1.Rows.Count;
            if (rowCount > 0)
            {
                for (int i = 0; i < rowCount; i++)
                {
                    await RenderFirstEntry(i);
                }
            }
        }
        private async Task RenderFirstEntry(int _index)
        {
            var status = dataGridView1.Rows[_index].Cells[9].Value;

            if (status != null)
                if (status.ToString() == "Finished") { return; }

            var id = dataGridView1.Rows[_index].Cells[0].Value.ToString();
            var titleText = dataGridView1.Rows[_index].Cells[1].Value.ToString();
            var subjectText = dataGridView1.Rows[_index].Cells[2].Value.ToString();
            var format = dataGridView1.Rows[_index].Cells[3].Value.ToString();
            var filename = dataGridView1.Rows[_index].Cells[4].Value.ToString();
            var outputFolder = dataGridView1.Rows[_index].Cells[5].Value.ToString();
            var hebrew = Convert.ToBoolean(dataGridView1.Rows[_index].Cells[6].Value);

            dataGridView1.Rows[_index].Selected = false;

            dataGridView1.Rows[_index].Cells[9].Value = "In Progress...";
            dataGridView1.Rows[_index].ReadOnly = true;

            await Task.Run(() =>
            {
                RenderFiles(titleText, subjectText, filename, format, outputFolder, hebrew);

            });

            dataGridView1.Rows[_index].DefaultCellStyle.ForeColor = Color.LightGray;
            dataGridView1.Rows[_index].Cells[9].Value = "Finished";

            // Add disable buttons functions here
        }

        private void RenderFiles(string _title, string _subject, string _fileName, string _format, string _outpFolder, bool hebrew)
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
            UpdateTextFile("file", _title, _subject);

            string outputFolder = @_outpFolder;
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

            Command = $" -project {_ProjectLocation} -comp \"{_CompName}\" -RStemplate \"Best Settings\" -OMtemplate \"{_format}\" -s 1 -e 50 -output {outputFolder}{outFilename}";


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

        private void RenderFiles(string _title, string _fileName, string _format, string _outpFolder)
        {
            _CompName = "FlachTemplate";

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
        #endregion

    }
}
