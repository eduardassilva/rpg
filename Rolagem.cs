using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal
{
    static class Rolagem
    {
        static Random Random = new Random();
        public static int Rola(int dado, int modificador)
        {
            int debug;
            debug = Random.Next(1, dado + 1) + modificador;
            Console.WriteLine("Rolou um d" + dado + " com modificador " + modificador + ", seu resultado foi: "+ debug);            
            return debug;
        }        
    }
}
