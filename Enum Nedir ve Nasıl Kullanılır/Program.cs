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
            Sabitler.tarihBilgileri.aylar.Şubat
        }

    }
  
}

