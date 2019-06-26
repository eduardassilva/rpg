using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal
{
    class Javali : Inimigos
    {
        public Javali() : base("Javali", 11, 4, 12, 11)
        {

        }
        public override void Especial(Personagem alvo)
        {         
            //TESTAR POR TODAS AS HABILIDADES ASSIM, PARECE FUNCIONAL
            if (Rolagem.Rola(20, Dano) >= alvo.Armadura)
            {
                Console.WriteLine("INIMIGO ACERTOU!");
                Console.WriteLine("MORDIDA");
                alvo.Vida -= Rolagem.Rola(6, 0);
            }
            else
            {
                Console.WriteLine("INIMIGO ERROU!");
            }
        }

        public override void Especial2(Personagem alvo)
        {
            if (Rolagem.Rola(20, Dano) >= alvo.Armadura)
            {
                Console.WriteLine("INIMIGO ACERTOU!");
                Console.WriteLine("PATADA");
                alvo.Vida -= Rolagem.Rola(4, 0);
            }
            else
            {
                Console.WriteLine("INIMIGO ERROU!");
            }
        }
    }
}
