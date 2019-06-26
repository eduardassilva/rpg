using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal
{
    class Guerreiro : Personagem
    {      
        public Guerreiro(string nome) : base(nome, "Guerreiro", 10, 3, 2, 1, 16)
        {
        }

        public override void Especial(Inimigos alvo)
        {          
            //TESTAR POR TODAS AS HABILIDADES ASSIM, PARECE FUNCIONAL
            if (Rolagem.Rola(20, Destreza) >= alvo.Armadura)
            {
                Console.WriteLine("VOCÊ ACERTOU!");
                Console.WriteLine("ESPADADA");
                alvo.Vida -= Rolagem.Rola(6, Forca);
            }
            else
            {
                Console.WriteLine("VOCÊ ERROU!");
            }
        }

        public override void Especial2(Personagem alvo)
        {
            Console.WriteLine("VOCÊ ACERTOU!");
            Console.WriteLine("BANDAGEM");
            alvo.Vida += Rolagem.Rola(4, 0);
        }
    }
}
