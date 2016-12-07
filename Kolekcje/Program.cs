using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcje
{
    class Program
    {
        static void Main(string[] args)
        {
            Kolejka k = new Kolejka();
            k.Dodaj(1);
            k.Dodaj(5);
            k.Dodaj(3);
            k.Dodaj(8);
            k.Wypisz();
            Console.WriteLine("Liczba elementów: {0}", k.LiczbaElementow);
            int element = (int)k.Pobierz();
            Console.WriteLine("Pobrany element: {0}", element);
            k.Wypisz();
            Console.WriteLine("Liczba elementów: {0}", k.LiczbaElementow);
            k.Dodaj(7);
            k.Dodaj(4); k.Wypisz();
            Console.WriteLine("Liczba elementów: {0}", k.LiczbaElementow);
            element = (int)k.Pobierz();
            Console.WriteLine("Pobrany element: {0}", element);
            k.Wypisz();
            Console.WriteLine("Liczba elementów: {0}", k.LiczbaElementow);
            Console.ReadKey();

        }
    }
}
