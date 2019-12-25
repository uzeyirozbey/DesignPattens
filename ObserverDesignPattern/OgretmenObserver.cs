using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObserverDesignPattern
{
    //Concrete nesnesi
    //Subjecti(Öğrenci) takip eden nesnelerdir.
    public class  OgretmenObserver : Observer
    {  
        public override void Update()
        {
            MessageBox.Show("Öğrencinin kaçtığından Öğretmenin  haberi haberi oldu.");
        }
    }
}
