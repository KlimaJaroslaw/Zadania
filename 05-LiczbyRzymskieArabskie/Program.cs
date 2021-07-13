using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LiczbyRzymskieArabskie
{
    class Program
    {
        static void Main(string[] args)
        {
            ArabskieNaRzymskie();
            Console.ReadKey();
        }

        private static int[] arab = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        private static String[] rzym = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

        private static void ArabskieNaRzymskie()
        {
            

            
            while (true)
            {
                int liczba = 0;
                int liczba_p = 0;
                int i = 0;
                string wynik = "";

                do
                {
                    Liczba(out liczba);
                } while (liczba > 3999 || liczba < 1);

                liczba_p = liczba;

                while (liczba > 0)
                {
                    if (liczba >= arab[i])
                    {
                        liczba -= arab[i];
                        wynik += rzym[i];
                    }
                    else i++;
                }


                Console.WriteLine("Liczba {0} to {1} w systemie rzymskim", liczba_p, wynik);
                Console.WriteLine();                
            }

        }

        private static int Liczba(out int l)
        {
            char znak;
            string l_str = "";

            Console.Write("Podaj liczbę od 1 od 3999: ");
            do
            {
                znak = Console.ReadKey(true).KeyChar;
                

                while (l_str.Length == 0)
                {
                    if (znak == (char)ConsoleKey.D0)
                    {
                        znak = 'X';
                    }
                    break;
                }
                    

                    if (znak == (char)ConsoleKey.Enter && (l_str.Length) > 0)
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

            Console.WriteLine();
            l = Convert.ToInt32(l_str);
            return l;
            }
        }
}
