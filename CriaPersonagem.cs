using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal
{
    static class CriaPersonagem
    {
        //variavel que serve para resetar ou confirmar os ponto no do while
        static bool pontosConfirmar = false;
        //Variavel para controlar e informar a quantidade de pontos do jogador
        static int pontosTotal = 7;
        //Variavel para subtrair os pontos totais e adicionar ao jogador
        static int pontosGastos = 0;
        //Variavel para criar o personagem jogador de acordo com a escolha da classe
        static int escolha;

        public static Personagem Criacao(string nome)
        {
            Personagem Jogador;
            //switch de escolha de classe, onde irá criar o personagem do jogador de acordo com a classe escolhida 
            Console.WriteLine("\nEscolha a classe:");
            Console.WriteLine("\n[1 - Guerreiro] [2 - Mago] [3 - Swashbuckler]");
            //metodo para o jogador só conseguir digitar numeros (1 é o minimo e 3 o maximo)
            escolha = LerTeclado.intervalo(1, 3);
            Console.Clear();
            switch (escolha)
            {
                case 1:
                    Jogador = new Guerreiro(nome);
                    break;
                case 2:
                    Jogador = new Mago(nome);
                    break;
                case 3:
                    Jogador = new Swashbuckler(nome);
                    break;
                default:
                    return Jogador = new Guerreiro(nome);
            }


            int confirmarResetar;

            //laço DO que repete o processo até todos os pontos disponiveis serem gastos e o jogador confirmar sua escolha
            do
            {
                //condição que só permitirá o jogador colocar pontos nos atributos se tiver pontos disponiveis
                //colocar pontos nos atributos
                if (pontosTotal > 0)
                {
                    Jogador.status(pontosTotal, nome);
                    Console.Write("Quantas pontos deseja distribuir em força? ");
                    //metodo para o jogador só conseguir digitar numeros (0 é o minimo e pontosTotal é o maximo)
                    pontosGastos = LerTeclado.intervalo(0, pontosTotal);
                    pontosTotal -= pontosGastos;
                    Jogador.Forca += pontosGastos;
                }
                

                Console.Clear();

                if (pontosTotal > 0)
                {
                    Jogador.status(pontosTotal, nome);
                    Console.Write("Quantas pontos deseja distribuir em destreza? ");
                    pontosGastos = LerTeclado.intervalo(0, pontosTotal);
                    pontosTotal -= pontosGastos;
                    Jogador.Destreza += pontosGastos;
                }

                Console.Clear();

                if (pontosTotal > 0)
                {
                    Jogador.status(pontosTotal, nome);
                    Console.Write("Quantas pontos deseja distribuir em inteligencia? ");
                    pontosGastos = LerTeclado.intervalo(0, pontosTotal);
                    pontosTotal -= pontosGastos;
                    Jogador.Inteligencia += pontosGastos;
                }

                Console.Clear();

                Console.Clear();

                Jogador.status(pontosTotal, nome);

                //condição que se não tiver mais pontos para investir, o jogador pode confirmar suas escolhas ou realocar seus pontos
                if (pontosTotal == 0)
                {
                    Console.WriteLine("\nDeseja confirmar ou resetar seus pontos? \n[1 - Confirmar] [2 - Resetar]");
                    confirmarResetar = LerTeclado.intervalo(1, 2);
                    if (confirmarResetar == 1)
                    {
                        pontosConfirmar = true;
                    }
                    else if (confirmarResetar == 2)
                    {
                        Jogador.Forca = Jogador.forcainicial;
                        Jogador.Destreza = Jogador.destrezainicial;
                        Jogador.Inteligencia = Jogador.inteligenciainicial;
                        pontosTotal = 7;
                        pontosGastos = 0;
                    }
                }
                Console.Clear();
            } while (pontosConfirmar == false);

            return Jogador;
        }
    }
}
