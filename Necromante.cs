using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal
{
    class Necromante : Inimigos
    {   
        public Necromante() : base("Claudio Furioso", 13, 4, 14, 13)
        {

        }
        public override void Especial(Personagem alvo)
        {
            if (Rolagem.Rola(20, Dano) >= alvo.Armadura)
            {
                Console.WriteLine("INIMIGO ACERTOU!");
                Console.WriteLine("RAIO NEGRO");
                alvo.Vida -= Rolagem.Rola(10, 0);
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
                Console.WriteLine("LANÇA DA MORTE");
                alvo.Vida -= Rolagem.Rola(8, 0);
            }
            else
            {
                Console.WriteLine("INIMIGO ERROU!");
            }
        }
    }
}
