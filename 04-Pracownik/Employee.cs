using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Pracownik
{
    class Employee
    {
        string imie1="";
        string nazwisko1="";
        double stawka1=0;
        double wyplata1;
        double doWyplaty;

        public Employee(string imie="", string nazwisko="", double stawka=0)
        {
            this.imie1 = imie;
            this.nazwisko1 = nazwisko;
            this.stawka1 = stawka;
        }

        public void RegisterTime(double godziny)
        {
            if (godziny>8)
            {
                this.wyplata1 = 8 * stawka1 + (godziny - 8) * 2 * stawka1;
            }
            else
            {
                this.wyplata1 = godziny * stawka1;
            }
        }

        public double DoWyplaty()
        {            
            doWyplaty = wyplata1;
            wyplata1 = 0;
            return doWyplaty;
        }

        public void Info()
        {
            Console.WriteLine();
            Console.WriteLine("imie- {0}", this.imie1);
            Console.WriteLine("nazwisko- {0}", this.nazwisko1);
            Console.WriteLine("wypłata- {0}",this.doWyplaty);
            Console.WriteLine();
        }

        

    }
}
