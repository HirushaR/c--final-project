using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hotel_Manager
{
   

    class SendIR
    { 
        private string nm,ds;
        private int qu;
       
        public void setItem(string name, string des, int que)
        {
            nm = name;
            ds = des;
            qu = que;
          

        }
        public int retu()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\hiru\works\C#\HotelManagement-master\HotelManagement\frontend_reservation.mdf;Integrated Security=True;Connect Timeout=30");
            string queryString = "insert into IR values('" + nm + "','" + ds + "','" + qu + "')";
            SqlCommand query = new SqlCommand(queryString, connection);

            try
            {
                connection.Open();
                query.ExecuteNonQuery();
                return 1;
            }
            catch(Exception es)
            {
                return 0;   
            }
        }
    }
}
