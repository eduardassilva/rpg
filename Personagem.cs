using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal
{
    public abstract class Personagem
    {
        //classe que contem as informações basicas do personagem, assim como seus ataques gerais ou especiais
        public string nome, classe;
        private int vida, forca, destreza, inteligencia, armadura;
        public int vidainicial, forcainicial, destrezainicial, inteligenciainicial, armadurainicial;

        public Personagem(string nome, string classe, int vida, int forca, int destreza, int inteligencia, int armadura)
        {
            this.nome = nome;
            this.classe = classe;
            vidainicial = this.vida = vida;
            this.forca = forca;
            this.destreza = destreza;
            this.inteligencia = inteligencia;
            this.armadura = armadura;
            vidainicial = vida;
            forcainicial = forca;
            destrezainicial = destreza;
            inteligenciainicial = inteligencia;
            armadurainicial = armadura;
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

        public int Forca
        {
            get
            {
                return forca;
            }
            set
            {
                forca = value;
            }
        }

        public int Destreza
        {
            get
            {
                return destreza;
            }
            set
            {
                destreza = value;
            }
        }

        public int Inteligencia
        {
            get
            {
                return inteligencia;
            }
            set
            {
                inteligencia = value;
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
      
        //metodo pra mostrar os status
        public void status(int pontosTotal, string nome)
        {
            Console.WriteLine( nome + ", os pontos base da sua classe são: ");
            Console.WriteLine("Vida: " + Vida);
            Console.WriteLine("Armadura: " + Armadura);
            Console.WriteLine("Força: " + Forca);
            Console.WriteLine("Destreza: " + Destreza);
            Console.WriteLine("Inteligencia: " + Inteligencia);        
            Console.WriteLine("\nVocê tem " + pontosTotal + " pontos para distribuir entre: Força, Destreza e Inteligencia");
        }

        //chama o ataque socar
        public virtual void Socar(Inimigos alvo)
        {
            if(Rolagem.Rola(20, destreza) >= alvo.Armadura)
            {
                alvo.Vida -= Rolagem.Rola(4, forca);
                Console.WriteLine();
                Console.WriteLine("VOCÊ ACERTOU!");
                Console.WriteLine("VOCÊ SOCOU");
            }
            else
            {
                Console.WriteLine();
                 Console.WriteLine("VOCÊ ERROU");
            }           
        }

        //chamar o ataque chutar
        public virtual void Chutar(Inimigos alvo)
        {
            if (Rolagem.Rola(20, destreza) >= alvo.Armadura)
            {
                alvo.Vida -= Rolagem.Rola(4, destreza);
                Console.WriteLine("VOCÊ ACERTOU!");
                Console.WriteLine("VOCÊ CHUTOU");
            }
            else
            {
                Console.WriteLine("ERROU");
            }
        }

        //chama o ataque cabeçada
        public virtual void Cabecada(Inimigos alvo)
        {
            if (Rolagem.Rola(20, destreza) >= alvo.Armadura)
            {
                alvo.Vida -= Rolagem.Rola(4, inteligencia);
                Console.WriteLine("VOCÊ ACERTOU!");
                Console.WriteLine("VOCÊ FOI DE CABEÇADA");
            }
            else
            {
                Console.WriteLine("ERROU");
            }
        }

        //chama o especial 1
        public virtual void Especial(Inimigos alvo)
        {
            Console.WriteLine(nome + " usou especial em " + alvo.nome + "!");
        }

        //chama o especia 2
        public virtual void Especial2(Personagem alvo)
        {
            Console.WriteLine(nome + " usou especial em " + alvo.nome + "!");
        }
    }
}
