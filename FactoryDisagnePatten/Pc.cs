using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactoryDisagnePatten
{
    public class Pc : Oyun
    {
        public void Platform()
        {
            MessageBox.Show("Bu oyun Pc formatında çalışmaktadır");
        }
    }
}
