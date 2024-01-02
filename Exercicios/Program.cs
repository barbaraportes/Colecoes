
Console.WriteLine("## Exercício 1 ##");


//1 - Crie um programa C# para armazenar os nomes de 10 frutas em um array unidimensional e a seguir realize
//as seguintes operações : Dados: Maça, Banana, Laranja, Uva, Manga, Pêra, Abacate, Mamão, Pêssego, Amora
//a- Exiba os nomes das frutas no console e a quantidade de elementos do array usando os laços for e foreach
//b- Exiba os nomes da segunda e da penúltima fruta no console
//c- Altere o nome da terceira fruta para Kiwi e da última fruta para Caqui e exiba o nome de todas as frutas



//Declara e inicializa o array de strings com nome de frutas
//Maça, Banana, Laranja, Uva, Manga, Pêra, Abacate, Mamão, Pêssego, Amora
string[] frutas = {
"Maça", "Banana", "Laranja", "Uva", "Manga", "Pêra", "Abacate", "Mamão", "Pêssego", "Amora"
};

//laço foreach
Console.WriteLine("\n\nlaço foreach");
foreach (var fruta in frutas)
{
    Console.Write($"{fruta} ");
}

//laço for
Console.WriteLine("\n\nlaço for");
for (int i = 0; i < frutas.Length; i++)
{
    Console.Write($"{frutas[i]} ");
}
Console.WriteLine($"\n\nA coleção frutas possui : {frutas.Count()} frutas");

//exibe a segunda e penúltima fruta
Console.WriteLine("\nNome da segunda e penúltima fruta");
Console.WriteLine($"\n Segunda   =>  {frutas[1]}");
Console.WriteLine($"\n Penúltima =>  {frutas[8]}");

//altera a terceira e última fruta
Console.WriteLine("\nAlterando o nome da terceira para Kiwi e da última fruta para Caqui...");
frutas[2] = "Kiwi";
frutas[9] = "Caqui";

Console.WriteLine("\n\nRelação de frutas com nomes alterados: \n");
foreach (var fruta in frutas)
{
    Console.Write($"{fruta} ");
}

Console.WriteLine("\n\nOrdenando a coleção de frutas com Array.Sort()");
Array.Sort(frutas);
foreach (var fruta in frutas)
{
    Console.Write($"{fruta} ");
}

Console.WriteLine("\n\nInvertendo a ordem da coleção");
Array.Reverse(frutas);
foreach (var fruta in frutas)
{
    Console.Write($"{fruta} ");
}

Console.ReadKey();