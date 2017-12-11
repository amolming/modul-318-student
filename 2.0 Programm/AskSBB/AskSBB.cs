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
        }

        private void fromTxtBox_TextChanged(object sender, EventArgs e)
        {
            activeTxtBox = fromTxtBox;
            ShowStations(fromTxtBox.Text);
        }

        private void toTxtBox_TextChanged(object sender, EventArgs e)
        {
            activeTxtBox = toTxtBox;
            ShowStations(toTxtBox.Text);
        }

        private void chooseLstBox_Click(object sender, EventArgs e)
        {
            activeTxtBox.Text = chooseLstBox.SelectedItem.ToString();
            chooseLstBox.Items.Clear();
            
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if(connectionsRdoBtn.Checked == true)
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

        private void ShowResults(string source, string destination, string time)
        {
            Connections connectionList = transport.GetConnections(source, destination);

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
            Connections connectionList = transport.GetConnections(source, fixDestination);

            foreach(Connection con in connectionList.ConnectionList)
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

    }
}
