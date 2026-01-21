// TuneScore
string mensagemDeBoasVindas = "Boas vindas ao TuneScore!";
//List<string> listaDasBandas = new List<string> { "SlipKnot", "Creed", "Linkin Park"};
Dictionary<string, List<int>> bandasRegistradas = new()
{
    { "Linkin Park", new List<int> { 10, 8, 6 } },
    { "The Beatles", new List<int>() }
};

void ExibirLogo()
{
    Console.WriteLine(@"

████████╗██╗░░░██╗███╗░░██╗███████╗░██████╗░█████╗░░█████╗░██████╗░███████╗
╚══██╔══╝██║░░░██║████╗░██║██╔════╝██╔════╝██╔══██╗██╔══██╗██╔══██╗██╔════╝
░░░██║░░░██║░░░██║██╔██╗██║█████╗░░╚█████╗░██║░░╚═╝██║░░██║██████╔╝█████╗░░
░░░██║░░░██║░░░██║██║╚████║██╔══╝░░░╚═══██╗██║░░██╗██║░░██║██╔══██╗██╔══╝░░
░░░██║░░░╚██████╔╝██║░╚███║███████╗██████╔╝╚█████╔╝╚█████╔╝██║░░██║███████╗
░░░╚═╝░░░░╚═════╝░╚═╝░░╚══╝╚══════╝╚═════╝░░╚════╝░░╚════╝░╚═╝░░╚═╝╚══════╝");
    Console.WriteLine("\n" + mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            MostrarBandasRegistradas();
            break;
        case 3:
            AvaliarUmaBanda();
            break;
        case 4:
            ExibirMediaDaBanda();
            break;
        case -1:
            Console.WriteLine("Tchau tchau :)");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    void RegistrarBanda()
    {
        Console.Clear();
        ExibirTituloDaOpcao("Registro de bandas");
        Console.Write("Digite o nome da banda que deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        bandasRegistradas.Add(nomeDaBanda, [1]);
        Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }

    void MostrarBandasRegistradas()
    {
        Console.Clear();
        ExibirTituloDaOpcao("Exibindo todas as bandas registradas");
        /*for (int i = 0; i < listaDasBandas.Count; i++) 
        {
            Console.WriteLine($"Banda: {listaDasBandas[i]}");
        }*/

        foreach(string banda in bandasRegistradas.Keys)
        {
            Console.WriteLine($"Banda: {banda}");
        }

        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void AvaliarUmaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        //Nesse trecho, utilizamos os colchetes para indexar o dicionário bandasRegistradas, usando a chave. Com essa construção,
        //nós acessamos os valores, que é uma lista de números inteiros. Por isso, podemos acionar diretamente o método Add() para inserir a nota.
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirOpcoesDoMenu();

    } else
    {
        VerificarExistenciaBanda(mensagemDeBoasVindas, bandasRegistradas, nomeDaBanda);
    }

    void VerificarExistenciaBanda(string mensagemDeBoasVindas, Dictionary<string, List<int>> bandasRegistradas, string nomeDaBanda)
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

void VerificarExistenciaBanda(string mensagemDeBoasVindas, Dictionary<string, List<int>> bandasRegistradas, string nomeDaBanda)
{
    Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
    Console.WriteLine("Digite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ExibirMediaDaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {//pegar todas as notas da banda e atribuir na variavel notasDaBanda
        List<int> notasDaBanda = bandasRegistradas[nomeDaBanda];
        Console.WriteLine($"\nA média da banda {nomeDaBanda} é {notasDaBanda.Average()}.");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal.");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        VerificarExistenciaBanda(mensagemDeBoasVindas, bandasRegistradas, nomeDaBanda);
    }
}

ExibirOpcoesDoMenu();
AvaliarUmaBanda();
ExibirMediaDaBanda();


