using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDisagnePatten
{
    class Creater
    {
        public Oyun FactoryMethod(Oyunlar OyunTipi)
        {
            Oyun oyun = null;
            switch (OyunTipi)
            {
                case Oyunlar.Atari:
                    oyun = new Atari();
                    break;
                case Oyunlar.PC:
                    oyun = new Pc();
                    break;
            }
            return oyun;
        }
    }
}
