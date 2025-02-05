using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartasBarajas
{
    internal class Carta
    {
        private string palo;
        private int numero;

        public Carta() { }
        public Carta(string palo, int num)
        {
            this.palo = palo;
            this.numero = num;
        }
        public string Palo
        {
            get
            {
                return palo;
            }
            set
            {
                if (value == "corazones" || value == "picas" || value == "diamantes" || value == "treboles")
                    palo = value;

            }

        }

        public int Numero
        {
            get
            {
                return numero;
            }
            set
            {
                if (value >= 1 && value <= 13)
                    numero = value;

            }
        }
        public override string ToString()
        {
            return $"{numero} de {palo}\n";
        }
    }
}