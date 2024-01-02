
Console.WriteLine("## List ##\n");
//coleção de objetos fortemente tipados que podem ser acessados usando um indice que inicia em 0
//possui métodos para classificar, pesquisar, modificar e manipular listas

////modo 1
//List<string> lista = new();
//lista.Add("Paulo");
//lista.Add("Maria");
//lista.Add("Bia");
//lista.Add("Pedro");

////modo 2
//List<string> lista2 = new() { "Paulo", "Maria", "Bia", "Pedro"};
//Console.WriteLine(lista2[0]);

//-------------------------------------------------

//ADICIONAR ELEMENTOS

var lista = new List<string>() { "Maria", "Ze", "Barbara"};
//lista.Add("Marta");
//lista.Insert(2, "Duda");
string[] array1 = { "Bia", "Jose", "Pedro"};

lista.AddRange(array1);

lista.InsertRange(1, array1);

//REMOVER ELEMENTOS

lista.Remove("Maria"); //remove o elemento
lista.RemoveAt(2);      //remove o indice 2

lista[0] = "Duda"; //altera o valor da lista do indice

//Console.WriteLine($"{lista.Count} itens\n\n");

//-------------------------------------------------

//LAÇO FOR

var lista2 = new List<string>() { "Paulo", "Maria", "Bia", "Pedro" };
lista2.Add("Barbara");

Console.WriteLine("FOR\n");

for (int i = 0; i < lista2.Count; i++)
{
    Console.WriteLine(lista2[i]);
}

Console.WriteLine();

//-------------------------------------------------

//LAÇO FOREACH

Console.WriteLine("FOREACH\n");

ExibirLista(lista2);

Console.WriteLine("\nCONTAINS\n");


//METODO CONTAINS

Console.WriteLine(lista2.Contains("Bia"));
Console.WriteLine(lista2.Contains("Duda"));

//SORT
Console.WriteLine("\nSORT\n");
Console.WriteLine("\nLista original\n");
ExibirLista(lista2);
lista2.Sort();
Console.WriteLine("\nLista ordenada\n");
ExibirLista(lista2);



Console.ReadKey();

static void ExibirLista(List<string> lista2)
{
    foreach (string nome in lista2)
    {
        Console.WriteLine(nome);
    }
}