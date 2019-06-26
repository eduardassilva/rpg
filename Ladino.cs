using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal
{
    public class Ladino : Inimigos
    { 
        public Ladino() : base ("Roberto", 7, 4, 12, 7)
        {

        }
        public override void Especial(Personagem alvo)
        {       
            //TESTAR POR TODAS AS HABILIDADES ASSIM, PARECE FUNCIONAL
            if (Rolagem.Rola(20, Dano) >= alvo.Armadura)
            {
                Console.WriteLine("INIMIGO ACERTOU!");
                Console.WriteLine("FACADA!");
                alvo.Vida -= Rolagem.Rola(6, 0);
            }
            else
            {
                Console.WriteLine("INIMIGO ERROU!");
            }
        }
        public override void Especial2(Personagem alvo)
        {         
            //TESTAR POR TODAS AS HABILIDADES ASSIM, PARECE FUNCIONAL
            if (Rolagem.Rola(20, Dano) >= alvo.Armadura)
            {
                Console.WriteLine("INIMIGO ACERTOU!");
                Console.WriteLine("AREIA NA CARA!");
                alvo.Vida -= Rolagem.Rola(4, 0);
            }
            else
            {
                Console.WriteLine("INIMIGO ERROU!");
            }
        }      
    }
}
