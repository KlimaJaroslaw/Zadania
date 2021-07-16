using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Wielkanoc
{

    class Program
    {
        static void Main(string[] args)
        {
            char wyjscie;
            do
            {

                int rok;
                int a;
                int b;
                int c;
                int d;
                int e;
                int f;
                int g;
                int h;
                int i;
                int k;
                int l;
                int m;
                int p;
                int dzien;
                int miesiac;

                Liczba("Podaj rok: ", out rok);

                a = rok % 19;
                b = rok / 100;
                c = rok % 100;
                d = b / 4;
                e = b % 4;
                f = (b + 8) / 25;
                g = (b - f + 1) / 3;
                h = (19 * a + b - d - g + 15) % 30;
                i = c / 4;
                k = c % 4;
                l = (32 + 2 * e + 2 * i - h - k) % 7;
                m = (a + 11 * h + 22 * l) / 451;
                p = (h + l - 7 * m + 114) % 31;

                dzien = (p + 1);
                miesiac = ((h + l - 7 * m + 114) / 31);

                DateTime date = new DateTime(rok, miesiac, dzien);

                Console.WriteLine("Wielkanoc: {0}", (date.ToString("yyyy-MM-dd")));

                wyjscie = Console.ReadKey(true).KeyChar;

            } while (!(wyjscie == (char)ConsoleKey.Escape));



        }

        private static int Liczba(string a, out int l)
        {
            char znak;
            string l_str = "";

            Console.Write(a);
            do
            {
                znak = Console.ReadKey(true).KeyChar;
               
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
            } while (l_str.Length<4);

            Console.WriteLine();
            l = Convert.ToInt32(l_str);
            return l;
        }
    }
}

