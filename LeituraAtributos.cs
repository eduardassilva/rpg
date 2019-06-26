using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProjetoFinal
{
    static class LeituraAtributos
    {
        static string arquivo = File.ReadAllText(@"C:\Users\Duda\Documents\Balance.txt", Encoding.UTF8);
        public static string[] array;
        public static void Leitura()
        {
            array = arquivo.Split('/');
        }
        
    }
}
