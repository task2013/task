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
    public partial class ShowCourses : Form
    {
        public ShowCourses()
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
            sqlite_cmd.CommandText = "SELECT * FROM Courses";

            // Now the SQLiteCommand object can give us a DataReader-Object:
            sqlite_datareader = sqlite_cmd.ExecuteReader();

            ListView.ListViewItemCollection _courses = new ListView.ListViewItemCollection(coursesListView);
           // ListViewItem.ListViewSubItemCollection _courseNumber = new ListViewItem.ListViewSubItemCollection(_courseName);

            // The SQLiteDataReader allows us to run through the result lines:
            while (sqlite_datareader.Read()) // Read() returns true if there is still a result line to read
            {
                ListViewItem _courseItem = new ListViewItem();
                _courseItem.Text = sqlite_datareader.GetString(1);
                _courseItem.SubItems.Add(sqlite_datareader.GetString(2));
                _courseItem.SubItems.Add(sqlite_datareader.GetString(3));
                _courseItem.SubItems.Add(sqlite_datareader.GetString(4));
                _courseItem.SubItems.Add(sqlite_datareader.GetString(5));
                _courses.Add(_courseItem);
            }
        
            //close connection:
            sqlite_conn.Close();    
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    
    
   
    }
}
