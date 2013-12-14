using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Finisar.SQLite;

namespace tAsk
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Alert frm  = new Alert();
            //frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddCourse ac = new AddCourse();
            ac.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {





                string myConnection = "datasource=sql3.freemysqlhosting.net;port=3306;username=sql323177;password=mG8%eV8*";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                myDataAdapter.SelectCommand = new MySqlCommand(" select * sql323177.edata ;", myConn);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(myDataAdapter);
                myConn.Open();
                DataSet ds = new DataSet();
                MessageBox.Show("Connected");
                myConn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.ShowDialog();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("k");
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void עזרהToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void הוסףמטלהToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTask _addTask = new AddTask();
            _addTask.ShowDialog();
        }

        private void הוסףקורסToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCourse ac = new AddCourse();
            ac.ShowDialog();
        }

        private void התחברToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login _login = new Login();
            _login.ShowDialog();
        }

        private void הוסףמטלהToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AddTask _addTask = new AddTask();
            _addTask.ShowDialog();
        }

        private void הצגרשימתקורסיםToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowCourses _showCourses = new ShowCourses();
            _showCourses.ShowDialog();
        }

        private void הצגמטלותבקורסToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowTasks _showTasks = new ShowTasks();
            _showTasks.ShowDialog();
        }


    }
}
