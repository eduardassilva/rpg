using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal
{
    class Swashbuckler : Personagem
    {
        public Swashbuckler(string nome) : base(nome, "Swashbuckler", 8, 2, 3, 2, 12)
        {          
        }

        public override void Especial(Inimigos alvo)
        {
            //TESTAR POR TODAS AS HABILIDADES ASSIM, PARECE FUNCIONAL
            if (Rolagem.Rola(20, Destreza) >= alvo.Armadura)
            {
                Console.WriteLine("VOCÊ ACERTOU!");
                Console.WriteLine("FACADA");
                alvo.Vida -= Rolagem.Rola(6, Destreza);
            }
            else
            {
                Console.WriteLine("VOCÊ ERROU!");
            }
        }

        public override void Especial2(Personagem alvo)
        {
            Console.WriteLine("CURA MENOR");
            alvo.Vida += Rolagem.Rola(4, 0);
        }
    }
}
