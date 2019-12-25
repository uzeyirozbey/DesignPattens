using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractFactoryDesign
{
    public class MySqlConnection : Connection
    {
        public override string State => "Open";

        public override bool Connect()
        {
            MessageBox.Show("MySqlConnection bağlantısı kuruluyor.");
            return true;
        }

        public override bool Disconnet()
        {
            MessageBox.Show("MySqlConnection bağlantısı kesiliyor.");
            return false;
        }
    }
}
