using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kod_S_Pin_Sorgulama
{
    class Program
    {
        static void Main(string[] args)
        {
            string Pin1 = "1905";
            string girilenPIN;
            int Hak = 3;

            do
            {
                Console.Write("Enter PIN: ");
                girilenPIN = Console.ReadLine();
                Hak--;

                if (Pin1 == girilenPIN)
                {
                    Console.WriteLine("Hoş Geldin");
                    break;
                }

                if (Hak != 0)
                {
                    Console.WriteLine("Yanlış Giriş Yaptınız. " + Hak + " Hakkınız Kaldı!");

                }
            } while (Pin1 != girilenPIN && Hak > 0);

            if (Hak == 0 && Pin1 != girilenPIN)
                Console.WriteLine("Hattınız Bloke Oldu!!!");

            Console.ReadKey();

        }
    }
}
