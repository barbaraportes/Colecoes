
Console.WriteLine("## Arrays ##\n");

//declaração de array
int[] numeros;

//alocação de memoria e inicialização
numeros = new int[10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};


string[] nomes = new string[5] { "Ana", "Maria", "Marta", "Joao", "Carlos"};

//forma simplificada
string[] nomes2 = { "Ana", "Maria", "Marta", "Joao", "Carlos" };

//Console.WriteLine(nomes[2]); //marta



//ACESSANDO ELEMENTOS COM FOR

//for (int i = 0; i < numeros.Length; i++)
//{
//    Console.WriteLine($"Elementos de indice {i} - {numeros[i]}\n");
//}


//for (int i = 0;i < nomes.Length; i++)
//{
//    Console.WriteLine($"Elementos de indice {i} - {nomes[i]}\n");
//}



//ACESSANDO ELEMENTOS COM FOREACH


foreach (int numero in numeros)
{
    Console.WriteLine(numero);
}

foreach (string nome in nomes)
{
    Console.WriteLine(nome);
}

Console.ReadKey();



