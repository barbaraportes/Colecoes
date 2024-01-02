
Console.WriteLine("## Classe Array - Métodos Reverse, Sort e BinarySearch ##\n");


string[] nomes = { "Ana", "Maria", "Jose", "Carlos", "Marta"};

Console.WriteLine("\n\nExibindo o array original...");
ExibeArray(nomes);


Console.WriteLine("\n\nInvertendo a ordem do array...");
Array.Reverse(nomes);
ExibeArray(nomes);

Console.WriteLine("\n\nOrdenando o array...");
Array.Sort(nomes);
ExibeArray(nomes);


Console.WriteLine("\n\nLocalizando um item no array...");
Console.WriteLine("Informe o nome:");
string nome = Console.ReadLine();
var indice = Array.BinarySearch(nomes, nome); //(nome do array onde vai fazer a busca, o item que quer buscar) 

if (indice >= 0)
    Console.WriteLine($"\n{nome} foi encontrado com indice = {indice}");
else
    Console.WriteLine($"\n{nome} não foi encontrado");

ExibeArray(nomes);





Console.ReadKey();





static void ExibeArray(string[] nomes)
{
    foreach (var nome in nomes)
    {
        Console.Write($"{nome} ");
    }
}