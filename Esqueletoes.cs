using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal
{
    class Esqueletoes : Inimigos
    {
        public Esqueletoes() : base("Esqueletões", 5, 4, 12, 5)
        {
            //3 unidades
        }
        public override void Especial(Personagem alvo)
        {
            if (Rolagem.Rola(20, Dano) >= alvo.Armadura)
            {
                Console.WriteLine("INIMIGO ACERTOU!");
                Console.WriteLine("OSSADA MAGICA");
                alvo.Vida -= Rolagem.Rola(8, 0);
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
                Console.WriteLine("OSSO BOOMERANG");
                alvo.Vida -= Rolagem.Rola(6, 0);
            }
            else
            {
                Console.WriteLine("INIMIGO ERROU!");
            }
        }
    }
}
