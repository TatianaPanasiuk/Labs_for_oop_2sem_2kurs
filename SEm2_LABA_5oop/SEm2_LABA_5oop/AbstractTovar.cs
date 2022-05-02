using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEm2_LABA_5oop
{
    public interface ITovoar
    {
        Proizvoditel createProizvoditel(string org, string strana, string adres, string telefon);

        Tovar createTovar(string nazvanie, string inventnumber, string cena, string ves, int colichestvo, DateTime data);

    }
    class AbstractTovar : ITovoar
    {
        public Proizvoditel createProizvoditel(string org, string strana, string adres, string telefon)
        {
            Proizvoditel proiz = new Proizvoditel();
            proiz.Org = org;
            proiz.Strana = strana;
            proiz.Adres = adres;
            proiz.Telefon = telefon;
            return proiz;
        }

        public Tovar createTovar(string nazvanie, string inventnumber, string cena, string ves, int colichestvo, DateTime data)
        {
            Tovar tovar = new Tovar();
            tovar.Nazvanie = nazvanie;
            tovar.inventNumber = inventnumber;
            tovar.Ves = ves;
            tovar.Cena = cena;
            tovar.Data = data;
            tovar.Colichestvo = colichestvo;

            return tovar;
        }

    }
}


