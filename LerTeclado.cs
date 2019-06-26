using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal
{
    static class LerTeclado
    {
        //metodo staic para fazer o usario digitar apenas numeros dentro de um intervalo escolhido por nós
        public static int intervalo(int menorValor, int maiorValor)
        {           
            bool valido = false;
            int numero;
            //laço DO que vai executar até que o usario digite uma opção valida
            do
            {
                string texto = Console.ReadLine();
                //tentar converter a entrada
                valido = int.TryParse(texto, out numero);
                //verifica se a condicao de conversao será valida (intervalo e tipo de caracter)
                valido = valido == true && numero >= menorValor && numero <= maiorValor;
                //condicao que mostra se a opcao foi invalida
                if (valido == false)
                {
                    Console.WriteLine("Você digitou uma opção invalida!");
                    Console.Write("Digite novamente: ");
                }
            } while (valido == false);
            //retorna a entrada
            return numero;
        }
    }
}
