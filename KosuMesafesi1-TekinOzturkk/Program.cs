using System.Threading.Channels;

namespace KosuMesafesi1_TekinOzturkk
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int adimUzunluguCm = AdimUzunluguBul();
            int dakikadaAtilanAdimSayisi = DakikadaKacAdim();
            //int kosuDakikasi = KosuSuresiDk();
            double kosuSaati = KosuSuresiSaat();


            //int kosuMesafesiMetre1=((dakikadaAtilanAdimSayisi * adimUzunluguCm) * kosuDakikasi)/100; //Bu satırda KosuSuresiDk() metodundan dönen değer kullanıldı!
            //Console.WriteLine("Bugün Koştuğunuz Mesafe Metre Cinsinden: "+kosuMesafesiMetre1+"m'dir"+" (Koşu Süresi Verisi Dakika Türünde Alındı!)");

           double kosuMesafesiMetre2 = ((dakikadaAtilanAdimSayisi * adimUzunluguCm) * kosuSaati) / 100;/*Bu satırda koşu süresini KosuSuresiSaat() metodundan dönen değer
                                                                                                        * kullanıldı
                                                                                                        */
            Console.WriteLine("Bugün Koştuğunuz Mesafe Metre Cinsinden: " + kosuMesafesiMetre2 + "m'dir"+" (Koşu Süresi Verisi Saat Türünde Alındı!)");



        }

        static int AdimUzunluguBul()
        {

            tekrarAdimUzunlugu: Console.Write("Lütfen Adım Uzunluğunuzu Santimetre Cinsinden Giriniz: ");
            
            bool sayiMi=int.TryParse(Console.ReadLine(), out int sayi);
            if (sayiMi==true && sayi<300 && sayi>30)
            {
                Console.WriteLine("Adım Uzunluğunuz: "+sayi+" cm");
                
            }
            
            else
            {
                Console.WriteLine("Lütfen Adım Uzunluğunuzu Kontrol Ederek Tekrar Giriniz!");
                goto tekrarAdimUzunlugu;
            }
            return sayi;
            
        }

        static int DakikadaKacAdim()
        {
        tekrarDakikadaAdimAl: Console.Write("Lütfen Dakikada Kaç Adım Attığınızı Giriniz:");

            bool sayiMi2 = int.TryParse(Console.ReadLine(), out int kacAdim);
            if (sayiMi2==true && kacAdim>0 )
            {
                Console.WriteLine("Dakikada Attığınız Adım Sayısı " + kacAdim+" Adım");

            }

            else
            {
                Console.WriteLine("Lütfen Girdiğiniz Veriyi Kontrol Ederek Tekrar Giriniz!");
                goto tekrarDakikadaAdimAl;
            }
            return kacAdim;

        }

        static int KosuSuresiDk()
        {
           tekrarDakikaAl: Console.Write("Lütfen Kaç Dakika Koşacağınızı Giriniz:");
            bool sayiMi3 = int.TryParse(Console.ReadLine(), out int kacDakika);
            if (sayiMi3 == true && kacDakika>0)
            {
                Console.WriteLine("Bugün Koşacağınız Dakika " + kacDakika+" Dakika ");

            }
            else
            {
                Console.WriteLine("Lütfen Girdiğiniz Veriyi Kontrol Ederek Tekrar Giriniz!");
                goto tekrarDakikaAl;
            }
            return kacDakika;

        }
        static double KosuSuresiSaat()
        {
        tekrarSaatAl:
            Console.Write("Lütfen Kaç Saat Koşacağınızı Giriniz: ");
            bool sayiMi4 = double.TryParse(Console.ReadLine(), out double kacSaat);

            if (sayiMi4 == true && kacSaat > 0)
            {
                Console.WriteLine("Bugün Koşacağınız Saat: " + kacSaat + " Saat");
            }
            else
            {
                Console.WriteLine("Lütfen Girdiğiniz Veriyi Kontrol Ederek Tekrar Giriniz!");
                goto tekrarSaatAl;
            }         
            return kacSaat * 60; /*UYARI !!!
                                  * Alınan saat değerini(kacSaat) double döndürerek virgüllü şekilde saat yazabiliriz.
                                  * Örneğin 1.5 saat gibi || 1.2 saat gibi...
                                  */
                                 
                                 
        }


    }
}