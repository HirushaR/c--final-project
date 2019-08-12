using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Manager
{
    class adminlog :signIn
    {
        public override void log()
        {
            Login ln = new Login();
            ln.Hide();
            Frontend hotel_management = new Frontend();
            hotel_management.Show();
        }
    }
}
