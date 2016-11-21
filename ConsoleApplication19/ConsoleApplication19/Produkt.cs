using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication19
{
    class Produkt
    {
        private string nazwa;
        private double cenaJednostkowa;
        private int ilosc;


        public Produkt(string nazwa, double cenaJednostkowa, int ilosc)
        {
            this.nazwa = nazwa;
            this.cenaJednostkowa = cenaJednostkowa;
            this.ilosc = ilosc;

        }

        public string dajInfo()
        {
            string info = nazwa.ToUpper() +" "+ ilosc + "*" +cenaJednostkowa;

            return info;
        }
        public double dajCeneJednostkowa()
        {
            return cenaJednostkowa;
        }

        public int dajIlosc()
        {
            return ilosc;
        }
    }
}
