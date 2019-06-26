using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal
{
    class Batalha
    {
        Personagem jogador;
        Inimigos inimigo;
        int escolha, ataque;
        int confirmarResetar;
        
        //metodo chamado para toda batalha
        public void Batalhar(Personagem jogador, Inimigos inimigo)
        {
            //variaveis para indicar os alvos
            this.jogador = jogador;
            this.inimigo = inimigo;
            bool jogar = true;

            while (jogar == true)
            {
                //chama os status do jogador e as escolhas de ataque
                Status();
                Console.WriteLine("Você está batalhando");
                Console.Write("\n\n\n\n\n\n\n\n\n\n");
                Console.WriteLine("[1 - SOCO]");
                Console.WriteLine("[2 - CHUTAR]");
                Console.WriteLine("[3 - CABEÇADA]");
                Console.WriteLine("[4 - ESPECIAL]");
                Console.WriteLine("[5 - ESPECIAL]");
                Console.Write("Escolha: ");
                escolha = LerTeclado.intervalo(1, 5);

                if (escolha == 1)
                {
                    jogador.Socar(inimigo);
                }
                else if (escolha == 2)
                {
                    jogador.Chutar(inimigo);
                }
                else if (escolha == 3)
                {
                    jogador.Cabecada(inimigo);
                }
                else if (escolha == 4)
                {
                    jogador.Especial(inimigo);
                }
                else
                {
                    jogador.Especial2(jogador);
                }
                Console.ReadLine();
                Console.Clear();
                //rola o dado do inimigo para ver qual ataque será usado
                Console.WriteLine("Ataque inimigo");
                ataque = Rolagem.Rola(5, 0);

                if (ataque == 1)
                {
                    inimigo.Socar(jogador);
                }
                else if (ataque == 2)
                {
                    inimigo.Chutar(jogador);
                }
                else if (ataque == 3)
                {
                    inimigo.Cabecada(jogador);
                }
                else if (ataque == 4)
                {
                    inimigo.Especial(jogador);
                }
                else
                {
                    inimigo.Especial2(jogador);
                }
                Console.ReadLine();
                Console.Clear();
                //condição para ver se o jogador venceu
                if (jogador.Vida > 0 && inimigo.Vida <= 0)
                {
                    Console.WriteLine(jogador.nome + " venceu!");
                    Console.ReadLine();
                    Console.Clear();
                    jogador.Vida = jogador.vidainicial;
                    inimigo.Vida = inimigo.vidainicial;
                    break;
                }
                //condição para ver se foi empate
                else if (jogador.Vida <= 0 && inimigo.Vida <= 0)
                {
                    Console.WriteLine("Empate!");
                    Console.ReadLine();
                    Console.Clear();
                    jogador.Vida = jogador.vidainicial;
                    break;
                }
                //condição para ver se o jogador perdeu
                else if (jogador.Vida <= 0 && inimigo.Vida > 0)
                {
                     Console.Clear();
                     Console.WriteLine("Você perde!");
                     Console.WriteLine(jogador.nome + ", você quer jogar novamente? ");
                     Console.Write("\n\n\n\n\n\n\n\n");
                     Console.WriteLine("[1 - Sim]");
                     Console.WriteLine("[2 - Não]");
                     Console.Write("Sua resposta: ");
                     confirmarResetar = LerTeclado.intervalo(1, 2);
                     Console.Clear();
                     if (confirmarResetar == 1)
                     {
                        jogar = true;
                     }
                     else if (confirmarResetar == 2)
                     {
                        jogar = false;
                     }
                     
                     jogador.Vida = jogador.vidainicial; // TESTE SE ESTA RESETANDO A VIDA
                }
            }
        }

        //chama os status
        public void Status()
        {
            Console.WriteLine(jogador.nome + " - Vida: " + jogador.Vida + " / FOR: " + jogador.Forca + " / DES: " + jogador.Destreza + " / INT: " + jogador.Inteligencia);
            Console.WriteLine(inimigo.nome + " - Vida: " + inimigo.Vida + " / Dano: " + inimigo.Dano + " / Arm: " + inimigo.Armadura);
        }
    }
}
