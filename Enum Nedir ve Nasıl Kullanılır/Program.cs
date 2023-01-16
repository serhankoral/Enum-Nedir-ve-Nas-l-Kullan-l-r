using System;

namespace Enum_Nedir_ve_Nasıl_Kullanılır
{
    internal class Program
    {
       // enum Renkler { Kirmizi, Yesil, Mavi };
        //enum Departmanlar { Yazilim, Bilgi_Işlem, Muhasebe };
        //enum Gunler { Pazartesi, Sali, Carsamba, Persembe, Cuma, Cumartesi, Pazar };
        static void Main(string[] args)
        {
            /*
             * Enum dizile gibi kullanılır program kodlarının sadeleştirmesini sağlıyor
             * Veri banında index değerleri ile işlemler yapıldığında daha kullanılabilir
             * Enum sabit değerleri alır sonradan değiştirilemez
             * enum tanımlamaları calss dışında yapılır  
             */
            Console.WriteLine("Haftanın 1.Günü {0}",Sabitler.tarihBilgileri.gunler.Pazartesi);
            Console.WriteLine(Sabitler.tarihBilgileri.aylar.Şubat);
            Console.WriteLine( "{0} Ayı yılım {1}. ayıdır.", Sabitler.tarihBilgileri.aylar.Şubat,((int)Sabitler.tarihBilgileri.aylar.Şubat));
            Console.WriteLine("Enumun type ile kullanımı {0}",Enum.Parse(typeof(Sabitler.tarihBilgileri.aylar),"5"));
            Console.WriteLine("Enumun içerisinde int olan değere karşılık gelen değeri Getname ile alınır");
            Console.WriteLine(Enum.GetName(typeof(Sabitler.tarihBilgileri.gunler), 5));
            Console.WriteLine("Tüm Değerleri String dizi ile alırı");
            string[] icerik = Enum.GetNames(typeof(Sabitler.tarihBilgileri.aylar));
            Console.WriteLine("Aylar Enum içeriğinin string karşılığı");
            foreach (var item in icerik)
            {
                Console.Write("{0}",item);

            }
            Console.WriteLine("Aylar Enum içeriğinin string ve int karşılığı");
            
            foreach (var item in Enum.GetValues(typeof(Sabitler.tarihBilgileri.aylar)))
            {
                Console.Write("{0}=",item);
                Console.WriteLine((int)item);
            }
            

        }

    }
  
}

