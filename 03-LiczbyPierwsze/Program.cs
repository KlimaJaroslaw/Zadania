using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_LiczbyPierwsze
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                LiczbyPierwsze();
            } while (true);            
        }

        private static void LiczbyPierwsze()
        {
            int liczba = 0;
            int licznik = 0;
            LP(out liczba);
            Console.WriteLine();
            //
                for (int i = 2; i < liczba; i++)
                {
                    if (liczba % i == 0)
                    {                        
                        break;
                    } else
                    {
                        licznik++;
                    }
                }

                if (licznik == liczba - 2)
                {
                    Console.WriteLine("Liczba {0} jest liczbą pierwszą", liczba);
                } else
                {
                    Console.WriteLine("Liczba {0} NIE jest liczbą pierwszą", liczba);
                }

            Console.WriteLine();
        }

        private static int LP(out int l)
        {
            char znak;
            string l_str =  "";

            Console.Write("Podaj liczbę naturalną większą od 1: ");
            do
            {                
                znak = Console.ReadKey(true).KeyChar;                
                bool warunek = (l_str == "1");

                while (l_str.Length == 0)
                {
                    if (znak == (char)ConsoleKey.D0)
                    {
                        znak = 'X';
                    }
                    break;
                }
                
                
                if (znak == (char)ConsoleKey.Enter && (l_str.Length) > 0 && !warunek)
                    break;
                if ("1234567890".Contains(znak))
                {
                    l_str += znak;
                    Console.Write(znak);
                }
                else
                {
                    Console.Beep();
                }


            } while (true);
            
            l = Convert.ToInt32(l_str);
            return l;
            
        }
    }
}
