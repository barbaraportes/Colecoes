
Console.WriteLine("## Exercicio Arrays ##\n\n\n");


string[] nomes = new string[5];
double[] notas = new double[5];


Console.WriteLine("### ALUNOS ###\n");

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Informe o nome do aluno {i + 1}:");
    string? nome = Console.ReadLine();
    nomes[i] = nome;
}

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Informe a nota do aluno {i + 1}:");
    double nota = Convert.ToDouble(Console.ReadLine());
    notas[i] = nota;
}

foreach (string nome in nomes)
{
    Console.WriteLine("Alunos:");
    Console.Write($"{nome} - ");
}

Console.WriteLine();

var somaNotas = 0.0;
var totalNotas = notas.Count();
foreach (double nota in notas)
{
    Console.WriteLine("Notas:");
    somaNotas += nota;
    Console.Write($"{nota} - ");
}

Console.WriteLine($"\nMédia Aritmetica: \n{somaNotas/totalNotas} ");





Console.ReadKey();


