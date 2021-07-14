using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_PESEL
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Pesel();
                Console.ReadKey(true);
            }
            
        }

        private static void Pesel()
        {
            int r;
            int p;            
            int rok = 0;
            int miesiac = 0;
            int dzien = 0;
            string plec = "";
            Numer(out string pesel);
            CzyJestPoprawny(pesel, out bool poprawnosc);
            if (!poprawnosc)
            {
                Console.Beep();
                Console.WriteLine("Niepoprawny numer PESEL.");
            }
            else
            {
                r = (int)Char.GetNumericValue(pesel[2]) * 10 + (int)Char.GetNumericValue(pesel[3]);
                dzien = (int)Char.GetNumericValue(pesel[4]) * 10 + (int)Char.GetNumericValue(pesel[5]);
                r -= 12;
                if (r >= (-31) && r <= (-20))
                {
                    p = -1;
                }
                else if (r >= (-11) && r <= 0)
                {
                    p = 0;
                }
                else if (r >= 9 && r <= 20)
                {
                    p = 1;
                }
                else if (r >= 29 && r <= 40)
                {
                    p = 2;
                }
                else if (r >= 49 && r <= 60)
                {
                    p = 3;
                }
                else
                    p = 4;
                
                switch (p)
                {
                    case -1:
                        rok = 1800 + (int)Char.GetNumericValue(pesel[0]) * 10 + (int)Char.GetNumericValue(pesel[1]);
                        miesiac = r + 12 - 80;                        
                        break;
                    case 0:
                        rok = 1900 + (int)Char.GetNumericValue(pesel[0]) * 10 + (int)Char.GetNumericValue(pesel[1]);
                        miesiac = r + 12;
                        break;
                    case 1:
                        rok = 2000 + (int)Char.GetNumericValue(pesel[0]) * 10 + (int)Char.GetNumericValue(pesel[1]);
                        miesiac = r + 12 - 20;
                        break;
                    case 2:
                        rok = 2100 + (int)Char.GetNumericValue(pesel[0]) * 10 + (int)Char.GetNumericValue(pesel[1]);
                        miesiac = r + 12 - 40;
                        break;
                    case 3:
                        rok = 2200 + (int)Char.GetNumericValue(pesel[0]) * 10 + (int)Char.GetNumericValue(pesel[1]);
                        miesiac = r + 12 - 60;
                        break;
                    case 4:
                        Console.WriteLine("Niepoprawny numer PESEL.");
                        return;
                    default:
                        break;
                }

                switch (pesel[9]%2)
                {
                    case 0:
                        plec = "Baba";
                        break;
                    case 1:
                        plec = "Chłop";
                        break;
                    default:
                        break;
                }

                if (!(dzien <= 31))
                {
                    Console.WriteLine("Niepoprawny numer PESEL.");
                    return;
                }


                Console.WriteLine("Data urodzenia: {0} {1} {2}", rok, miesiac, dzien);
                Console.WriteLine("Płeć: {0}",plec);

            }

            

        }

        private static bool CzyJestPoprawny(string p, out bool s)
        {
            int suma = 0;
            if (!(p.Length==11))
            {
                return s = false;
            }
            for (int i = 0, j; i < p.Length-1; i++)
            {                
                j = (int)Char.GetNumericValue(p[i]);
                suma += (j * mnoznik[i]);
            }
            if (suma % 10 == (int)Char.GetNumericValue(p[10]) || 10 - (suma % 10) == (int)Char.GetNumericValue(p[10]))
            {
                return s = true;
            }
            else
                return s = false;
            
        }

        private static string Numer(out string l)
        {
            char znak;
            string l_str = "";

            Console.Write("Podaj PESEL: ");
            do
            {
                znak = Console.ReadKey(true).KeyChar;

                /*
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
                */

                if ("1234567890".Contains(znak))
                {
                    l_str += znak;
                    Console.Write(znak);
                }
                else
                {
                    Console.Beep();
                }
            } while (l_str.Length<11);

            Console.WriteLine();
            l = l_str;
            return l;
        }

        public static int[] mnoznik = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
    }
}
