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
    public partial class bar : MetroFramework.Forms.MetroForm
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\hiru\works\C#\HotelManagement-master\HotelManagement\frontend_reservation.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand query;
        SqlDataReader reader;

        public bar()
        {
            InitializeComponent();
        }

        private void Bar_Load(object sender, EventArgs e)
        {
            LoadForDataGridView();
            listBoxFromDataBase();
        }
        public void LoadForDataGridView()
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Close();

                string queryString = "Select item_no,item_name,item_description,item_price from menuitems where item_category='bar'";
                query = new SqlCommand(queryString, connection);
                try
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = dataTable;
                    overviewDataGridView.DataSource = bindingSource;
                    dataAdapter.Update(dataTable);
                    connection.Close();
                }
                catch (Exception)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Error loading data", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.None);
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "SQL Connection is already open", "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
        }
        private void resetEntries(Control controls)
        {
            foreach (Control control in controls.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                if (control.HasChildren)
                {
                    resetEntries(control);
                }
            }

        }


        private void QueueListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Close();
                resetEntries(this);
                string getQuerystring = queueListBox.Text.Substring(0, 4).Replace(" ", string.Empty);
                //MessageBox.Show("ID+" + getQuerystring);
                string queryString = "Select * from menuitems where item_no= '" + getQuerystring + "'";

                query = new SqlCommand(queryString, connection);
                try
                {
                    connection.Open();
                    reader = query.ExecuteReader();
                    while (reader.Read())
                    {
                        string ID = reader["item_no"].ToString();
                        string name = reader["item_name"].ToString();
                        string desc = reader["item_description"].ToString();
                        string price = reader["item_price"].ToString();

                        firstNameTextBox.Text = ID;
                        metroTextBox5.Text = name;
                        firstNameTextBox.Text = name;
                        metroTextBox2.Text = price;
                        metroTextBox1.Text = desc;

                       
                    }
                   

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("COMBOBOX Selection: + " + ex.Message);
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "SQL Connection is already open.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
        }
        private void listBoxFromDataBase()
        {

            queueListBox.Items.Clear();
            if (connection.State != ConnectionState.Open)
            {
                connection.Close();

               string queryString = "Select * from menuitems where item_category='bar'";

                query = new SqlCommand(queryString, connection);
                try
                {
                    connection.Open();
                    reader = query.ExecuteReader();
                    while (reader.Read())
                    {
                        string ID = reader["item_no"].ToString();
                        string name = reader["Item_name"].ToString();
                        string desc = reader["Item_description"].ToString();
                        string price = reader["item_price"].ToString();
                        queueListBox.Items.Add(ID + "  | " +name + "  " + desc + " | " + price);

                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "SQL Connection is already open", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string name = metroTextBox5.Text;
            string desc = metroTextBox1.Text;

            //int price;
            int quan;

            double price = double.Parse(metroTextBox2.Text);
            quan = int.Parse(metroTextBox3.Text);
            double amnt = price * quan;
            metroTextBox4.Text = amnt.ToString();


            dataGridView1.Rows.Add(firstNameTextBox.Text, metroTextBox5.Text, metroTextBox1.Text, metroTextBox3.Text, metroTextBox2.Text, amnt);
            
            if (connection.State != ConnectionState.Open)
            {
                string qry = "insert into item values('"+name+"','"+desc+"','"+price+"','"+quan+"')";
                SqlCommand cmd = new SqlCommand(qry, connection);

                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();


                }
                catch (SqlException se)
                {
                    MessageBox.Show("" + se);
                }
            }

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MetroTabPage2_Click(object sender, EventArgs e)
        {

        }

        private void MetroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {

            float total = 0;

            /*for(int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                total += int.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());
                label6.Text = total.ToString();
            }
             */
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                total += (float)Convert.ToDouble(row.Cells[5].Value);

            }
            metroTextBox6.Text = total.ToString();
        }

        private void MetroTextBox3_Click(object sender, EventArgs e)
        {
          
        }

        private void MetroTabPage3_Click(object sender, EventArgs e)
        {

        }

        private void MetroButton2_Click(object sender, EventArgs e)
        {
            string name= metroTextBox7.Text;
            string des= metroTextBox8.Text;
            int quan;
            quan = int.Parse(metroTextBox9.Text);

            if (connection.State != ConnectionState.Open)
            {
                string qry = "INSERT INTO IR VALUES('" + name + "','" + des + "','" + quan + "')";
                SqlCommand cmd = new SqlCommand(qry, connection);

                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Inserted");

                }
                catch (SqlException se)
                {
                    MessageBox.Show("Error Inserting" + se);
                }
            }

           
        }

        private void MetroButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void MetroTextBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
