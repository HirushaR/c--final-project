using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Manager
{
    class managerLog : signIn
    {
        public override void log()
        {
            Login ln = new Login();
            ln.Hide();
            manager mn = new manager();
            mn.Show();
        }
    }
}
