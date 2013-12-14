using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finisar.SQLite;

namespace tAsk
{
    public partial class ShowTasks : Form
    {
        public ShowTasks()
        {
            InitializeComponent();

            // We use these three SQLite objects:
            SQLiteConnection sqlite_conn;
            SQLiteCommand sqlite_cmd;
            SQLiteDataReader sqlite_datareader;

            // create a new database connection:
            sqlite_conn = new SQLiteConnection("Data Source=database.db;");

            // open the connection:
            sqlite_conn.Open();

            // create a new SQL command:
            sqlite_cmd = sqlite_conn.CreateCommand();
            
            // But how do we read something out of our table ?
            // First lets build a SQL-Query again:
            sqlite_cmd.CommandText = "SELECT * FROM Tasks";

            // Now the SQLiteCommand object can give us a DataReader-Object:
            sqlite_datareader = sqlite_cmd.ExecuteReader();

            ListView.ListViewItemCollection _tasks = new ListView.ListViewItemCollection(coursesListView);
            // ListViewItem.ListViewSubItemCollection _courseNumber = new ListViewItem.ListViewSubItemCollection(_courseName);

            // The SQLiteDataReader allows us to run through the result lines:
            while (sqlite_datareader.Read()) // Read() returns true if there is still a result line to read
            {
                ListViewItem _taskItem = new ListViewItem();
                _taskItem.Text = sqlite_datareader.GetString(1);
                _taskItem.SubItems.Add(sqlite_datareader.GetString(3));
                _taskItem.SubItems.Add(sqlite_datareader.GetString(4));
                _taskItem.SubItems.Add(sqlite_datareader.GetString(5));
                _taskItem.SubItems.Add(sqlite_datareader.GetString(6));
                _tasks.Add(_taskItem);
            }

            //close connection:
            sqlite_conn.Close();   
        }
    }
}
