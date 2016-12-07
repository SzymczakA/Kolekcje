using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcje
{
    class Kolejka
    {


        private Element pierwszyElement = null;
        private Element ostatniElement = null;
        private int liczbaElementow = 0;

        public int LiczbaElementow
        {
            get
            {
                return liczbaElementow;
            }

            set
            {
                liczbaElementow = value;
            }
        }

        public void Dodaj(object dane_)
        {
            Element tmp = new Element(dane_, null);
            if (pierwszyElement == null)
            {
                pierwszyElement = tmp;

            }
            else
            {
                ostatniElement.AdresNastepnego = tmp;
            }
            ostatniElement = tmp;
            liczbaElementow++;
        }
        public void Wypisz()
        {
            Element tmp = pierwszyElement;
            for (int i = 0; i < liczbaElementow; i++)
            {
                tmp.WypiszDane();
                tmp = tmp.AdresNastepnego;
            }
        }
        public object Pobierz()
        {
            if (pierwszyElement != null)
            {
                object tmp = pierwszyElement.Dane;
                pierwszyElement = pierwszyElement.AdresNastepnego;
                liczbaElementow--;
                return tmp;
            }

            return null;
        }


    }
}
