using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern
{
    //Gözlemci-İzleyici-Gözcü -Gözetmen Class
    //Subject’i takip edecek olan gözetmenleri farklı tipte olmasını sağlayan observerdir..
    //Bunlar: öğretmen, anne, baba
    //Concrete kavrami. Subjecti(öğrenciyi) takip eden observer tipleridir
    //Concrete nesneleri: Anne , baba, öğretmen
   
    /// <summary>
    /// İşte Observer Design Pattern yapısınıda Öğrencinin dersi asdığı anda diğer abonelere haber veren Okul’a benzetebiliriz. Yani bir sistemdir diyebiliriz.
    /// </summary>
    public abstract class Observer
    {
       public abstract void Update();
    }
}
