using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactoryDisagnePatten
{
    public class Atari : Oyun
    {
        public void Platform()
        {
            MessageBox.Show("Bu oyun atari platformunda çalışmaktadır.");;
        }
    }
}
