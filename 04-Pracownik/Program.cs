using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Pracownik
{
    class Program
    {
        static void Main(string[] args)
        {
            char wyjscie;
            do
            {
                string imie = "";
                string nazwisko = "";
                double stawka = 0;
                double godziny = 0;


                Console.Write("Podaj imię:");
                imie = Console.ReadLine();

                Console.Write("Podaj nazwisko:");
                nazwisko = Console.ReadLine();

                Liczba("Podaj stawkę: ", out stawka);
                Liczba("Podaj godzdiny: ", out godziny);

                Employee pracownik = new Employee(imie, nazwisko, stawka);
                pracownik.RegisterTime(godziny);
                pracownik.DoWyplaty();
                pracownik.Info();

                wyjscie = Console.ReadKey().KeyChar;
            } while (!(wyjscie ==(char)ConsoleKey.Escape));
                        
        }

        private static double Liczba(string a, out double l)
        {
            char znak;
            string l_str = "";

            Console.Write(a);
            do
            {
                znak = Console.ReadKey(true).KeyChar;
               
                if (znak == (char)ConsoleKey.Enter && (l_str.Length) > 0)
                    break;

                if ("1234567890.,".Contains(znak))
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
            l = Convert.ToDouble(l_str);
            return l;
        }
        /*
        Employee new_emp = new Employee();

        private static Employee Test()
        {
            Employee new_emp = new Employee();
            return new_emp;
        }
        */
    }
}
