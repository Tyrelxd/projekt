﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    public class ZbiorZakupow : IOplaty
    {
        public List<Zakupy> ListaZakupow;
        public List<OplatyMiesieczne> ListaOplat;
        public ZbiorZakupow()
        {
            this.ListaZakupow = new List<Zakupy>();
            this.ListaOplat = new List<OplatyMiesieczne>();
            Zakupy ogolne = new Zakupy();
            ogolne.nazwa = "Chleb";
            ogolne.koszt = "3.14";
            ogolne.dzien = "11";
            ogolne.miesiac = "12";
            ogolne.rok = "2016";
            this.ListaZakupow.Add(ogolne);
            OplatyMiesieczne wszystkie = new OplatyMiesieczne();
            wszystkie.nazwa = "Prad";
            wszystkie.koszt = "300";
            wszystkie.dzien = "12";
            wszystkie.miesiac = "12";
            wszystkie.rok = "2016";
            wszystkie.Ilepowtorzen = "1";
            this.ListaOplat.Add(wszystkie);
        }
        public void PokazListeZakupow()
        {
            foreach (var Zakupy in this.ListaZakupow)
            {
                Console.WriteLine(Zakupy.Wypisz());
            }
        }

        public void PokazListOplat()
        {
            foreach (var Oplatymiesieczne in this.ListaOplat)
            {
                Console.WriteLine(Oplatymiesieczne.Wypisz());
            }
        }


        public void DodajZakupy()
        {
            Zakupy ogolne = new Zakupy();
            Console.WriteLine("Podaj nazwe");
            ogolne.nazwa = Console.ReadLine();
            Console.WriteLine("Podaj koszt");
            ogolne.koszt = Console.ReadLine();
            Console.WriteLine("Podaj dzien");
            ogolne.dzien = Console.ReadLine();
            Console.WriteLine("Podaj miesiac");
            ogolne.miesiac = Console.ReadLine();
            Console.WriteLine("Podaj rok");
            ogolne.rok = Console.ReadLine();

            this.ListaZakupow.Add(ogolne);

        }

        public void DodajOplaty()
        {
            OplatyMiesieczne wszystkie = new OplatyMiesieczne();
            Console.WriteLine("Podaj nazwe");
            wszystkie.nazwa = Console.ReadLine();
            Console.WriteLine("Podaj koszt");
            wszystkie.koszt = Console.ReadLine();
            Console.WriteLine("Podaj dzien");
            wszystkie.dzien = Console.ReadLine();
            Console.WriteLine("Podaj miesiac");
            wszystkie.miesiac = Console.ReadLine();
            Console.WriteLine("Podaj rok");
            wszystkie.rok = Console.ReadLine();
            Console.WriteLine("Ilosc powtorzen");
            wszystkie.Ilepowtorzen = Console.ReadLine();

            this.ListaOplat.Add(wszystkie);

        }

        public int ZsumujWydatki()
        {
            int cena=0;
            Console.WriteLine("Z jakiego miesiąca");
            string miesiac = Console.ReadLine();
            foreach (Zakupy ogolne in ListaZakupow)
            {
                if (miesiac == ogolne.miesiac)
                {
                    cena = Int32.Parse(ogolne.koszt) + cena;

                }
            }
            return cena;

        }

        public void GotowyProdukt()
        {
            Zakupy ogolne = new Zakupy();
            Console.WriteLine("Wpisz numer");
            Console.WriteLine("2.Mleko");
            Console.WriteLine("3.Chleb");
            Console.WriteLine("5.Maslo");
            Console.WriteLine("6.Banan");
            Console.WriteLine("7.Czekolada");
            Console.WriteLine("11.Jajka");
            string produkt;
            produkt = Console.ReadLine();
            ogolne.nazwa = produkt;
            if (produkt == "Mleko")
            {
                int mleko = (int)EnumPrzedmioty.Przedmioty.mleko;
                ogolne.koszt = Convert.ToString(mleko);
            }
            if (produkt == "Chleb")
            {
                int chleb = (int)EnumPrzedmioty.Przedmioty.chleb;
                ogolne.koszt = Convert.ToString(chleb);
            }
            if (produkt == "Maslo")
            {
                int maslo = (int)EnumPrzedmioty.Przedmioty.maslo;
                ogolne.koszt = Convert.ToString(maslo);
            }
            if (produkt == "Banan")
            {
                int banan = (int)EnumPrzedmioty.Przedmioty.banan;
                ogolne.koszt = Convert.ToString(banan);
            }
            if (produkt == "Czekolada")
            {
                int czekolada = (int)EnumPrzedmioty.Przedmioty.czekolada;
                ogolne.koszt = Convert.ToString(czekolada);
            }
            if (produkt == "Jajka")
                 {
                int jajka = (int)EnumPrzedmioty.Przedmioty.jajka;
                ogolne.koszt = Convert.ToString(jajka);
            };


            Console.WriteLine("Podaj dzien");
            ogolne.dzien = Console.ReadLine();
            Console.WriteLine("Podaj miesiac");
            ogolne.miesiac = Console.ReadLine();
            Console.WriteLine("Podaj rok");
            ogolne.rok = Console.ReadLine();
            this.ListaZakupow.Add(ogolne);
        }







        }
    }
