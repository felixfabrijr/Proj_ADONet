using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void label1_Click(object sender, EventArgs e)
        //{

        //}

        private void btnConnMySql_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection();

            conn.ConnectionString = "Server=localhost;Database=Cliente01;Uid=root;Pwd=senha@123;";
            conn.Open();

            MessageBox.Show("Abre conexao MySql");

            conn.Close();
        }

        private void btnConnectionSqlServer_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = "Data Source=localhost;User ID=sa;Password=senha@123;Connect Timeout = 30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            conn.Open();

            MessageBox.Show("Abre conexao SqlServer");

            conn.Close();
        }

        private void btnListarMySql_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection();

            string connection = @"Server=localhost;Database=Cliente01;Uid=root;Pwd=senha@123;";

            conn.ConnectionString = connection;
            conn.Open();

            MySqlCommand conm = new MySqlCommand();


            conm.CommandType = System.Data.CommandType.Text;
            conm.CommandText = "select * from Produtos";
            conm.Connection = conn;

            MySqlDataReader reader = conm.ExecuteReader();

            while (reader.Read())
            {
                string nome = reader.GetString(1);
                string cor = reader.IsDBNull(2) ? string.Empty : reader.GetString(2);

                listBox1.Items.Add($"{reader.GetInt32(0)}, {nome}, {cor}");
            }

            conn.Close();
        }

        private void btnListarSqlServer_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();

            string connection = @"Data Source=localhost;User ID=sa;Password=senha@123;Connect Timeout = 30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;Initial Catalog=Cliente01";

            conn.ConnectionString = connection;
            conn.Open();

            SqlCommand conm = new SqlCommand();


            conm.CommandType = System.Data.CommandType.Text;
            conm.CommandText = "select * from Produtos";
            conm.Connection = conn;

            SqlDataReader reader = conm.ExecuteReader();

            while (reader.Read())
            {
                string nome = reader.GetString(1);
                string cor = reader.IsDBNull(2) ? string.Empty : reader.GetString(2);

                listBox2.Items.Add($"{reader.GetInt32(0)}, {nome}, {cor}");
            }

            conn.Close();
        }

        private void btnListarMySqlDataSet_Click(object sender, EventArgs e)
        {
            string connection = @"Server=localhost;Database=Cliente01;Uid=root;Pwd=senha@123;";
            MySqlDataAdapter da = new MySqlDataAdapter("select * from Produtos", connection);
            DataSet dataSet = new DataSet();
            da.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void btnListarSqlServerDataSet_Click(object sender, EventArgs e)
        {
           
            string connection = @"Data Source=localhost;User ID=sa;Password=senha@123;Connect Timeout = 30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;Initial Catalog=Cliente01";
            SqlDataAdapter da = new SqlDataAdapter("select * from Produtos", connection);
            DataSet dataSet = new DataSet();
            da.Fill(dataSet);
            dataGridView2.DataSource = dataSet.Tables[0];

        }
    }
}