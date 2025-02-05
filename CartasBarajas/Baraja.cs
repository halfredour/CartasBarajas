using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartasBarajas
{
    internal class Baraja
    {

        private List<Carta> cartas = new List<Carta>();

        public List<Carta> Cartas { get => cartas; }

        public Baraja()
        {
            string[] palos = { "corazones", "picas", "treboles", "diamantes" };

            foreach (string palo in palos)
            {
                for (int j = 0; j < 13; j++)
                {
                    Cartas.Add(new Carta(palo, j + 1));


                }
            }
        }

        public void Barajar()
        {
            Random rnd = new Random();
            int aleatorio = rnd.Next(0, 52);
            for (int i = 0; i < cartas.Count; i++)
            {
                Carta randomCarta = cartas[aleatorio]; // Guardar carta de la posicion aleatoria
                cartas[aleatorio] = cartas[i]; // Añadir en la posicion aleatoria el valor de la carta i
                cartas[i] = randomCarta; // En i añadimos la carta guardada temporalmente
            }
        }
        public Carta Robar()
        {
            Carta carta = cartas[0];
            cartas.Remove(carta);
            return carta;
        }
        public Carta RobarN(int n)
        {
            Carta carta = cartas[n];
            cartas.Remove(carta);
            return carta;
        }
        public Carta RobarAzar()
        {
            Random random = new Random();
            int n = random.Next(0, 52);
            Carta carta = cartas[n];
            cartas.Remove(carta);
            return carta;

        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Carta item in cartas)
            {
                sb.Append(item);
            }
            return sb.ToString();
        }
    }
}
