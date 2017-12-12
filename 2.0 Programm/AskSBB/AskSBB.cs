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

    // Initialisieren des Programms
    public partial class AskSBB : Form
    {
        // Initialisieren von globalen Variablen und Verbindungen
        Transport transport = new Transport();
        TextBox activeTxtBox = null;
        string stationID = null;
        string fixDestination = "Ebikon,St.Klemens";
        string limit = "5";

        public AskSBB()
        {
            InitializeComponent();
            timeTxtBox.Text = DateTime.Now.ToShortTimeString();
            dateTimePicker.Text = DateTime.Now.ToLongDateString();
        }


    // Aktionen von Usern
        private void fromTxtBox_TextChanged(object sender, EventArgs e)
        {
            chooseLstBox.Visible = true;
            activeTxtBox = fromTxtBox;
            ShowStations(fromTxtBox.Text);
        }

        private void toTxtBox_TextChanged(object sender, EventArgs e)
        {
            chooseLstBox.Visible = true;
            activeTxtBox = toTxtBox;
            ShowStations(toTxtBox.Text);
        }

        private void chooseLstBox_Click(object sender, EventArgs e)
        {
            activeTxtBox.Text = chooseLstBox.SelectedItem.ToString();
            chooseLstBox.Items.Clear();
            chooseLstBox.Visible = false;
        }

        private void connectionsRdoBtn_CheckedChanged(object sender, EventArgs e)
        {
            fromLbl.Text = "Von";
            toLbl.Visible = true;
            toTxtBox.Visible = true;
        }

        private void tableRdoBtn_CheckedChanged(object sender, EventArgs e)
        {
            fromLbl.Text = "Ortschaft";
            toLbl.Visible = false;
            toTxtBox.Visible = false;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (connectionsRdoBtn.Checked == true)
            {
                CheckString(fromTxtBox.Text);
                CheckString(toTxtBox.Text);
                CheckTime(timeTxtBox.Text);
                ShowResults(fromTxtBox.Text, toTxtBox.Text, timeTxtBox.Text);
            }
            else if (tableRdoBtn.Checked == true)
            {
                ShowDepartures(fromTxtBox.Text);
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            toTxtBox.Clear();
            fromTxtBox.Clear();
            timeTxtBox.Text = DateTime.Now.ToShortTimeString();
            dateTimePicker.Text = DateTime.Now.ToLongDateString();
            connectionsRdoBtn.Checked = true;
        }

        // Funktion ShowStations - Sucht Stationen
    private void ShowStations(string searchQuery)
        {
            Stations stationList = transport.GetStations(searchQuery);

            chooseLstBox.Items.Clear();

            foreach (Station s in stationList.StationList)
            {
                chooseLstBox.Items.Add(s.Name);
            }
        }

        // Funktion ShowResults - Liefert die Ergebnisse ins Grid für Verbindungen
        private void ShowResults(string source, string destination, string timeDate)
        {
            Connections connectionList = transport.GetConnections(source, destination, dateTimePicker.Text, timeTxtBox.Text, limit);

            resultsDGV.Rows.Clear();
            resultsDGV.Columns.Clear();

            resultsDGV.AutoSize = true;

            string[] dgv_columns = new string[] { "Von", "Nach", "Abfahrt", "Ankunft", "Gleis", "Dauer" };

            foreach (string col in dgv_columns)
            {
                resultsDGV.Columns.Add(col, col);
            }

            foreach (Connection c in connectionList.ConnectionList)
            {
                int row = resultsDGV.Rows.Add();

                string[] conValues = new string[]
                {
                    c.From.Station.Name,
                    c.To.Station.Name,
                    DateTime.Parse(c.From.Departure).ToString("HH:mm"),
                    DateTime.Parse(c.To.Arrival).ToString("HH:mm"),
                    c.From.Platform,
                    c.Duration.Substring(3,5),
                };

                for (int i = 0; i < conValues.Count(); i++)
                {
                    resultsDGV.Rows[row].Cells[i].Value = conValues[i];
                }
            }
        }

        // Funktion ShowDepartures - Liefert Resultate ins Grid für den Stationsfahrplan
        private void ShowDepartures(string source)
        {
            Connections connectionList = transport.GetConnections(source, fixDestination, dateTimePicker.Text, timeTxtBox.Text, limit);

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

            string[] dgv_columns = new string[] { "Abfahrt", "Gleis", "Nach", "Zugtyp", "Transportverbund" };

            foreach (string col in dgv_columns)
            {
                resultsDGV.Columns.Add(col, col);
            }

            foreach (StationBoard stat in stationBoardList.Entries)
            {
                int row = resultsDGV.Rows.Add();

                string[] statValues = new string[]
                {
                    stat.Stop.Departure.ToShortTimeString(),
                    stat.Number,
                    stat.To,
                    stat.Category,
                    stat.Operator
                };

                for (int i = 0; i < statValues.Count(); i++)
                {
                    resultsDGV.Rows[row].Cells[i].Value = statValues[i];
                }
            }

        }

        // Checkboxen Checks und Errormeldungen
        private void CheckString(string check)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(check, "^[a-zA-Z,]"))
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
