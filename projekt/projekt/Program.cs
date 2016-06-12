using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaZakupow = new ZbiorZakupow();
            string wybor;

            do 
            {
                Console.WriteLine("1 : Dodaj produkt ");
                Console.WriteLine("2 : Wyswietl liste produktow ");
                Console.WriteLine("3 : Sumuj wydatki ");
                Console.WriteLine("4:  Przejrzyj opłaty miesieczne ");
                Console.WriteLine("5:  Dodaj opłaty miesieczne ");
                wybor = Console.ReadLine();
                switch (wybor)
                {
                    case "1":
                        listaZakupow.DodajZakupy();
                        break;
                    case "2":
                        listaZakupow.PokazListeZakupow();
                        break;
                    case "3":
                        listaZakupow.ZsumujWydatki();
                        break;
                    case "4":
                        listaZakupow.PokazListOplat();
                        break;
                    case "5":
                        listaZakupow.DodajOplaty();
                        break;
                    case "9":
                        Console.ReadKey();
                        break;

                }
            } while (wybor != "9") ;

          //  listaZakupow.PokazListeZakupow();
            Console.ReadKey();
        }
    }
}