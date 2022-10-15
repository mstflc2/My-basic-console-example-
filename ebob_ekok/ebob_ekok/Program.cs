using System;

namespace ebob_ekok
{
    class Program
    {
        static void Main(string[] args)
        {
            EB_EK ebob_ekok_bulma = new EB_EK();
        BASADON:
            double sayi1;
            double sayi2;
            Console.WriteLine(" ebobları ekokları  bulunacak sayıları giriniz  ");
            Console.Write(" Birinci sayı : ");
            sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.Write(" İkinci sayı : ");
            sayi2 = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("  {0} ve {1} sayılarının ebobu {2} ", sayi1, sayi2, ebob_ekok_bulma.ebobhesapla(sayi1, sayi2));
            Console.WriteLine("  {0} ve {1} sayılarının ekoku {2} ", sayi1, sayi2, ebob_ekok_bulma.ekokhesaplama(sayi1, sayi2));
        SECİM:
            Console.Write(" Yeniden işlem yapmak istiyormusunuz ? [evet : e / hayır : h]");
            string secim = Console.ReadLine().ToLower();

            if (secim == "h")
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Clear();
                    Console.WriteLine(" TEŞEKÜRLER birazdan sistemden çıkarılacaksınız !!! ");
                    System.Threading.Thread.Sleep(2000);

                }
            }
            else if (secim == "e")
            {
                Console.Clear();
                goto BASADON;

            }
            else
            {
                Console.Write("Yanlış İşlem yaptınız LÜtfen tekrar deneyiniz...");
                goto SECİM;
            }
        }
        public class EB_EK
        {
            public double ekokhesaplama(double sayi1, double sayi2)
            {
                double ekok = 1;
                for (int i = 1; i <= sayi1 * sayi2; i++)
                {
                    if (sayi1 % sayi2 != 0 && sayi2 % sayi1 != 0)
                    {
                        if (i > sayi1 && i > sayi2)
                        {
                            if (i % sayi1 == 0 && i % sayi2 == 0)
                            {
                                ekok = i;
                                break;
                            }
                        }

                    }
                    else
                    {
                        ekok = Math.Max(sayi1, sayi2);
                    }
                }
                return ekok;
            }
            public double ebobhesapla(double _sayi1, double _sayi2)
            {
                double ebob = 1;
                double minsayi = Math.Min(_sayi1, _sayi2);
                for (int i = 1; i <= minsayi; i++)
                {
                    if (_sayi1 % i == 0 && _sayi2 % i == 0)
                    {
                        ebob = i;
                    }
                }
                return ebob;
            }

        }
    }
}
