//**Desafio: Sistema simples de notas**

//1. Peça para o usuário informar quantas notas quer cadastrar.
//2. Armazene em um array.
//3. Mostre:
//    -A média geral
//    - A maior e menor nota
//    - Quantas notas foram acima de 7

// Recebe as notas em string e as insere em uma array de strings
Console.WriteLine("Informe as notas separadas por vírgula:");
Console.WriteLine("(só aceita números inteiros)");
String notas = Console.ReadLine();
String[] arrayNotasString = notas.Split(",");

// Transforma essa array em uma array de doubles
double[] notasNumericas = Array.ConvertAll(arrayNotasString, double.Parse);

// Cria a função para calcular a média, maior, menor e quantas notas foram maiores do que 7
(double media, double maior, double menor, int maioresDeSete) Calcular(double[] notasNumericas)
{
    double media = notasNumericas.Sum() / notasNumericas.Length;

    double maior = notasNumericas.Max();
    
    double menor = notasNumericas.Min();

    int maioresDeSete = 0;

    for (int i = 0; i < notasNumericas.Length; i++)
    {
        if (notasNumericas[i]>7)
        {
            maioresDeSete += 1;
        }
    }

    return (media, maior, menor, maioresDeSete);
}

// Cria uma variavel para o resultado e o imprime no console
var resultado = Calcular(notasNumericas);

Console.WriteLine($"Média: {resultado.media}");
Console.WriteLine($"Maior nota: {resultado.maior}");
Console.WriteLine($"Menor nota: {resultado.menor}");
Console.WriteLine($"Notas acima de 7: {resultado.maioresDeSete}");
