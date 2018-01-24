using DAL.Context;
using DAL.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
 
using System.Windows.Forms;

namespace BaseballClientGames
{
    public partial class Form1 : Form
    {
        private BaseballContext context;
        private bool isAllQueriesSelected;
        public Form1()
        {
            InitializeComponent();
            button2.Enabled = false;
            button3.Enabled = false;
            radioButton1.Select();
            isAllQueriesSelected = true;

        }

        private void CreateContext()
        {
            this.context = new BaseballContext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var seasonTagID = this.seasonTagID.Text.ToString();
            var csvregex = new Regex(@"[!@#$%^&*()_><.\/\\|;:]");
            var teamIdsCSV = new[] {""};
            if (radDropDownList1.Text == "")
            {
                MessageBox.Show("You must choose a database!");
            }
            else if (this.seasonTagID.Text == "")
            {
                MessageBox.Show("Please provide a SeasonTagID!");
            }

            else if (this.teamIDs.Text == "")
            {
                MessageBox.Show("Please provide a TeamIDs list.!");
            }
            else if (csvregex.IsMatch(this.teamIDs.Text))
            {
                MessageBox.Show("Your CSV list of TeamIDs is not in the correct format.\n Please use only \",\" as a divider!");
            }
            else
            {
                var checkedButton = groupBox1.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);
                if (checkedButton.Name == "radioButton2")
                {
                    isAllQueriesSelected = false;
                }
                var connectionString = radDropDownList1.Text;
                var tagID = this.seasonTagID.Text;
                var teamIDsCSV = this.teamIDs.Text.Split(',');
                this.CreateContext();
                this.getTeamsData(connectionString, tagID, teamIDsCSV);
            }
        }

        public void getTeamsData(string connectionString, string tagID, string[] teamIDsCSV)
        {
            var cn = this.context.GetConnection(connectionString);
            var tempStringIDs = "";
            
            foreach (var item in teamIDsCSV)
            {
                tempStringIDs += item.ToString() + ", ";
            }
            var stringIDs = tempStringIDs.Remove(tempStringIDs.Length - 2, 2);
            if (cn.State != ConnectionState.Closed)
            {
                using (cn)
                {
                    MySqlCommand cmd = cn.CreateCommand();
                    cmd.CommandText = "SELECT iGameID, iTeamIDA, iTeamIDB, strGameName, dtGameDate FROM synergydb.tblGames g " +
                                            "JOIN synergydb.tblteams a on a.iTeamID = g.iTeamIDB " +
                                            "JOIN synergydb.tblteams h on h.iTeamID = g.iTeamIDA " +
                                        "WHERE g.iSeasonTagID = " + tagID + " " +
                                            "AND (a.iTeamID IN (" + stringIDs + ") OR h.iTeamID IN (" + stringIDs + ")) " +
                                            "AND g.iLeagueID = 90 " +
                                            "ORDER BY g.dtGameDate";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    var teamsList = new List<GameIDs>();
                    var ScoutTeamsList = new List<GameIDs>();
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        teamsList.Add(new GameIDs
                        {
                            iGameID = Convert.ToString(row["iGameID"]),
                            iTeamIDA = Convert.ToString(row["iTeamIDA"]),
                            iTeamIDB = Convert.ToString(row["iTeamIDB"]),
                            strGameName = Convert.ToString(row["strGameName"]),
                            dtGameDate = Convert.ToString(row["dtGameDate"]),
                        });
                    }
                    if (teamsList.Count != 0)
                    {

                        List<ClientNonClientGames> NonClientGamesList = getClientNonClientGames(tagID, connectionString, dateTimeFrom.Value, dateTimeTo.Value, stringIDs);
                        List<NonClientData> nonClientList = new List<NonClientData>();
                        foreach (var item in NonClientGamesList)
                        {
                            var nonClientDate = item.GameDate.Split('/');
                            var tempDate = nonClientDate[2].Substring(0, 4) + "-" + nonClientDate[0] + "-" + nonClientDate[1];
                            nonClientList.Add(new NonClientData()
                            {
                                dtGameDate = tempDate,
                                iGameID = item.NonClientID.ToString()
                            });
                        }
                        StringBuilder builder = new StringBuilder();
                        foreach (var item in nonClientList)
                        {
                            if (isAllQueriesSelected)
                            {
                                builder.Append("SELECT g.iGameID, g.iTeamIDA, g.iTeamIDB, g.strGameName, g.dtGameDate FROM synergydb.tblGames g " +
                                                "WHERE g.iSeasonTagID = " + tagID + " " +
                                                "AND g.iLeagueID = 90 " +
                                                "AND(g.iTeamIDA IN (" + item.iGameID + ") OR g.iTeamIDB IN (" + item.iGameID + ")) " +
                                                "AND g.dtGameDate < '" + item.dtGameDate + "' " +
                                                "GROUP BY g.iGameID " +
                                                "ORDER BY g.dtGameDate; ");
                            }
                            else
                            {
                                builder.Append("SELECT  g.iGameID, g.iTeamIDA, g.iTeamIDB, g.strGameName, g.dtGameDate FROM synergydb.tblGames g " +
                                                "WHERE g.iSeasonTagID = " + tagID + " " +
                                                "AND g.iLeagueID = 90 " +
                                                "AND(g.iTeamIDA IN (" + item.iGameID + ") OR g.iTeamIDB IN (" + item.iGameID + ")) " +
                                                "AND g.dtGameDate < '" + item.dtGameDate + "' " +
                                                "ORDER BY g.dtGameDate DESC " +
                                                "LIMIT 10; ");
                            }
                        }

                        MySqlCommand scoutCommand = cn.CreateCommand();
                        scoutCommand.CommandTimeout = 99999;
                        scoutCommand.CommandText = builder.ToString(); ;
                        MySqlDataAdapter scoutAdapter = new MySqlDataAdapter(scoutCommand);
                        DataSet scoutDs = new DataSet();
                        scoutAdapter.Fill(scoutDs);

                        for (int i = 0; i < scoutDs.Tables.Count; i++)
                        {
                            if (scoutDs.Tables[i].Rows.Count != 0)
                            {
                                foreach (DataRow row in scoutDs.Tables[i].Rows)
                                {
                                    ScoutTeamsList.Add(new GameIDs
                                    {
                                        iGameID = Convert.ToString(row["iGameID"]),
                                        iTeamIDA = Convert.ToString(row["iTeamIDA"]),
                                        iTeamIDB = Convert.ToString(row["iTeamIDB"]),
                                        strGameName = Convert.ToString(row["strGameName"]),
                                        dtGameDate = Convert.ToString(row["dtGameDate"]),
                                    });
                                }
                            }
                        }

                        var scoutListResult = from scout in ScoutTeamsList
                                              group scout by scout.iGameID
                                              into scouts
                                              select scouts.OrderByDescending(x => x.dtGameDate).Take(10).ToList();
                        ScoutTeamsList = new List<GameIDs>();
                        foreach (var item in scoutListResult)
                        {
                            if(item.Count > 1)
                            {
                                var temp = item[0];
                                ScoutTeamsList.Add(new GameIDs()
                                {
                                    iGameID = temp.iGameID,
                                    iTeamIDA = temp.iTeamIDA,
                                    iTeamIDB = temp.iTeamIDB,
                                    strGameName = temp.strGameName,
                                    dtGameDate = temp.dtGameDate
                                });
                            }
                            else
                            {
                                ScoutTeamsList.Add(new GameIDs()
                                {
                                    iGameID = item[0].iGameID,
                                    iTeamIDA = item[0].iTeamIDA,
                                    iTeamIDB = item[0].iTeamIDB,
                                    strGameName = item[0].strGameName,
                                    dtGameDate = item[0].dtGameDate
                                });
                            }
                        }

                        BindingSource bindingSource1 = new BindingSource();
                        dataGridView1.AutoGenerateColumns = false;
                        dataGridView1.AutoSize = false;
                        dataGridView1.DataSource = teamsList;

                        BindingSource bindingSource2 = new BindingSource();
                        dataGridView2.AutoGenerateColumns = false;
                        dataGridView2.AutoSize = false;
                        dataGridView2.DataSource = ScoutTeamsList;
                        clientGamesLabel.Text = "Client Games: " + teamsList.Count;
                        scoutGamesLabel.Text = "Scout Games: " + ScoutTeamsList.Count;
                        button2.Enabled = true;
                        button3.Enabled = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please check VPN connection!");
            }
            
        }

        private List<ClientNonClientGames> getClientNonClientGames(string tagID, string connectionString, DateTime dateTimeFrom, DateTime dateTimeTo, string stringIDs)
        {
            var cn = this.context.GetConnection(connectionString);

            var result = new List<ClientNonClientGames>();

            using (cn)
            {
                MySqlCommand cmd = cn.CreateCommand();
                if (isAllQueriesSelected)
                {
                    cmd.CommandText = "SELECT " +
                                    "IF(a.iTeamID in (" + stringIDs + "), h.iTeamID, a.iTeamID) as NonClientID, " +
                                    "IF(a.iTeamID in (" + stringIDs + "), h.strTeamName, a.strTeamName) as NonClientName, " +
                                    "IF(h.iTeamID in (" + stringIDs + "), h.strTeamName, a.strTeamName) as ClientName, " +
                                    "DATE(g.dtGameDate - INTERVAL 4 HOUR) as GameDate " +
                                    "FROM synergydb.tblGames g " +
                                    "JOIN synergydb.tblteams a on a.iTeamID = g.iTeamIDB " +
                                    "JOIN synergydb.tblteams h on h.iTeamID = g.iTeamIDA " +

                                    "WHERE g.iSeasonTagID = " + tagID + " " +
                                    "AND g.iLeagueID = 90 " +
                                    "AND(a.iTeamID in (" + stringIDs + ") OR h.iTeamID in (" + stringIDs + ")) " +
                                    "AND NOT (a.iTeamID in (" + stringIDs + ") AND h.iTeamID in (" + stringIDs + ")) " +
                                    "AND DATE(g.dtGameDate - INTERVAL 5 HOUR) >= '" + dateTimeFrom.Year + "-" + dateTimeFrom.Month + "-" + dateTimeFrom.Day + "' " +
                                    "AND DATE(g.dtGameDate - INTERVAL 5 HOUR) <= '" + dateTimeTo.Year + "-" + dateTimeTo.Month + "-" + dateTimeTo.Day + "' " +
                                    "GROUP BY NonClientID HAVING MAX(GameDate) " +
                                    "ORDER BY GameDate; ";
                }
                else
                {
                    cmd.CommandText = "SELECT " +
                                        "IF(h.bCustomer = 0, h.iTeamID, a.iTeamID) as NonClientID, " +
                                        "IF(h.bCustomer = 0, h.strTeamName, a.strTeamName) as NonClientName, " +
                                        "IF(h.bCustomer IN (" + stringIDs + "), h.strTeamName, a.strTeamName) as ClientName, " +
                                        "DATE(g.dtGameDate - INTERVAL 4 HOUR) as GameDate " +
                                        "FROM synergydb.tblGames g " +
                                        "JOIN synergydb.tblteams a on a.iTeamID = g.iTeamIDB " +
                                        "JOIN synergydb.tblteams h on h.iTeamID = g.iTeamIDA " +

                                        "WHERE g.iSeasonTagID = " + tagID + " " +
                                        "AND g.iLeagueID = 90 " +
                                        "AND(a.iTeamID in (" + stringIDs + ") OR h.iTeamID in (" + stringIDs + ")) " +
                                        "AND NOT (a.iTeamID in (" + stringIDs + ") AND h.iTeamID in (" + stringIDs + ")) " +
                                        "AND DATE(g.dtGameDate - INTERVAL 5 HOUR) >= '" + dateTimeFrom.Year + "-" + dateTimeFrom.Month + "-" + dateTimeFrom.Day + "' " +
                                        "AND DATE(g.dtGameDate - INTERVAL 5 HOUR) <= '" + dateTimeTo.Year + "-" + dateTimeTo.Month + "-" + dateTimeTo.Day + "' " +
                                        //"GROUP BY NonClientID HAVING MAX(GameDate) " +
                                        "ORDER BY GameDate; ";
                }

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    result.Add(new ClientNonClientGames
                    {
                        NonClientID = Convert.ToString(row["NonClientID"]),
                        NonClientName = Convert.ToString(row["NonClientName"]),
                        ClientName = Convert.ToString(row["ClientName"]),
                        GameDate = Convert.ToString(row["GameDate"]),
                    });
                }
            }

                return result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            exportToExcel("Client Games", dataGridView1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            exportToExcel("Scout Games", dataGridView2);
        }
        private void exportToExcel(string fileName, DataGridView dGV)
        {
            
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            System.IO.Directory.CreateDirectory(desktop + "\\Excel Results\\");
            var file = desktop + "\\Excel Results\\" + fileName + ".xls";
            if (File.Exists(file))
            {
                DirectoryInfo hdDirectoryInWhichToSearch = new DirectoryInfo(desktop + "\\Excel Results\\");
                FileInfo[] filesInDir = hdDirectoryInWhichToSearch.GetFiles("*" + fileName + "*.*");

                if(filesInDir.Length > 0)
                {
                    fileName = fileName + "" + filesInDir.Length;
                }
            }
            sfd.FileName = desktop + "\\Excel Results\\" + fileName + ".xls";
            var data = dGV;
            string stOutput = "";
            // Export titles:
            string sHeaders = "";

            for (int j = 0; j < data.Columns.Count; j++)
                sHeaders = sHeaders.ToString() + Convert.ToString(data.Columns[j].HeaderText) + "\t";
            stOutput += sHeaders + "\r\n";
            // Export data.
            for (int i = 0; i < data.RowCount - 1; i++)
            {
                string stLine = "";
                for (int j = 0; j < data.Rows[i].Cells.Count; j++)
                    stLine = stLine.ToString() + Convert.ToString(data.Rows[i].Cells[j].Value) + "\t";
                stOutput += stLine + "\r\n";
            }
            Encoding utf16 = Encoding.GetEncoding(1254);
            byte[] output = utf16.GetBytes(stOutput);
            FileStream fs = new FileStream(sfd.FileName, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(output, 0, output.Length); //write the encoded file
            bw.Flush();
            bw.Close();
            fs.Close();
            MessageBox.Show("Done!");
        }
    }
}
