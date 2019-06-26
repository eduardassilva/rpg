using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal
{
    class Sentinelas : Inimigos
    {
        public Sentinelas() : base("Sentinelas", 9, 6, 12, 9)
        {
            vidainicial = Vida;

        }
        public override void Especial(Personagem alvo)
        {                   
            if (Rolagem.Rola(20, Dano) >= alvo.Armadura)
            {
                Console.WriteLine();
                Console.WriteLine("INIMIGO ACERTOU!");
                Console.WriteLine("ATAQUE MAGICO");
                alvo.Vida -= Rolagem.Rola(8, 0);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("INIMIGO ERROU!");
            }
        }

        public override void Especial2(Personagem alvo)
        {
            if (Rolagem.Rola(20, Dano) >= alvo.Armadura)
            {
                Console.WriteLine();
                Console.WriteLine("INIMIGO ACERTOU!");
                Console.WriteLine("ATAQUE FISICO");
                alvo.Vida -= Rolagem.Rola(6, 0);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("INIMIGO ERROU!");
            }
        }
    }
}
