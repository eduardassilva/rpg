using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal
{
    class Golem : Inimigos
    {
        public Golem() : base("Golemzão", 13, 6, 15, 13)
        {

        }
        public override void Especial(Personagem alvo)
        {
            if (Rolagem.Rola(20, Dano) >= alvo.Armadura)
            {
                Console.WriteLine("INIMIGO ACERTOU!");
                Console.WriteLine("BOLA DE LAMA!");
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
                Console.WriteLine("BOLA DE LAMA!");
                alvo.Vida -= Rolagem.Rola(4, 0);
            }
            else
            {
                Console.WriteLine("INIMIGO ERROU!");
            }
        }
    }
}
