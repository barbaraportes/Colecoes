Console.WriteLine("## Exercício 3 ##");


//3 - Escreva um programa em C# que solicite ao usuário que informe o valor das notas, do tipo float , para 10
//alunos divididos em 2 grupos de 5 alunos cada. Armazene as informações em um array bidimensional e a
//seguir exiba no console a média aritmética de cada grupo de alunos (grupo1 e grupo2).


//define o número de grupos e a quantidade por grupo
int totalGrupo = 2;
int totalPorGrupo = 5;

//declara e inicializa um array bidimensional de floats 2 por 5
float[,] notas = new float[totalGrupo, totalPorGrupo];

//define os valores dos totais iniciais das notas
float totalGrupo1 = 0.0f, totalGrupo2 = 0.0f;

//exibie o título
Console.WriteLine("\nCálculo da média das notas de 2 grupos de alunos com 5 alunos cada\n");
Console.WriteLine("Array bidimensional => [2,5]\n");

// Recebe as notas via teclado e armazena no array bidimensional    
for (int i = 0; i < totalGrupo; i++)
{
    Console.WriteLine($"Informe nota do grupo {i + 1}");
    for (int j = 0; j < totalPorGrupo; j++)
    {
        Console.Write($"Nota : [{i},{j}] = ");
        notas[i, j] = Convert.ToSingle(Console.ReadLine());
    }
}

// Calcula a média para o grupo 1
// percorre o array 
for (int i = 0; i < totalPorGrupo; i++)
{
    //soma as notas do grupo 1
    totalGrupo1 += notas[0, i];
}

//exibe o resultado
Console.WriteLine($"\nMédia para o Grupo 1 : {totalGrupo1 / totalPorGrupo}");

// Calcula a média para o grupo 2
for (int i = 0; i < totalPorGrupo; i++)
{
    //soma as notas do grupo 2
    totalGrupo2 += notas[1, i];
}
//exibe o resultado
Console.WriteLine($"\nMédia para o Grupo 2 : {totalGrupo2 / totalPorGrupo}");
