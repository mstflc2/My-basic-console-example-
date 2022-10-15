using System;

namespace Tahmin_et
{
    class Program
    {
        static void Main(string[] args)
        {
        MENU:
            Console.WriteLine(" tahmin oyununa hoş geldiniz....");
            Console.WriteLine(" şimdi 1-30 arasından rastgele belirlenen bir sayıya ulaşmaya çalışacaksınız...");
            Console.WriteLine(" Ama bu oyunda bir rakibiniz var oda PC :)");
            Console.WriteLine(" 30dan başlayarak 1 veya iki azaltma seçeneklerinden birini seçeceksiniz..");
            Console.WriteLine(" sayıyı ilk tahmin eden kazanır.");
            Console.WriteLine(" hadi başlayalım ");
            int kullanicitahmin = 30;
            int pctahmin = 30;
            Console.WriteLine(" başlamak için herhangi bir tuşa basınız");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(" OYUN BAŞLIYOR ");
            System.Threading.Thread.Sleep(2000);
            Console.Clear();
            Random rastgele = new Random();
            int sayi = rastgele.Next(1, 30);
            for (int i = 0; i < 30; i++)
            {
                Console.Clear();
                Console.WriteLine(" Lütfen azaltmak istediğiniz sayı adedini giriniz.. [1-2] =?");
                int azaltim = Convert.ToInt16(Console.ReadLine());
                if (azaltim != 1 && azaltim != 2)
                {
                forbaslangic:
                    Console.WriteLine("yanlış bir seçim yaptınız tekrar deneyiniz.");
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                    goto forbaslangic;
                }
                kullanicitahmin = pctahmin - azaltim;
                if (kullanicitahmin >= sayi)
                {
                    if (kullanicitahmin == sayi)
                    {
                        Console.WriteLine("  TEBİKLER KAZANDINIZ");
                        Console.WriteLine(" TAHMİN EDİLEN SAYI  : {0} ", sayi);
                    secimislemi2:
                        Console.WriteLine(" yeniden oynamak istermisiniz [evet : e ,  hayır :h ] ?");
                        string secim1 = Console.ReadLine().ToLower();
                        if (secim1 == "e")
                        {
                            Console.Clear();
                            goto MENU;
                        }
                        else if (secim1 == "h")
                        {
                            Console.WriteLine(" HOŞÇAKALIN ");
                            System.Threading.Thread.Sleep(2000);
                        }
                        else
                        {
                            Console.WriteLine(" yanlış bir seçim yaptınız ");
                            goto secimislemi2;
                        }
                    }
                }
                else
                {
                    Console.WriteLine(" malesef oyun bitti kazanan çıkmadı. :(");
                secimislemi1:
                    Console.WriteLine(" yeniden oynamak istermisiniz [evet : e ,  hayır :h ] ?");
                    string secim1 = Console.ReadLine().ToLower();
                    if (secim1 == "e")
                    {
                        Console.Clear();
                        goto MENU;
                    }
                    else if (secim1 == "h")
                    {
                        Console.WriteLine(" HOŞÇAKALIN ");
                        System.Threading.Thread.Sleep(2000);
                    }
                    else
                    {
                        Console.WriteLine(" yanlış bir seçim yaptınız ");
                        goto secimislemi1;
                    }
                }
                int pcnintahmini = rastgele.Next(1, 3);
                pctahmin = kullanicitahmin - pcnintahmini;
                if (pctahmin >= sayi)
                {
                    if (pctahmin == sayi)
                    {
                        Console.WriteLine("  MALESEF PC KAZANDI :(");
                        Console.WriteLine(" TAHMİN EDİLEN SAYI  : {0} ", sayi);
                    secimislemi2:
                        Console.WriteLine(" yeniden oynamak istermisiniz [evet : e ,  hayır :h ] ?");
                        string secim1 = Console.ReadLine().ToLower();
                        if (secim1 == "e")
                        {
                            Console.Clear();
                            goto MENU;
                        }
                        else if (secim1 == "h")
                        {
                            Console.WriteLine(" HOŞÇAKALIN ");
                            System.Threading.Thread.Sleep(2000);
                        }
                        else
                        {
                            Console.WriteLine(" yanlış bir seçim yaptınız ");
                            goto secimislemi2;
                        }
                    }
                }
                Console.WriteLine(" Tahmininiz : {0}", kullanicitahmin);
                Console.WriteLine(" Pc nin tahmini : {0}", pctahmin);
                System.Threading.Thread.Sleep(2000);
                Console.Clear();

            }
        }
    }
}
