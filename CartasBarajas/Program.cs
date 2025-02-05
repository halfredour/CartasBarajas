using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartasBarajas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Baraja baraja = new Baraja();
            Console.WriteLine(baraja.Mostrar());
            Console.ReadKey();

        }

    }
}