using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace adatbazis_gyakorlas
{
    public partial class Form1 : Form
    {
        private string HostName = "localhost";
        private string PortName = "3307";
        private string UserName = "root";
        private string Password = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }        

        private void Form1_Load(object sender, EventArgs e)
        {

            btnUpdate.Enabled = false;
            textHostName.Text = HostName;
            textPortName.Text = PortName;
            textUserName.Text = UserName;
            textPassword.Text = Password;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayData();
            string Cn =string.Empty;       
        }

        private void DisplayData()
        {
          /*  string ConnectionString = $"datasource={HostName};port={PortName};username={UserName};password={Password}"; ;
            MySqlConnection MyConn2 = new MySqlConnection(ConnectionString);
            string sqlQuery = "select * from Parks_and_Recreation.employee_demographics;";
            MySqlCommand MyCommand2 = new MySqlCommand(sqlQuery, MyConn2);
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = MyCommand2;
            DataTable dTable = new DataTable();
            MyAdapter.Fill(dTable);
            dataGridView1.DataSource = dTable;
            */

            MySqlConnectionStringBuilder mysqlConnectionStringBuilder = new MySqlConnectionStringBuilder()
            {
                Server = HostName,
                Port = (uint)System.Convert.ToInt32(PortName),
                UserID = UserName,
                Database = "TAmon",
                SslMode = MySqlSslMode.Preferred,
            };


            string ConnectionString = $"datasource={HostName};port={PortName};username={UserName};password={Password}"; ;
            MySqlConnection MyConn2 = new MySqlConnection(ConnectionString);
            string sqlQuery = "select * from Parks_and_Recreation.employee_demographics;";
            try
            {
                MySqlCommand MyCommand2 = new MySqlCommand(sqlQuery, MyConn2);
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hiba az adatbázis kapcsolodáskor: {ex.Message}");
            }
        }

        private void textHostName_TextChanged(object sender, EventArgs e)
        {
            UpdateButton();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ConnectionString = $"datasource={HostName};port={PortName};username={UserName};password={Password}"; ;
            MySqlConnection MyConn2 = new MySqlConnection(ConnectionString);
            string sqlQuery = "select * from Parks_and_Recreation.employee_demographics;";
            MySqlCommand MyCommand2 = new MySqlCommand(sqlQuery, MyConn2);
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = MyCommand2;
            DataTable dTable = new DataTable();
            MyAdapter.Fill(dTable);
            dataGridView1.DataSource = dTable;


        }

        private void textPortName_TextChanged(object sender, EventArgs e)
        {
            UpdateButton();
        }

        private void textUserName_TextChanged(object sender, EventArgs e)
        {
            UpdateButton();
        }

        void UpdateButton()
        {
            if (!string.IsNullOrWhiteSpace(textHostName.Text) &&
        //!string.IsNullOrWhiteSpace(textPassword.Text) &&
        !string.IsNullOrWhiteSpace(textUserName.Text) &&
        !string.IsNullOrWhiteSpace(textPortName.Text)
        )
            {
                btnUpdate.Enabled = true;
            }
            else
            {
                { btnUpdate.Enabled = false; }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string ConnectionString = $"datasource={HostName};port={PortName};username={UserName};password={Password}"; ;
            MySqlConnection MyConn2 = new MySqlConnection(ConnectionString);
            string Query = $"insert into {textAdatbazis_nev.Text}.employee_demographics(fist_name,last_name,age,gender," + $"birth_date)" +
                $"values('" + this.textFirst_name.Text + "','" + this.textLast_name.Text + "','" + this.textAge.Text + "','" + this.textGender.Text +
                "','" + this.textBirth_month.Text + "');";
            string sqlQuery = "select * from Parks_and_Recreation.employee_demographics;";
            MySqlCommand MyCommand2 = new MySqlCommand(sqlQuery, MyConn2);
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = MyCommand2;
            DataTable dTable = new DataTable();
            MyAdapter.Fill(dTable); 
            dataGridView1.DataSource = dTable;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string Conn = "server=localhost;password=1234;user id=root;database=test"​;

            SqlConnection con = new SqlConnection(Conn);​

            try​

            {​

            SqlCommand com = new SqlCommand("new_employee", con);​

            com.CommandType = CommandType.StoredProcedure;​

            com.Parameters.AddWithValue("@first", „Jane”);​

            com.Parameters.AddWithValue("@last", „Last”);​

            com.Parameters.AddWithValue("@birthday", bDate);​

            con.Open();​

            com.ExecuteNonQuery();​

            }​
        }
    }
}
