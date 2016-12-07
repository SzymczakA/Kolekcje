using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcje
{
    class Element
    {
        public Element(object dane_, Element adresNastepnego_)
        {
            Dane = dane_;
            AdresNastepnego = adresNastepnego_;
        }


        private object dane;
        private Element adresNastepnego;


        public object Dane
        {
            get
            {
                return dane;
            }

            set
            {
                dane = value;
            }
        }
        public Element AdresNastepnego
        {
            get
            {
                return adresNastepnego;
            }

            set
            {
                adresNastepnego = value;
            }
        }

        public void WypiszDane()
        {
            Console.WriteLine(Dane);
        }
    }
}
