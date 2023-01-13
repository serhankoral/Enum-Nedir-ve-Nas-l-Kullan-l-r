using System;
using System.Collections.Generic;
using System.Text;

namespace Enum_Nedir_ve_Nasıl_Kullanılır
{
    public class Sabitler
    {
        public class tarihBilgileri
        {
            public enum gunler
            {
                Pazartesi = 1,
                Salı = 2,
                Çarşamba = 3,
                Perşembe = 4,
                Cuma = 5,
                Cumartesi = 6,
                Pazar = 7
            };//Haftanın Günleri 1 den başlar enum 0 dan dizi gibi başlar
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
            };
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
            };
        }
    }
}
