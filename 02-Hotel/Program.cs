using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            int wiek;
            int noce;
            double cena;

            while (true)
            {
                Console.Write("Podaj swój wiek: ");
                wiek = Convert.ToInt32(Console.ReadLine());

                Console.Write("Podaj ilość nocy: ");
                noce = Convert.ToInt32(Console.ReadLine());

                if (wiek > 0 && wiek <= 18)
                    wiek = 1;
                else if (wiek > 18 && wiek < 65)
                    wiek = 2;
                else if (wiek > 64)
                    wiek = 3;
                else
                    wiek = 4;

                //
                Obliczenia(wiek, noce, out cena);

                Console.WriteLine("Należy zapłacić: {0} zł",cena);
                //Console.ReadKey();
                Console.WriteLine();
            }

            //Console.ReadKey();
        }

        private static double Obliczenia(int a, int b, out double c)
        {
            
            int x  = 0;
            
            if (b == 1)
            {
                x = 1;
            } 
            else if(b>=2 && b <= 4)
            {
                x = 2;
            }
            else if (b>=5)
            {
                x = 3;
            }

            if (a == 1)
            {
                 c = b * 100;
            }
            else if (a == 2 || a == 3)
            {
                switch (x)
                {
                    case 1:
                        c = b * 200;
                        break;
                    case 2:
                        c = b * 180;
                        break;
                    case 3:
                        c = b * 150;
                        break;
                    default:
                        c = 0.00;
                        break;
                }
            }
            else
                c = 0.00;
            
            if  (a==3)
            {
                c = c*0.9;
            }

            return c;

            
        }
    }
}
