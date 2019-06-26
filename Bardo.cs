using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal
{
    public class Bardo : Inimigos
    {
        //amigo Noah
        public Bardo() : base("Noah", 11, 4, 12, 12)
        {

        }
        public override void Especial(Personagem alvo)
        {
            if (Rolagem.Rola(20, Dano) >= alvo.Armadura)
            {
                Console.WriteLine("INIMIGO ACERTOU!");
                Console.WriteLine("BATER COM VIOLÃO");
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
                Console.WriteLine("XINGAMENTO MAGICO");
                alvo.Vida -= Rolagem.Rola(8, 0);
            }
            else
            {
                Console.WriteLine("INIMIGO ERROU!");
            }
        }
    }
}
