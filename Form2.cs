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
        Dictionary<int, Dictionary<string, List<string>>> topDict = new Dictionary<int, Dictionary<string, List<string>>>();
        Dictionary<string, List<string>> lowDict = new Dictionary<string, List<string>>();
        Dictionary<int, List<string>> tempDict = new Dictionary<int, List<string>>();
        int[] arr = new int[2];
        List<List<string>> newList = new List<List<string>>();
        List<int> rowsList = new List<int>();


        int slide = 1;

        // START
        #region Initilize Parameters
        const string WorkingFolder = @"D:\Projects\Automation\";
        readonly string outputJsonFile = $@"{WorkingFolder}\Colors.json";
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
            ReadEntries_Roller_Test();
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
            Get_Values_From_Slide();
            //ReadEntries();
            //ReadEntries_Roller();
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

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        static string HebrewStringCheck(string s)
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

        void ReadEntries_Roller_Test()
        {
            #region Convert values from spreadsheet to newList
            var range = $"Roller!A1:F80";
            var request = service.Spreadsheets.Values.Get(SpreadSheetId, range);
            var response = request.Execute();
            var values = response.Values;

            if (values != null && values.Count > 0)
            {
                //int rowCheck = 0;
                //int cellNumber = 0;
                foreach (var row in values)
                {
                    //int rowIndex = Convert.ToInt32(values.IndexOf(row)) + 1;
                    List<string> tempList = new List<string>();
                    for (int i = 0; i < row.Count; i++)
                    {
                        string cellValue = row[i].ToString();
                        tempList.Add(cellValue);
                        {
                            //try
                            //{
                            //    cellNumber = Convert.ToInt32(cellValue);
                            //    cellValue = cellNumber;
                            //}
                            //catch (Exception)
                            //{

                            //}

                            //MessageBox.Show(cellValue.GetType().ToString());
                            //MessageBox.Show(cellValue.ToString());
                        }
                        {
                            //try
                            //{
                            //    //var cellValue = row[i];

                            //    //try
                            //    //{
                            //    cellNumber = Convert.ToInt32(cellValue);
                            //    //    rowCheck = 0;
                            //    AddToTextBox("Slide: " + cellNumber.ToString());
                            //    //topDict.Add(cellNumber, null);
                            //    //}
                            //    //catch (Exception)
                            //    //{
                            //    //    rowCheck += 1;
                            //    //    var cellString = cellValue.ToString();
                            //    //    if (rowCheck == 1)
                            //    //    {
                            //    //        lowDict.Add("Title", null);
                            //    //        AddToTextBox("Title: " + cellString.ToString());
                            //    //    }
                            //    //    else
                            //    //    {
                            //    //        lowDict.Add("Name", null);
                            //    //        AddToTextBox("Name: " + cellString.ToString());
                            //    //    }
                            //    //    //topDict[cellNumber] = lowDict;
                            //    //}
                            //}
                            //catch (Exception)
                            //{
                            //    AddToTextBox("Not a Slide Number");
                            //    rowCheck += 1;
                            //    var cellString = cellValue.ToString();

                            //    //list.Add(cellString);

                            //    AddToTextBox("Name: " + cellString.ToString());

                            //    //if (rowCheck == 1)
                            //    //{
                            //    //    list.Add(cellString.ToString());

                            //    //    lowDict.Add("Title", null);
                            //    //    AddToTextBox("Title: " + cellString.ToString());
                            //    //}
                            //    //else
                            //    //{
                            //    //    list.Add(cellString.ToString());
                            //    //    lowDict.Add("Name", null);
                            //    //    AddToTextBox("Name: " + cellString.ToString());
                            //    //}

                            //    //topDict[cellNumber] = lowDict;
                            //}
                        }
                    }
                    newList.Add(tempList);
                }
            }

            #endregion

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

            Get_Values_From_Slide();
            {
                //foreach (var row in newList)
                //{
                //    var itemsCount = row.Count;
                //    var rowIndex = newList.IndexOf(row);

                //    if (itemsCount > 1)
                //    {

                //    }
                //    else if (itemsCount > 0) // When there's only one line
                //    {
                //        try
                //        {
                //            int slideNumber = Convert.ToInt32(row[0]);
                //            MessageBox.Show("Slide Number: " + slideNumber.ToString());
                //        }
                //        catch (Exception)
                //        {
                //            MessageBox.Show("Values: " + row[0]);

                //        }
                //    }

                //}
                //var x = topDict[1];
                //var xKey = topDict[1].Keys;
                //MessageBox.Show(xKey.ToString());
            }
        }
        void Get_Values_From_Slide()
        {
            for (int i = 0; i < rowsList.Count; i++)
            {
                if (i != rowsList.Count - 1)
                {
                    int startRowIndex = rowsList[i];
                    int endRowIndex = rowsList[i + 1];
                    int range = endRowIndex - startRowIndex;

                    for (int k = 0; k < range - 1; k++)
                    {
                        int cellCount = newList[startRowIndex].Count;

                        // Adding Title Dictionary
                        for (int m = 0; m < cellCount; m++)
                        {
                            if (!tempDict.ContainsKey(m))
                            {
                                tempDict.Add(m, new List<string>());
                            }
                        }
                       
                        // Adding Names to Title Dictionary OLD - Cancel later
                        for (int m = 0; m < cellCount; m++)
                        {
                            var z = newList[startRowIndex][m];
                            try
                            {
                                Convert.ToInt32(z); // SLIDE DETECTED
                                AddToTextBox($"[{z}]");
                            }
                            catch
                            {
                                if (!string.IsNullOrEmpty(z))
                                {
                                    tempDict[m].Add(z);
                                    AddToTextBox($"[{m}] {z}");
                                    AddToTextBox("");
                                }
                            }
                        }
                        startRowIndex++;
                    }

                    AddToTextBox("[End of Slide]");
                    AddToTextBox("");
                    tempDict.Clear();
                }
            }
        }
        void ReadEntries_Roller()
        {
            var range = $"Roller!A1:F80";
            var request = service.Spreadsheets.Values.Get(SpreadSheetId, range);
            var response = request.Execute();
            var values = response.Values;

            if (values != null && values.Count > 0)
            {
                int rowCheck = 0;

                foreach (var row in values)
                {
                    int rowIndex = Convert.ToInt32(values.IndexOf(row)) + 1;
                    //MessageBox.Show("Row: " + rowIndex.ToString());

                    for (int i = 0; i < row.Count; i++)
                    {
                        try
                        {
                            var cellValue = row[i];

                            try
                            {
                                var cellNumber = Convert.ToInt32(cellValue);
                                rowCheck = 0;

                                AddToTextBox("Number: " + cellNumber.ToString());
                                //textBox2.Text += "Number: " + cellNumber.ToString();
                                //MessageBox.Show("Number: " + cellNumber.ToString());
                            }
                            catch (Exception)
                            {
                                rowCheck += 1;
                                var cellString = cellValue.ToString();
                                //AddToTextBox(cellString.ToString());
                                if (rowCheck == 1)
                                {
                                    AddToTextBox("Title: " + cellString.ToString());
                                    //MessageBox.Show("Title: " + cellString.ToString());
                                }
                                else
                                {
                                    AddToTextBox("Name: " + cellString.ToString());
                                    //MessageBox.Show("Name: " + cellString.ToString());
                                }
                            }
                        }
                        catch (Exception)
                        {

                            AddToTextBox("Empty Cell");
                            //MessageBox.Show("Empty Cell");
                        }
                    }




                    //string title = row[0].ToString();
                    //string subject = row[1].ToString();
                    //string format = row[2].ToString();
                    //string filename = row[3].ToString();
                    //string outputFolder = row[4].ToString();
                    //bool hebrew = Convert.ToBoolean(row[5]);

                    //AddToQueue(title, subject, format, filename, outputFolder, hebrew);
                }
            }
            else
            {
                MessageBox.Show("No Data was found");
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



    public class DataGridViewDisableButtonColumn : DataGridViewButtonColumn
    {
        public DataGridViewDisableButtonColumn()
        {
            this.CellTemplate = new DataGridViewDisableButtonCell();
        }
    }
    public class DataGridViewDisableButtonCell : DataGridViewButtonCell
    {
        private bool enabledValue;
        public bool Enabled
        {
            get
            {
                return enabledValue;
            }
            set
            {
                enabledValue = value;
            }
        }

        // Override the Clone method so that the Enabled property is copied.
        public override object Clone()
        {
            DataGridViewDisableButtonCell cell =
                (DataGridViewDisableButtonCell)base.Clone();
            cell.Enabled = this.Enabled;
            return cell;
        }

        // By default, enable the button cell.
        public DataGridViewDisableButtonCell()
        {
            this.enabledValue = true;
        }

        protected override void Paint(Graphics graphics,
            Rectangle clipBounds, Rectangle cellBounds, int rowIndex,
            DataGridViewElementStates elementState, object value,
            object formattedValue, string errorText,
            DataGridViewCellStyle cellStyle,
            DataGridViewAdvancedBorderStyle advancedBorderStyle,
            DataGridViewPaintParts paintParts)
        {
            // The button cell is disabled, so paint the border,
            // background, and disabled button for the cell.
            if (!this.enabledValue)
            {
                // Draw the cell background, if specified.
                if ((paintParts & DataGridViewPaintParts.Background) ==
                    DataGridViewPaintParts.Background)
                {
                    SolidBrush cellBackground =
                        new SolidBrush(cellStyle.BackColor);
                    graphics.FillRectangle(cellBackground, cellBounds);
                    cellBackground.Dispose();
                }

                // Draw the cell borders, if specified.
                if ((paintParts & DataGridViewPaintParts.Border) ==
                    DataGridViewPaintParts.Border)
                {
                    PaintBorder(graphics, clipBounds, cellBounds, cellStyle,
                        advancedBorderStyle);
                }

                // Calculate the area in which to draw the button.
                Rectangle buttonArea = cellBounds;
                Rectangle buttonAdjustment =
                    this.BorderWidths(advancedBorderStyle);
                buttonArea.X += buttonAdjustment.X;
                buttonArea.Y += buttonAdjustment.Y;
                buttonArea.Height -= buttonAdjustment.Height;
                buttonArea.Width -= buttonAdjustment.Width;

                // Draw the disabled button.
                ButtonRenderer.DrawButton(graphics, buttonArea,
                    PushButtonState.Disabled);

                // Draw the disabled button text.
                if (this.FormattedValue is String)
                {
                    TextRenderer.DrawText(graphics,
                        (string)this.FormattedValue,
                        this.DataGridView.Font,
                        buttonArea, SystemColors.GrayText);
                }
            }
            else
            {
                // The button cell is enabled, so let the base class
                // handle the painting.
                base.Paint(graphics, clipBounds, cellBounds, rowIndex,
                    elementState, value, formattedValue, errorText,
                    cellStyle, advancedBorderStyle, paintParts);
            }
        }
    }

}
