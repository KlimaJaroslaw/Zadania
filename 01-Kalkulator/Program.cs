using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            double arg1 = 0.00;
            double arg2 = 0.00;
            double result = 0.00;
            string op = "";           
            //
            while (true)
            {
                Console.Write("Podaj artgument #1: ");
                arg1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Podaj operator: ");
                op = Console.ReadLine();

                Console.Write("Podaj artgument #2: ");
                arg2 = Convert.ToDouble(Console.ReadLine());

                switch (op)
                {
                    case ("+"):
                        result = arg1 + arg2;
                        Console.WriteLine("Wynik = {0}", result);
                        break;
                    case ("-"):
                        result = arg1 - arg2;
                        Console.WriteLine("Wynik = {0}", result);
                        break;

                    case ("/"):
                        if (arg2 == 0)
                        {
                            Console.WriteLine("Dzielenie przez zero.");
                            
                        }
                        else
                        {
                            result = arg1 / arg2;
                            Console.WriteLine("Wynik = {0}", result);
                        }                        
                        break;

                    case ("*"):
                        result = arg1 * arg2;
                        Console.WriteLine("Wynik = {0}", result);
                        break;
                        
                    default:
                        Console.WriteLine("Podano nieodpowiedni operator.");
                        break;
                }
                
                Console.WriteLine();
                
            }
            //Console.ReadKey();

            

        }
    }
}
