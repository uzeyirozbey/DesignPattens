using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObserverDesignPattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Ogrenci ogr = new Ogrenci();
            ogr.GozlemciEkle(new BabaObserver());
            ogr.GozlemciEkle(new AnneObserver());
            ogr.GozlemciEkle(new OgretmenObserver());
            ogr.Adi = "Salih";
            ogr.OgrenciSoyad = "Can Düşmez";
            ogr.Memleket = "Urfa";
            ogr.Sinif = 1;
            ogr.DersiAstimi = true;
        }
    }
}
