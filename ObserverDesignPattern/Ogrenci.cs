using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern
{
    //Subject : Takip edilicek olan nesne
    public class Ogrenci
    {
        public string Adi { get; set; }
        public string OgrenciSoyad { get; set; }
        public string Memleket { get; set; }
        public int    Sinif { get; set; }
        public bool   dersiAstimi { get; set; }

        public bool DersiAstimi
        {
            get { return dersiAstimi; }
            set
            {
                if (value = true)
                {
                    GozlemcilereHaberVer();
                    dersiAstimi = value;
                }
                else
                {
                    dersiAstimi = value;
                }
            }
        }

        List<Observer> Gozlemciler;
        //Gözlemci Ekle

        public Ogrenci()
        {
            this.Gozlemciler = new List<Observer>();
        }
        public void GozlemciEkle(Observer observer)
        {
            Gozlemciler.Add(observer);
        }
        public void GozlemciCikar(Observer observer)
        {
            Gozlemciler.Remove(observer);
        }

        public void GozlemcilereHaberVer()
        {
            Gozlemciler.ForEach(g =>
            {
                g.Update();
            });
        }
    }
}
