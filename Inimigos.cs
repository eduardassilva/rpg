using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal
{
    public abstract class Inimigos
    {
        //classe que contem as informações basicas dos inimigos, assim como seus ataques gerais ou especiais
        public string nome;
        private int vida, dano, armadura;
        public int vidainicial;

        public Inimigos(string nome, int vida, int dano, int armadura, int vidainicial)
        {
            this.nome = nome;
            this.vida = vida;
            this.dano = dano;
            this.armadura = armadura;
            this.vidainicial = vida;
        }

        public int Vida
        {
            get
            {
                return vida;
            }
            set
            {
                vida = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }

        public int Dano
        {
            get
            {
                return dano;
            }
            set
            {
                dano = value;
            }
        }

        public int Armadura
        {
            get
            {
                return armadura;
            }
            set
            {
                armadura = value;
            }
        }

        // //chama o ataque socar
        public virtual void Socar(Personagem alvo)
        {
            if (Rolagem.Rola(20, dano) >= alvo.Armadura)
            {
                alvo.Vida -= Rolagem.Rola(4, 0);
                Console.WriteLine();
                Console.WriteLine("INIMIGO ACERTOU!");
                Console.WriteLine("VOCÊ FOI SOCADO");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("INIMIGO ERROU");
            }
        }
     
        //chamar o ataque chutar
        public virtual void Chutar(Personagem alvo)
        {
            if (Rolagem.Rola(20, dano) >= alvo.Armadura)
            {
                alvo.Vida -= Rolagem.Rola(6, 0);
                Console.WriteLine();
                Console.WriteLine("INIMIGO ACERTOU!");
                Console.WriteLine("VOCÊ FOI CHUTADO");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("INIMIGO ERROU");
            }
        }

        //chama o ataque cabeçada
        public virtual void Cabecada(Personagem alvo)
        {
            if (Rolagem.Rola(20, dano) >= alvo.Armadura)
            {
                alvo.Vida -= Rolagem.Rola(8, 0);
                Console.WriteLine();
                Console.WriteLine("INIMIGO ACERTOU!");
                Console.WriteLine("VOCÊ FOI CABECEADO");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("INIMIGO ERROU");
            }
        }
        
        //chama o especial 1
        public virtual void Especial(Personagem alvo)
        {
            Console.WriteLine(nome + " usou especial em " + alvo.nome + "!");
        }

        //chama o especial 2
        public virtual void Especial2(Personagem alvo)
        {
            Console.WriteLine(nome + " usou especial em " + alvo.nome + "!");
        }

    }
}
