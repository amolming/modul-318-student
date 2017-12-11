using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace AskSBB
{
    public partial class AskSBB : Form
    {
        Transport transport = new Transport();
        TextBox activeTxtBox = null;
        string stationID = null;
        string fixDestination = "Ebikon,St.Klemens";

        public AskSBB()
        {
            InitializeComponent();
            timeTxtBox.Text = DateTime.Now.ToShortTimeString();
            dateTimePicker.Text = DateTime.Now.ToLongDateString();
        }

        private void fromTxtBox_TextChanged(object sender, EventArgs e)
        {
            CheckString(fromTxtBox.Text);
            activeTxtBox = fromTxtBox;
            ShowStations(fromTxtBox.Text);
            searchBtn.Enabled = true;
        }

        private void toTxtBox_TextChanged(object sender, EventArgs e)
        {
            CheckString(toTxtBox.Text);
            activeTxtBox = toTxtBox;
            ShowStations(toTxtBox.Text);
            searchBtn.Enabled = true;
        }

        private void chooseLstBox_Click(object sender, EventArgs e)
        {
            activeTxtBox.Text = chooseLstBox.SelectedItem.ToString();
            chooseLstBox.Items.Clear();
            
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            CheckString(timeTxtBox.Text);
            if (connectionsRdoBtn.Checked == true)
            {
                ShowResults(fromTxtBox.Text, toTxtBox.Text, timeTxtBox.Text);
            }
            else if(nearRdoBtn.Checked == true)
            {
                ShowDepartures(fromTxtBox.Text);
            }
        }

        private void ShowStations(string searchQuery)
        {
            Stations stationList = transport.GetStations(searchQuery);

            chooseLstBox.Items.Clear();

            foreach (Station s in stationList.StationList)
            {
                chooseLstBox.Items.Add(s.Name);
            }
        }

        private void ShowResults(string source, string destination, string timeDate)
        {
            Connections connectionList = transport.GetConnections(source, destination, dateTimePicker.Text, timeTxtBox.Text);

            resultsDGV.Rows.Clear();
            resultsDGV.Columns.Clear();

            resultsDGV.AutoSize = true;

            string[] dgv_columns = new string[] { "Von", "Nach", "Abfahrt", "Ankunft", "Gleis", "Dauer" };

            foreach(string col in dgv_columns)
            {
                resultsDGV.Columns.Add(col, col);
            }

            foreach(Connection c in connectionList.ConnectionList)
            {
                int row = resultsDGV.Rows.Add();

                string departure = c.From.Departure;
                string arrival = c.To.Arrival;
                string duration = c.Duration;

                string[] conValues = new string[]
                {
                    c.From.Station.Name,
                    c.To.Station.Name,
                    departure,
                    arrival,
                    c.From.Platform,
                    duration
                };

                for(int i = 0; i < conValues.Count(); i++)
                {
                    resultsDGV.Rows[row].Cells[i].Value = conValues[i];
                }
            }
        }

        private void ShowDepartures(string source)
        {
            Connections connectionList = transport.GetConnections(source, fixDestination, dateTimePicker.Text, timeTxtBox.Text);

            if (fixDestination == "Ebikon,St.Klemens")
            {
                fixDestination = "Luzern,Maihof";
            }

            foreach (Connection con in connectionList.ConnectionList)
            {
                stationID = con.From.Station.Id;
            }

            StationBoardRoot stationBoardList = transport.GetStationBoard(source, stationID);

            resultsDGV.Rows.Clear();
            resultsDGV.Columns.Clear();

            resultsDGV.AutoSize = true;

            string[] dgv_columns = new string[] { "Von", "Nach", "Abfahrt", "Ankunft", "Gleis", "Dauer" };

            foreach (string col in dgv_columns)
            {
                resultsDGV.Columns.Add(col, col);
            }

            foreach(StationBoard stat in stationBoardList.Entries)
            {
                int row = resultsDGV.Rows.Add();

                string[] statValues = new string[]
                {
                    stat.Name,
                    stat.To,
                    stat.Category,
                    stat.Number,
                    stat.Stop.Departure.ToString(),
                    stat.Operator
                };

                for (int i = 0; i < statValues.Count(); i++)
                {
                    resultsDGV.Rows[row].Cells[i].Value = statValues[i];
                }
            }

        }

        private void CheckString(string check)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(check, "^[a-zA-Z]"))
            {
                Errors(1);
            }
            else
            {
                return;
            }
        }

        private void CheckTime(string check)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(check, "^(?:[01][0-9]|2[0-3]):[0-5][0-9]$"))
            {
                Errors(3);
            }
            else
            {
                return;
            }
        }

        private void Errors(int number)
        {
            switch (number)
            {
                case 1: MessageBox.Show("Bitte keine Zahlen oder Sonderzeichen verwenden"); break;
                case 2: MessageBox.Show("Bitte keine Sonderzeichen verwenden"); break;
                case 3: MessageBox.Show("Bitte geben Sie eine gültige Uhrzeit an!"); break;
                default: MessageBox.Show("Diese Fehlermeldung wurde noch nicht programmiert"); break;
            }
        }
    }
}
