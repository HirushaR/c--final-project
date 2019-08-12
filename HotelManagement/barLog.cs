using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Manager
{
    class barLog : signIn
    {
        public override void log()
        {
            Login ln = new Login();
            ln.Hide();
            Kitchen kitchen_management = new Kitchen();
            kitchen_management.Show();
        }
    }
}
