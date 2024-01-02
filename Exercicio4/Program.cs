using System.Collections;
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("## Exercício 4 ##");

//4 - Crie um programa C# que usa uma ArrayList para armazenar uma lista de objetos pessoas.
//a-) Primeiro crie uma classe chamada Pessoa.cs com duas propriedades (nome e idade) e um método Exibir()
//para imprimir o nome e a idade;
//b-) A seguir crie uma ArrayList e solicite a informação dos nomes e idades de 3 pessoas via teclado
//armazenando as informações na ArrayList.
//c-) A seguir exiba no console a lista das pessoas com nome e idade
//d-) Inclua mais dois objetos Pessoa na lista e exiba a nova lista de pessoas
//e-) Remova o último elemento da coleção e exiba a lista completa
//Use seguintes dados iniciais: Ana, 22 - Diná, 21 - Maria, 19
//Ao incluir os objetos pessoa use os dados : Jaime,20 - Tânia,18





ArrayList lista = new ArrayList();

Console.WriteLine("\nInforme o nome e idade de 3 pessoas...\n");
int total = 3;
for (int i = 0; i < total; i++)
{
Console.Write("\nNome : ");
string nome = Console.ReadLine();
Console.Write("Idade : ");
int idade = int.Parse(Console.ReadLine());

lista.Add(new Pessoa()
{
Nome = nome,
Idade = idade
});
}

ListaPessoas(lista);

Console.WriteLine("\nIncluindo mais duas pessoas na lista...");

Pessoa jaime = new Pessoa() { Nome = "Jaime", Idade = 20 };
Pessoa tania = new Pessoa() { Nome = "Tânia", Idade = 18 };

lista.Add(jaime);
lista.Add(tania);

ListaPessoas(lista);

Console.WriteLine("\nRemovendo o último elemento...");
lista.RemoveAt(lista.Count - 1);
ListaPessoas(lista);

Console.ReadLine();

static void ListaPessoas(ArrayList lista)
{
Console.WriteLine("\nLista de pessoas atual...\n");
foreach (Pessoa pessoa in lista)
{
Console.WriteLine(pessoa.Exibir());
}
}

public class Pessoa
{
    public string? Nome { get; set; }
    public int Idade { get; set; }
    public string Exibir()
    {
        return Nome + " - " + Idade;
    }
}