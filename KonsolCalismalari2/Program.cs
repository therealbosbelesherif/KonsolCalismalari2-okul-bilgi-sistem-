using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonsolCalismalari2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***OGRENCI BILGI SISTEM***");
            int ogrencisayi,i;
            Console.WriteLine("Ogrenci sayisini giriniz: ");
            ogrencisayi = Convert.ToInt32(Console.ReadLine());
            string[] isim = new string[ogrencisayi];
            for(i = 0; i < ogrencisayi; i++)
            {
                Console.Clear();
                Console.WriteLine("{0}. öğrencinin ismini giriniz: ", i + 1);
                isim[i] = Console.ReadLine();
            }
            string[] soyisim = new string[ogrencisayi];
            for (i = 0; i < ogrencisayi; i++)
            {
                Console.Clear();
                Console.WriteLine("{0}. öğrencinin soyismini giriniz: ", i + 1);
                soyisim[i] = Console.ReadLine();
            }
            string[] numara = new string[ogrencisayi];
            for (i = 0; i < ogrencisayi; i++)
            {
                Console.Clear();
                Console.WriteLine("{0}. öğrencinin numarasını giriniz: ", i + 1);
                numara[i] = Console.ReadLine();
            }
            double[] sinavortalama = new double[ogrencisayi];
            int[] sinav1 = new int[ogrencisayi];
            int[] sinav2 = new int[ogrencisayi];
            int[] sinav3 = new int[ogrencisayi];
            for (i = 0; i < ogrencisayi; i++)
            {
                Console.Clear();
                Console.WriteLine("{0} {1} ({2}) isimli öğrencinin birinci sınav notunu giriniz: ", isim[i], soyisim[i], numara[i]);
                sinav1[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("{0} {1} ({2}) isimli öğrencinin ikinci sınav notunu giriniz: ", isim[i], soyisim[i], numara[i]);
                sinav2[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("{0} {1} ({2}) isimli öğrencinin üçüncü sınav notunu giriniz: ", isim[i], soyisim[i], numara[i]);
                sinav3[i] = Convert.ToInt32(Console.ReadLine());
                sinavortalama[i] = (sinav1[i] + sinav2[i] + sinav3[i]) / 3;
            }
            Console.Clear();
            Console.WriteLine("**********OGRENCI NOT SISTEM**********");
            for (i = 0; i < ogrencisayi; i++)
            {
                Console.WriteLine("{0} {1} ({2}) isimli öğrencinin birinci sınav notu: {3} ", isim[i], soyisim[i], numara[i], sinav1[i]);
                Console.WriteLine("{0} {1} ({2}) isimli öğrencinin ikinci sınav notu: {3} ", isim[i], soyisim[i], numara[i], sinav2[i]);
                Console.WriteLine("{0} {1} ({2}) isimli öğrencinin üçüncü sınav notu: {3} ", isim[i], soyisim[i], numara[i], sinav3[i]);
                Console.WriteLine("{0} {1} ({2}) isimli öğrencinin dönem not ortalaması: {3} ", isim[i], soyisim[i], numara[i], sinavortalama[i]);
                if(sinavortalama[i] >= 50 && sinavortalama[i] < 75)
                {
                    Console.WriteLine("{0} {1} ({2}) isimli öğrenci dönemi {3} not ortalaması ile başarıyla geçmiştir.", isim[i], soyisim[i], numara[i], sinavortalama[i]);
                }
                else if(sinavortalama[i] >= 75 && sinavortalama[i] < 85)
                {
                    Console.WriteLine("{0} {1} ({2}) isimli öğrenci dönemi {3} not ortalaması ile teşekkür belgesi almaya hak kazanarak başarıyla geçmiştir.", isim[i], soyisim[i], numara[i], sinavortalama[i]);
                }
                else if (sinavortalama[i] >= 85)
                {
                    Console.WriteLine("{0} {1} ({2}) isimli öğrenci dönemi {3} not ortalaması ile takdir ve onur belgelerini kazanmaya hak kazanarak başarıyla geçmiştir.", isim[i], soyisim[i], numara[i], sinavortalama[i]);
                }
                else
                {
                    Console.WriteLine("{0} {1} ({2}) isimli öğrenci dönemi {3} not ortalaması ile dönemde başarısız olmuştur.", isim[i], soyisim[i], numara[i], sinavortalama[i]);
                }
                    Console.WriteLine("------------------------------------------------------");
            }
            Console.Read();
        }
    }
}
