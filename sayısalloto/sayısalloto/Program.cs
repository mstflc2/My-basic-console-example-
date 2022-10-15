
using System;

namespace sayısalloto
{
    class Program
    {
        static void Main(string[] args)
        {
        #region sayısal loto 
        BASADON: 
            Console.Write("lütfen kaç kolon oynayacağınızı giriniz :  ");
            int kolonsayi = int.Parse(Console.ReadLine());
            int[] kolon = new int[6];
            Random rnd = new Random();
            for (int i = 0; i < kolonsayi; i++)
            {
                Console.Write("{0} . kolon : ", i + 1);
                for (int j = 0; j < kolon.Length; j++)
                {
                yeniden:
                    int a = rnd.Next(1, 49);
                    for (int k = 0; k < kolon.Length; k++)
                    {
                        if (kolon[k]==a) goto yeniden;                   
                    }
                    kolon[j] = a;
                }
                Array.Sort(kolon);
                foreach (int eleman in kolon)
                {
                    Console.Write(eleman + "  ");
                }
                Console.WriteLine();
            }
        SEC:
            Console.WriteLine(" Yeniden oyamak istermisiniz ?  [evet : e    ,   hayır : h ]");
            string secim = Console.ReadLine().ToLower();
            if (secim == "e")
            {   Console.Clear();
                goto BASADON;
            }
            else if (secim == "h")
                Environment.Exit(0);
            else
            {   Console.Clear();
                Console.WriteLine("Yanlış bir seçi yaptınız !!!");
                goto SEC;
            }
            Console.ReadLine();
            #endregion
        }
    }
}
