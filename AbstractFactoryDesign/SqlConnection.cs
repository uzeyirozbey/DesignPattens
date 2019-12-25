using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractFactoryDesign
{
    public class SqlConnection : Connection
    {
        public override string State => "Open";
             
        public override bool Connect()
        {
            MessageBox.Show("SqlConnection bağlantısı kuruluyor.");
            return true;
        }

        public override bool Disconnet()
        {
            MessageBox.Show("SqlConnection bağlantısı kesiliyor.");
            return false;
        }
    }
}
