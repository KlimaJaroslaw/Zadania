using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szanty
{
    class Program
    {
        static void Main(string[] args)
        {
            string tekst;
            int piosenka;            
            int zwrotki;
            do
            {
                Console.WriteLine("1 - Morskie opowieści");
                Console.WriteLine("2 - Bitwa");
                Console.WriteLine("0 - Własna");                
                Console.WriteLine("ESC - Wyjście");
                Console.WriteLine();
                Liczba("Wybór szanty: ", out piosenka);
                                
                switch (piosenka)
                {
                    case 1:
                        tekst = "a3a3a3a3a3d3f3a3g3g3g3g3g3c3e3g3a3a3a3a3a3h3C3D3C3a3g3e3d4d4a4a3a3a3d3f3a3g4g3g3g3c3e3g3a4a3a3a3h3C3D3C3a3g3e3d4d4";
                        break;
                    case 2:
                        tekst = "E3h3E4D3a3D4C3D3C3h3a4d3a3h3g4a3a3g3f3g3f3g3a3h4E3h3E4D3a3D4C3D3C3h3a4d3a3h3g4a3a3g3f3g3g3g3a3h3a3g3f3g4h4a3g3f3d3e4d4c3d4e3f3g4f3a3f3d3e5f4g3a3h4a3g3f3d3e4d4c3d4e3f3g4f3a3f3d3e5f4";
                        break;
                    case 0:
                        tekst = Console.ReadLine();
                        break;
                    default:
                        tekst = "";
                        break;
                    case 9:
                        //Environment.Exit(0);
                        return;                                                
                }
                Liczba("Liczba zwrotek: ", out zwrotki);

                for (int i = 0; i < zwrotki; i++)
                {
                    BotSzanty(tekst);
                }
                Console.Clear();

            } while (true);
            
        }

        private static void BotSzanty(string tekst)
        {
            int a;
            int b;            
            char f;
            char d;
            Hashtable frequency = new Hashtable();            
            frequency.Add('c', 262);
            frequency.Add('d', 294);
            frequency.Add('e', 330);
            frequency.Add('f', 349);
            frequency.Add('g', 392);
            frequency.Add('a', 440);
            frequency.Add('h', 494);
            frequency.Add('C', 523);
            frequency.Add('D', 587);
            frequency.Add('E', 659);
            frequency.Add('F', 699);
            frequency.Add('G', 784);
            frequency.Add('A', 880);
            frequency.Add('H', 988);

            Hashtable duration = new Hashtable();
            duration.Add('6', 2000);
            duration.Add('5', 1000);
            duration.Add('4', 500);
            duration.Add('3', 250);
            duration.Add('2', 125);
            duration.Add('1', 75);            
            
            for (int i = 0, j = 0; i < tekst.Length; i=i+2)
            {                
                j = i + 1;
                f = tekst[i];
                d = tekst[j];
                a = Convert.ToInt32(frequency[f]);
                b = Convert.ToInt32(duration[d]);
                Console.WriteLine("f: {0} d: {1}", f, d);
                Grajek(a, b);
                
                
            }
                 
        }

        private static void Grajek(int a, int b)
        {
            Console.Beep(a, b);
        }

        private static int Liczba(string a, out int l)
        {
            char znak;
            string l_str = "";

            Console.Write(a);
            do
            {
                znak = Console.ReadKey(true).KeyChar;
                //if (znak == (char)ConsoleKey.Enter && (l_str.Length) > 0)
                //    break;
                if (znak == (char)ConsoleKey.Escape)
                    l_str = "9";

                if ("1234567890".Contains(znak))
                {
                    l_str += znak;
                    Console.Write(znak);
                }
                else
                {
                    Console.Beep();
                }
            } while (l_str.Length<1);

            Console.WriteLine();
            l = Convert.ToInt32(l_str);
            return l;
        }
    }
}
