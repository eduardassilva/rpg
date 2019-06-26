using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal
{
    class Mago : Personagem
    {
        public Mago(string nome) : base(nome, "Mago", 6, 1, 2, 3, 10)
        {
        }
        
        public override void Especial(Inimigos alvo)
        {
            //TESTAR POR TODAS AS HABILIDADES ASSIM, PARECE FUNCIONAL
            if (Rolagem.Rola(20, Destreza) >= alvo.Armadura)
            {
                Console.WriteLine("VOCÊ ACERTOU!");
                Console.WriteLine("BOLA DE FOGO");
                alvo.Vida -= Rolagem.Rola(6, Inteligencia);
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
