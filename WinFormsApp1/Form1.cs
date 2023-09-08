using MySql.Data.MySqlClient;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnMySql_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection();

            conn.ConnectionString = "";
            conn.Open();

            MessageBox.Show("Abri conexao com Mysql")
        }
    }
}