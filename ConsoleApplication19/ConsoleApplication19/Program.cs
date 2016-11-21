using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication19
{
    class Program
    {
        static void Main(string[] args)
        {
            char OPCJA ='0';
            Koszyk koszyk = new Koszyk();
            do
            {
               Console.Clear();
            Console.WriteLine("Dzień dobry!");
            Console.WriteLine("Co chcesz zrobić? Naciśnij odpowiedni klawisz.");
            Console.WriteLine("Legenda:");
            Console.WriteLine("P - dodaj produkt do koszyka");
            Console.WriteLine("K - skopiuj ostatnio wprowadzony produkt");
            Console.WriteLine("Z - pokaz zawartość koszyka");
            Console.WriteLine("S - pokaz sumę do zapłaty");
            Console.WriteLine("X - skasuj produkt z listy (musisz znać wcześniej numer na liście)");
            Console.WriteLine("W - wydrukuj paragon");
            Console.WriteLine("E - zakończ działanie programu");
            OPCJA = Convert.ToChar(Console.ReadLine());
            OPCJA=Char.ToUpper(OPCJA);

            switch (OPCJA)
            {
                case 'P':
                    Console.WriteLine("Podaj nazwę produktu:");
                    string nazwa = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Cena jednostkowa:");
                    double cenaJednostkowa = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ilość:");
                    int ilosc = Convert.ToInt32(Console.ReadLine());
                    Produkt nowyProdukt = new Produkt(nazwa, cenaJednostkowa, ilosc);
                    koszyk.dodajProdukt(nowyProdukt);
                    Console.Clear();
                    OPCJA = '0';
                    break;

                case 'K':
                    Console.WriteLine("Powielam ostatnią pozycję:");
                    Produkt produktCopy = koszyk.dajListe().Last();
                    Console.WriteLine(produktCopy.dajInfo());
                    koszyk.dajListe().Add(produktCopy);
                    Console.ReadKey();
                    break;

                case 'Z':
                    Console.WriteLine("Koszyk zawiera:");
                    koszyk.wyswietlKoszyk();
                    Console.ReadKey();
                    break;

                case 'S':
                    Console.WriteLine("Koszt koszyka to:");
                    Console.WriteLine(koszyk.kosztKoszyka() + " PLN");
                    Console.ReadKey();
                    break;

                case 'X':
                    Console.WriteLine("Wybierz pozycję do skasowania: ");
                    koszyk.wyswietlKoszyk();
                    int POZYCJA = Convert.ToInt32(Console.ReadLine());
                    koszyk.dajListe().RemoveAt(POZYCJA-1);
                    Console.ReadKey();
                    break;

                case 'W':
                    Console.WriteLine("Podaj ile pieniedzy wplaca klient: ");
                    double kasa = Convert.ToDouble(Console.ReadLine());
                    koszyk.drukujParagon(kasa);
                    Console.ReadKey();
                    break;

                case 'E':
                    
                    break;

                

                default:
                    Console.WriteLine("Domyślna akcja - inny numer");
                    break;
            }
            }while(OPCJA!='E');


        }
    }
}
