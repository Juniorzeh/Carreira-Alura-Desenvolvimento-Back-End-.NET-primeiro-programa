/*
************
EXERCICIO02
***********

//Escrever uma função que a partir de dois números de ponto flutuante a e b exiba no console o resultado de suas quatro operações básicas (adição, subtração, divisão e multiplicação), utilizando interpolação de strings.


void ExibirQuatroOperacoes()
{
    float a = 5;
    float b = 9;

    float soma = a + b;
    float subtracao = a - b;
    float divisao = a / b;
    float multiplicacao = a * b;

    Console.WriteLine($"a + b = {soma}");
    Console.WriteLine($"a - b = {subtracao}");
    Console.WriteLine($"a / b = {divisao}");
    Console.WriteLine($"a * b = {multiplicacao}");
}

ExibirQuatroOperacoes();

//Criar uma lista de bandas vazia e adicionar suas bandas prediletas em seguida.

List<string> listaBandas = new List<string>();
listaBandas.Add("SlipKnot");
listaBandas.Add("Pink Floyd");
listaBandas.Add("Creed");
listaBandas.Add("Linkin Park");

//Utilizar a estrutura 'for' para mostrar todas as suas bandas preferidas, listadas na lista do exercício anterior, no console.

for (int i = 0; i < listaBandas.Count; i++)
{
    Console.WriteLine(listaBandas[i]);
}

//Criar um programa que calcula a soma de todos os elementos inteiros em uma lista.

List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };
int soma = 0;

foreach (int numero in numeros)
{
    soma += numero;
}

Console.WriteLine($"A soma dos elementos da lsita é: {soma}");

//Criar um programa que calcula a média dos elementos de ponto flutuante em uma lista.

List<double> numeros01 = new List<double> { 1.5, 2.5, 3.5, 4.5 };
double somar = 0;

foreach (double numero in numeros01)
{
    somar += numero;
}

double media = soma / numeros01.Count;
Console.WriteLine($"A média dos elementos da lista é: {media}");

//Desenvolver um programa que exibe a tabuada de um número.

int numeroTabuada = 5;

for (int i = 0; i <= 10; i++)
{
    int resultados = numeroTabuada * i;
    Console.WriteLine($"{numeroTabuada} x {i} = {resultados}");
}

//Desenvolver uma calculadora simples que realiza as quatro operações básicas, a partir dado dois numeros e um operador.

double numero01 = 4;
double numero02 = 5;
char operacao = '+';

double resultado = 0;

switch (operacao)
{
    case '+':
        resultado = numero01 + numero02;
        break;
    case '-':
        resultado = numero01 - numero02;
        break;
    case '/':
        resultado = numero01 / numero02;
        break;
    case '*':
        resultado = numero01 * numero02;
        break;
    default:
        Console.WriteLine("OOppeerração inválida. ");
        return;
}

Console.WriteLine($"Resultado da operação: {resultado}");


************
EXERCICIO02
************


using System;

Criar um programa que permita ao usuário inserir o nome do aluno e suas notas, e em seguida calcule e exiba a média das notas.


Dictionary<string, List<double>> notasAlunos = new Dictionary<string, List<double>>();
notasAlunos["João"] = new List<double> { 8.5, 9.0, 7.5 };
notasAlunos["Maria"] = new List<double> { 7.0, 8.0, 6.5 };

foreach (var aluno in notasAlunos)
{
    double soma = 0;
    for (int i = 0; i < aluno.Value.Count; i++)
    {
        soma += aluno.Value[i];
    }
    double media = soma / aluno.Value.Count;
    Console.WriteLine($"Média de {aluno.Key}: {media}");
}

Criar um programa que gerencie o estoque de uma loja. Utilize um dicionário para armazenar produtos e suas quantidades em estoque e mostre, a partir do nome de um produto, sua quantidade em estoque.

Dictionary<string, int> estoque = new Dictionary<string, int>
{
    { "camisetas", 50 },
    { "calças", 30 },
    { "tênis", 20 },
    // Adicione mais produtos conforme necessário
};

string produto = "camisetas";

if (estoque.ContainsKey(produto))
{
    Console.WriteLine($"Quantidade em estoque de {produto}: {estoque[produto]} unidades.");
}
else
{
    Console.WriteLine("Produto não encontrado no estoque.");
}

Crie um programa que implemente um quiz simples de perguntas e respostas. Utilize um dicionário para armazenar as perguntas e as respostas corretas.

Dictionary<string, string> perguntasERespostas = new Dictionary<string, string>
{
    { "Qual é a capital do Brasil?", "Brasília" },
    { "Quanto é 7 vezes 8?", "56" },
    { "Quem escreveu 'Romeu e Julieta'?", "William Shakespeare" },
    // Adicione mais perguntas e respostas conforme necessário
};

int pontuacao = 0;

foreach (var pergunta in perguntasERespostas)
{
    Console.WriteLine(pergunta.Key);
    Console.Write("Sua resposta: ");
    string respostaUsuario = Console.ReadLine();

    if (respostaUsuario.ToLower() == pergunta.Value.ToLower())
    {
        Console.WriteLine("Correto!\n");
        pontuacao++;
    }
    else
    {
        Console.WriteLine($"Incorreto. A resposta correta é: {pergunta.Value}\n");
    }
}

Console.WriteLine($"Pontuação final: {pontuacao} de {perguntasERespostas.Count}");


Criar um programa que simule um sistema de login utilizando um dicionário para armazenar nomes de usuário e senhas.
Dictionary<string, string> usuarios = new Dictionary<string, string>
{
    { "user1", "senha123" },
    { "user2", "abc456" },
    // Adicione mais usuários conforme necessário
};

string nomeUsuario = "user1";
string senha = "senha123";

if (usuarios.ContainsKey(nomeUsuario) && usuarios[nomeUsuario] == senha)
    Console.WriteLine("Login bem-sucedido!");
else
    Console.WriteLine("Nome de usuário ou senha incorretos.");
*/
