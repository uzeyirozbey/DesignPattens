using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactoryDisagnePatten
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Creater oyunOlustur = new Creater();
            Oyun atariOyunu = oyunOlustur.FactoryMethod(Oyunlar.Atari);
            Oyun Pc = oyunOlustur.FactoryMethod(Oyunlar.PC);
            atariOyunu.Platform();
            Pc.Platform();
        }
    }
}
