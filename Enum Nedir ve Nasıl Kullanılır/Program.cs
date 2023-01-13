using System;

namespace Enum_Nedir_ve_Nasıl_Kullanılır
{
    internal class Program
    {
        enum Renkler { Kirmizi, Yesil, Mavi };
        enum Departmanlar { Yazilim, Bilgi_Işlem, Muhasebe };
        enum Gunler { Pazartesi, Sali, Carsamba, Persembe, Cuma, Cumartesi, Pazar };
        static void Main(string[] args)
        {
            /*
             * Enum dizile gibi kullanılır program kodlarının sadeleştirmesini sağlıyor
             * Veri banında index değerleri ile işlemler yapıldığında daha kullanılabilir
             * Enum sabit değerleri alır sonradan değiştirilemez
             * enum tanımlamaları calss dışında yapılır  
             */
            tarihBilgileri tarih = new tarihBilgileri();
            ogrenciNot not = new ogrenciNot();
            Console.WriteLine("Haftanın 1.Günü {0}", tarih);
        }
        class tarihBilgileri
        {
            public enum guner
            {
                Pazartesi = 1,
                Salı = 2,
                Çarşamba = 3,
                Perşembe = 4,
                Cuma = 5,
                Cumartesi = 6,
                Pazar = 7
            }//Haftanın Günleri 1 den başlar enum 0 dan dizi gibi başlar
            public enum aylar
            {
                Ocak = 1,
                Şubat = 2,
                Mart = 3,
                Nisan = 4,
                Mayıs = 5,
                Haziran = 6,
                Temmuz = 7,
                Ağustos = 8,
                Eylül = 9,
                Ekim = 10,
                Kasım = 11,
                Aralık = 12
            }
        }
        class ogrenciNot
        {
            enum gecmeDurumu
            {
                Başarısız = 0,
                Geçer = 45,
                Orta = 60,
                İyi = 70,
                Pekiyi = 80
            }
        }

    }

