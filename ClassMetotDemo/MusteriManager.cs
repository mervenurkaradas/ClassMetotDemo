using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri m)
        {
            Console.WriteLine(m.musteriAd + " " + m.musteriSoyad + " " + m.musteriYas + " adına kayıt oluşturulmuştur\n");
        }

        public void Listeleme(Musteri m)
        {

            Console.WriteLine(m.musteriAd + " " + m.musteriSoyad + " " + m.musteriYas);
        }

        public void Silme(Musteri m)
        {
            Console.WriteLine(m.musteriAd + " " + m.musteriSoyad + " " + m.musteriYas + " müşteri siliniyor....");
        }

    }

}
