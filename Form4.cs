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

namespace AfterEffects
{
    public partial class Form4 : Form
    {
        #region Google Spreadsheets
        static readonly string[] Scopes = { SheetsService.Scope.Spreadsheets };
        static readonly string ApplicationName = "Application Name";
        static readonly string SpreadSheetId = "1a6wnlb70JjpRli9WzUOoSVTndqusqwFHqTb9Qvx5n1M";
        static readonly string Sheet = "ScreeniL DB";
        static SheetsService service;
        #endregion

        public Form4()
        {
            InitializeComponent();
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

        private void button2_Click(object sender, EventArgs e)
        {
            var range = $"{Sheet}!A2:R10";
            var request = service.Spreadsheets.Values.Get(SpreadSheetId, range);

            var response = request.Execute();

            var values = response.Values;

            if (values != null && values.Count > 0)
            {
                foreach (var row in values)
                {
                    string id = row[0].ToString();
                    string Company = row[1].ToString();
                    string Type = row[2].ToString();
                    string Avail = row[3].ToString();
                    string Series = row[4].ToString();
                    string HouseNumber = row[5].ToString();
                    string Batch = row[6].ToString();
                    string Status = row[7].ToString();
                    string VideoFormat = row[8].ToString();
                    string comments1 = row[9].ToString();
                    string comments2 = row[10].ToString();
                    string Name = row[11].ToString();

                    textBox1.Text += id + Environment.NewLine;
                    textBox1.Text += Company + Environment.NewLine;
                    textBox1.Text += Type + Environment.NewLine;
                    textBox1.Text += Avail + Environment.NewLine;
                    textBox1.Text += Name + Environment.NewLine;
                    textBox1.Text += Status + Environment.NewLine;
                    textBox1.Text += HouseNumber + Environment.NewLine;
                    textBox1.Text += comments2 + Environment.NewLine;
                    //AddToQueue(title, subject, format, filename, outputFolder, hebrew, magenta);
                }
            }
            else
            {
                MessageBox.Show("No Data was found");
            }
        }
    }
}
