using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal
{
    class Jogo
    {
        //Variavel pra add o nome ao personagem no metodo
        string nome;
        //criação do jogador, inimigos e outros
        Personagem Jogador;
        Batalha batalha = new Batalha();
        Inimigos Ladino = new Ladino();
        Inimigos Javali = new Javali();
        Inimigos Sentinelas = new Sentinelas();
        Inimigos Bardo = new Bardo();
        Inimigos Golem = new Golem();
        Inimigos Esqueletoes = new Esqueletoes();
        Inimigos Necromante = new Necromante();

        //metodo que contem o jogo
        public void Jogar()
        {
            Console.WriteLine("Olá Jogador, bem vindo ao Jogão");

            //salvar o nome do jogador
            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
            //deixa tudo minusculo 
            nome = nome.ToLower();
            //muda só a primeira letra pra maiusculo
            nome = char.ToUpper(nome[0]) + nome.Substring(1);

            //cria o jogador
            Jogador = CriaPersonagem.Criacao(nome);

            //história
            Console.WriteLine("APERTE ENTER PARA COMEÇAR O JOGO");
            Console.Write("\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.Write("Continuar...");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Acordado na cama, após uma noite bebendo numa taverna proxima, " + nome + " se prepara para encotrar seu amigo Noah.");
            Console.WriteLine("Eles haviam se conhecido alguns anos antes, em um dos shows de Noah. Os jovens logo se deram bem e entre bebidas, ");
            Console.WriteLine(nome + " foi surpreendido com uma proposta: recuperar um dado de Nimb.");
            Console.Write("\n\n\n\n\n\n\n\n\n\n");
            Console.Write("Continuar...");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine(nome + " foi despertado de seu devaneio com o som de batidas na porta, era Noah. \n");
            Console.WriteLine("- Olá velho amigo, por onde andou? - Disse " + nome);
            Console.WriteLine("- Estava a procura dos trigemeos do bosque, fontes disseram que eles estão com o talisma de Thyatis.");
            Console.WriteLine("- Quem são eles?");
            Console.WriteLine("- São fanaticos religiosos que roubaram o templo de Thyatis. Segundo minhas fontes eles pretendem ir pra ");
            Console.WriteLine("Galrasia. - Explicou Noah");
            Console.Write("\n\n\n\n\n\n");
            Console.Write("Continuar...");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("- O que eles pretendem fazer com isso? - " + nome + " indagou curioso");
            Console.WriteLine("- Eles fazem parte de uma seita que quer trazer Sszzaas de volta a Arthon. Acreditam que esse talisma");
            Console.WriteLine(" tem propriedades magicas que faram Sszzaas se libertar da maldição que o aprisiona.");
            Console.WriteLine("- Certo, e você precisa dos meus trabalhos, isso?! Noah...");
            Console.WriteLine("- Isso mesmo, meu amigo. Preciso que você encontre-os e pegue o talisma, mas fique tranquilo, eu mesmo irei");
            Console.WriteLine(" dar um fim nele.");
            Console.WriteLine("- E onde eles estão?");
            Console.WriteLine("- Acredito que estejam na floresta, indo em direção a Malpetrim, onde devem realizar o ritual.");
            Console.Write("\n\n\n\n\n");
            Console.Write("Continuar...");
            Console.ReadLine();
            Console.Clear();
           
            Console.WriteLine("Os dois amigos combinaram de se encontrar em Malpetrim dentro de 3 dias. Até lá, " + nome + " já teria");
            Console.WriteLine(" concluido sua missão.\n");
            Console.WriteLine(nome + " se dirigiu em direção a floresta.");
            Console.Write("\n\n\n\n\n\n\n\n\n");
            Console.Write("Continuar...");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Logo no inicio da floresta " + nome + " enontra outro viajante aparentemente perdido.");
            Console.WriteLine("Quando foi falar com ele foi surprendido pelo o viajante que levou seu mapa. o viajante correu a dentro da floresta.");
            Console.WriteLine(nome + " correu tanto quanto o viajante e conseguiu encurralá-lo entre árvores e pedras.");
            Console.WriteLine("- Devolva o que roubou! - Gritou " + nome);
            Console.Write("\n\n\n\n\n\n\n\n\n");
            Console.Write("Continuar...");
            Console.ReadLine();
            Console.Clear();

            //chama as batalhas e a história
            batalha.Batalhar(Jogador, Ladino);
            Console.Clear();

            Console.WriteLine("Mesmo no chão, o bandido dirige sua fala a " + nome);
            Console.WriteLine(" - Sei o que esta a procurar, mas comigo não está. Continue a andar e talvez o encontrará. Tome seu mapa de volta, ");
            Console.WriteLine("vai precisar.");
            Console.Write("\n\n\n\n\n\n\n\n\n\n");
            Console.Write("Continuar...");
            Console.ReadLine();
            Console.Clear();
            
            Console.WriteLine("Indo cada vez mais dentro da floresta, sente que esta sendo observado por algum bicho semelhante a um porco com chifres.");
            Console.WriteLine("Misteriosamente, é atacado pelo o mesmo. ");
            Console.Write("\n\n\n\n\n\n\n\n\n\n\n");
            Console.Write("Continuar...");
            Console.ReadLine();
            Console.Clear();

            batalha.Batalhar(Jogador, Javali);
            Console.Clear();

            Console.WriteLine(nome + "achou injusta a batalha, pois achava que o animal estava só defendendo seu espaço de viver.");
            Console.WriteLine("Ja escurecendo, " + nome + " segue seu caminho preocupado: olhando o mapa, olhando em volta, olhando a frente.");
            Console.WriteLine("A frente vê uma concentração de luzes, sem saber de quem são. E ouve murmúrios.");
            Console.WriteLine("Mesmo assim, " + nome + " continua a andar e tenta fazer a volta por esse espaço.");
            Console.WriteLine(nome + "ouve seu nome nesses múrmurios. Curioso, ele vai atras das vozes.");
            Console.WriteLine("E logo percebe que elas estão vindo do espaço das luzes, avistando 3 sentinelas." );
            Console.WriteLine(nome +", para previnir, se prepara para combate.");
            Console.Write("\n\n\n\n\n\n");
            Console.Write("Continuar...");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("- Olá, sei que esta a procura de nós, pena que nós o encontramos primeiro. Vai lamentar por isso. ");
            Console.WriteLine("- O quê? Como? - Responde " + nome + " assustado");
            Console.WriteLine("- Não se preocupe, estamos te observando desde que entrou na floresta, vimos e ouvimos o que fez e falou.");
            Console.WriteLine("- Então sabem o que eu quero?");
            Console.WriteLine("- Sim, venha pegar. - O primeiro Sentinel falou");
            Console.Write("\n\n\n\n\n\n\n\n");
            Console.Write("Continuar...");
            Console.ReadLine();
            Console.Clear();

            batalha.Batalhar(Jogador, Sentinelas);
            Console.Clear();

            Console.WriteLine(nome + " mal derrotou o primeiro Sentinela e o segundo veio em sua direção.");
            Console.Write("\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.Write("Continuar...");
            Console.ReadLine();
            Console.Clear();

            batalha.Batalhar(Jogador, Sentinelas);
            Console.Clear();

            Console.WriteLine(nome + " segue ao ataque do ultimo Sentinela.");
            Console.WriteLine("- Entregue o talisma agora!");
            Console.Write("\n\n\n\n\n\n\n\n\n\n\n");
            Console.Write("Continuar...");
            Console.ReadLine();
            Console.Clear();

            batalha.Batalhar(Jogador, Sentinelas);
            Console.Clear();

            Console.WriteLine("Antes de cair desmaido, o Sentinela olha para " + nome + "e diz:");
            Console.WriteLine("- Você é um forte oponente, mas o pior ainda esta por vir, você ficará surpreso com suas escolhas.");
            Console.Write("\n\n\n\n\n\n\n\n\n\n\n");
            Console.Write("Continuar...");
            Console.ReadLine();
            Console.Clear();
        
            Console.WriteLine("Após a luta com sentinelas "+ nome + "esta cansado, ainda preocupado, porém realizado de ter pego o talisma de ");
            Console.WriteLine("Thyatis. E só pensa em chegar logo em Malpetrim.");
            Console.WriteLine("Seguindo o mapa, logo vê que esta perto, 1 dia de viagem.");
            Console.WriteLine("No decorrer da viagem ouve uma voz e fica feliz por ouví-la.");
            Console.WriteLine("A voz era Noah.");
            Console.Write("\n\n\n\n\n\n\n\n");
            Console.Write("Continuar...");
            Console.ReadLine();
            Console.Clear();
       
            Console.WriteLine("- Ola, meu bom amigo, tudo certo? - Pergunta Noah");
            Console.WriteLine("- Oi, que bom vê-lo, apesar de alguns obstáculos no caminho, tudo certo. Consegui o talisma. - Respondeu " + nome);
            Console.WriteLine("- Ótimo. Me entregue, ai vamos para Malpetrim junstos.");
            Console.WriteLine(nome + " perceber algo errado e indaga o amigo.");
            Console.WriteLine("Como me encontrou aqui Noah?");
            Console.WriteLine("Noah não responde e pede novamente para que ele entregue o talisma.");
            Console.Write("\n\n\n\n\n\n\n");
            Console.Write("Continuar...");
            Console.ReadLine();
            Console.Clear();
          
            Console.WriteLine("- E por quê está aqui? - Insiste " + nome);
            Console.WriteLine("Noah aparenta estar brabo e exige o talisma.");
            Console.WriteLine("- Por quê quer tanto esse talisma e logo agora?");
            Console.WriteLine("- " + nome + ", se não me entregar, sabemos o que vai acontecer.");
            Console.WriteLine(nome + " não entre o talisma, e nesse momento Noah se mostra ser quem é... Um traidor.");
            Console.Write("\n\n\n\n\n\n\n\n");
            Console.Write("Continuar...");
            Console.ReadLine();
            Console.Clear();

            batalha.Batalhar(Jogador, Bardo);
            Console.Clear();

            Console.WriteLine("Com noah derrotado, " + nome + " ficou íntrigado com a situação e se pergunta se não foi ele a planaejar todo esse percurso.");
            Console.WriteLine("Distraído com todo o acontecido é pego por um Golem que, do nada, o prensa contra uma arvore.");
            Console.WriteLine(nome + " logo consegue se libertar e só pensa em destruir o que vir pela sua frente.");
            Console.Write("\n\n\n\n\n\n\n\n\n\n");
            Console.Write("Continuar...");
            Console.ReadLine();
            Console.Clear();

            batalha.Batalhar(Jogador, Golem);
            Console.Clear();

            Console.WriteLine(nome + "sente obstinado.Ele só quer chegar Malpetrim com o talisma em segurança. E nada e nem ninguém vai impedi-lo.");
            Console.WriteLine("Mesmo que com raiva no olhar, dois indivíduos esqueléticos o abordam.");
            Console.WriteLine("Um deles o segura, enquanto o outro procura o talisma nos seus pertences e consegue pegar. ");
            Console.WriteLine(nome + " consegue se soltar e ataca o primeiro equeleto.");
            Console.Write("\n\n\n\n\n\n\n\n\n");
            Console.Write("Continuar...");
            Console.ReadLine();
            Console.Clear();

            batalha.Batalhar(Jogador, Esqueletoes);
            Console.Clear();

            Console.WriteLine("Enquanto a batalha acontecia o outro esqueleto fugia com o talisma.");
            Console.WriteLine(nome + "derrota o primeiro esqueleto e persegue o outro.");
            Console.WriteLine("O esqueleto chega a um lugar suspeito e sombrio.E vê o esqueleto entregar o talisma a um tipo de ocultista.");
            Console.WriteLine(nome + "não sabe o que fazer. Apenas se concentra e invade o lugar.");
            Console.WriteLine("Na entrada estava o segundo esqueleto, preparado para enfrentar " + nome);
            Console.Write("\n\n\n\n\n\n\n\n");
            Console.Write("Continuar...");
            Console.ReadLine();
            Console.Clear();

            batalha.Batalhar(Jogador, Esqueletoes);
            Console.Clear();

            Console.WriteLine("Em meio aos sons da batalha o ocultista aparece.");
            Console.WriteLine("- Devolva o que roubou de mim. - Grita " + nome);
            Console.WriteLine("- Haha, você realmente espera que eu devolva? Você sabe quem sou?");
            Console.WriteLine(nome + " não fazia ideia de que fosse um dos mais poderosos necromantes que havia na região.");
            Console.WriteLine("Não me importa quem é você, eu vou derrotá-lo. - Retruca " + nome);
            Console.Write("\n\n\n\n\n\n\n\n");
            Console.Write("Continuar...");
            Console.ReadLine();
            Console.Clear();
            
            batalha.Batalhar(Jogador, Necromante);
            Console.Clear();

            Console.WriteLine(nome + " vence o poderoso necromante recupera o talisma e impede a porra toda. E finalmente chega Malpetrim.");
            Console.Write("\n\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.Write("Continuar...");
            Console.ReadLine();
            Console.Clear();

            Console.ReadLine();
        }
    }
}
