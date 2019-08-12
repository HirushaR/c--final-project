using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hotel_Manager
{
    public partial class manager : MetroFramework.Forms.MetroForm
    {
        public manager()
        {
            InitializeComponent();
            
            ShowReport();


        }

        private void Manager_Load(object sender, EventArgs e)
        {

        }

        private void MetroButton2_Click(object sender, EventArgs e)
        {
            
        }
        private void dataGrid_Refresh()
        {
          
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {

        }
        private void ShowReport()
        {
            
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\hiru\works\C#\HotelManagement-master\HotelManagement\frontend_reservation.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "SELECT * FROM IR";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataSet ds = new DataSet();
            connection.Open();
            adapter.Fill(ds, "IR");
            connection.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "IR";
        }
        private void LoadForDataGridView()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\hiru\works\C#\HotelManagement-master\HotelManagement\frontend_reservation.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "SELECT * FROM IR";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataSet ds = new DataSet();
            connection.Open();
            adapter.Fill(ds, "IR");
            connection.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "IR";

        }

        private void MetroTabPage2_Click(object sender, EventArgs e)
        {

        }

        private void MetroButton6_Click(object sender, EventArgs e)
        {
            LoadForDataGridView();
        }

        private void MetroButton1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
