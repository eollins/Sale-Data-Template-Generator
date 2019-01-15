using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Template_Generator
{
    public partial class MainForm : Form
    {
        string templatePath = "";
        string itemPath = "";
        string savePath = "";
                int t = 0;
        public MainForm()
        {
            InitializeComponent();
        }

        private void selectCard_Click(object sender, EventArgs e)
        {
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                templatePath = openDialog.FileName;
                label1.Text = "Selected";
                t++;

                if (t == 2)
                {
                    Begin.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Selection failed.");
            }
        }

        private void selectItem_Click(object sender, EventArgs e)
        {
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                itemPath = openDialog.FileName;
                label2.Text = "Selected";
                t++;

                if (t == 2)
                {
                    Begin.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Selection failed.");
            }
        }

        private void Begin_Click(object sender, EventArgs e)
        {
            connection.Open();
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                //Save the destination path
                savePath = saveDialog.FileName;

                //Import cards from spreadsheet
                DataTable cards = new DataTable();
                TextFieldParser parser = new TextFieldParser(templatePath);
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");

                cards.Columns.Add(new DataColumn("Combo"));
                cards.Columns.Add(new DataColumn("Card#"));
                cards.Columns.Add(new DataColumn("Brand"));
                cards.Columns.Add(new DataColumn("Year"));
                cards.Columns.Add(new DataColumn("Sport"));
                cards.Columns.Add(new DataColumn("Description"));

                int i = 0;
                int r = 0;
                while(!parser.EndOfData)
                {
                    string[] cols = parser.ReadFields();
                    r = cols.Length;
                    for (int i2 = 0; i2 < 6; i2++)
                    {
                        try
                        {
                            try
                            {
                                cards.Rows[i][i2] = cols[i2];
                            }
                            catch
                            {
                                cards.Rows[i][i2] = "ERROR";
                            }
                        }
                        catch
                        {
                            r = i2;
                        }
                    }

                    i++;
                    Log.Items.Add("Added line " + i);
                    Debug.WriteLine("Added line " + i);
                }

                Log.Items.Clear();
                Log.Items.Add("Imported card table");
                label1.Text = "Imported";

                parser = new TextFieldParser(itemPath);
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");

                //Import master data

                i = 0;
                while (!parser.EndOfData)
                {
                    string[] cols = parser.ReadFields();
                    string title = cols[0];
                    string set = cols[1];
                    string seller = cols[2];
                    string saleDate = cols[3];
                    string price = cols[4];
                    string category = cols[5];
                    string listingType = cols[6];

                    Log.Items.Add("Processing " + title);
                    Debug.WriteLine("Processing " + title);

                    string[] titleWords = title.Split(',');
                    string year = "";
                    foreach (string s in titleWords)
                    {
                        if (IsInt(s) && s.Length == 4) { year = s; break; }
                    }

                    string sport = "";
                    switch (category)
                    {
                        case "213":
                            sport = "Baseball";
                            break;
                        case "214":
                            sport = "Basketball";
                            break;
                        case "215":
                            sport = "Football";
                            break;
                        case "216":
                            sport = "Hockey";
                            break;
                    }

                    //Import list of sets
                    List<string> sets = new List<string>();
                    StreamReader reader = new StreamReader(@"Sets.txt");
                    bool fin = false;
                    while (!fin)
                    {
                        string s = reader.ReadLine();
                        if (s == "") { fin = true; break; }
                        sets.Add(s);
                    }

                    foreach (string s in sets)
                    {
                        if (title.Contains(s)) { set = s; }
                    }

                    string str = year + set + sport;

                    string number = "";
                    foreach (string s in titleWords)
                    {
                        if (s[0] == '#')
                        {
                            if (IsInt(s.Substring(1))) { number = s; break; }
                        }
                    }

                    if (number == "")
                    {
                        Log.Items.Add("Now searching for player names");
                        DataTable cardSelection = GetCardQuery(year, set, sport);


                    }
                }
            }
            else
            {
                MessageBox.Show("Failed");
            }
        }

        public bool IsInt(string t)
        {
            try
            {
                int num = int.Parse(t);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataTable GetCardQuery(string year, string set, string sport)
        {
            SqlCommand command = new SqlCommand("select Card#, Description from [Master Card Table] where Year = '" + year + "' and Brand = '" + set + "' and Sport = '" + sport + "'");
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable t = new DataTable();
            adapter.Fill(t);
            return t;
        }
    }
}
