
using System.Collections;

Console.WriteLine("## ArrayList ##\n");

////modo 1
//ArrayList lista = new();
//lista.Add("Paulo");
//lista.Add(4.5);
//lista.Add(5);
//lista.Add(true);
//lista.Add(" ");
//lista.Add(null);


////modo 2
//var lista2 = new ArrayList() { "Paulo", 4.5, 5, true, " ", null};

//-------------------------------------------------------------

//ADICIONAR ELEMENTOS

//METODO ADD - ADICIONA AO FINAL DA LISTA
//var lista = new ArrayList() { "Maria", 5, true, " ", null};
//lista.Add(3.5);

////METODO INSERT - ADICIONA NO INDICE QUE VC SELECIONA
//lista.Insert(2, "Paulo");

////-------------------------------------------------------------

////ADICIONAR COLEÇÃO DE ELEMENTOS
////Metodo AddRange e InsertRange
//var lista = new ArrayList() { "Maria", 5, true};

//int[] array1 = { 1, 2, 3 };

//lista.AddRange(array1);
//lista.InsertRange(2, array1);

////-------------------------------------------------------------

////REMOVER ELEMENTOS

//var lista2 = new ArrayList() { "Ana", 5, true, " ", null, 1.1, "Ze", 3, 9, 0 };

////Método Remove - remove a primeira ocorrência do elemento
//lista.Remove(null);

////Metodo RemoveAt - remove o elemento do indice especificado
//lista.RemoveAt(4);

////Metodo RemoveRange - remove, a partir do indice 0, 2 elementos
//lista.RemoveRange(0, 2);

////-------------------------------------------------------------

////VERIFICAR SE O ELEMENTO ESTA NA COLEÇÃO

//var listaContains = new ArrayList() { "Maria", 5, true, 4.5, null, DateTime.Now };

////Método Contains - retorna true se o elemento existe na coleção, caso contrario, retorna false
//var res1 = lista.Contains(5);               //true
//var res2 = lista.Contains("Mari");          //false

//Console.WriteLine(lista.Contains(null));    //true



//Metodo Sort - Ordena em ordem ascendente
var lista = new ArrayList() { "Maria", "Ana", "Zilda", "Barbara", "Diná"};

Console.WriteLine("\nArrayList Original \n");
foreach (var item in lista)
{
    Console.Write($"{item} ");
}

lista.Sort();

Console.WriteLine("\nArrayList Ordenado \n");
foreach (var item in lista)
{
    Console.Write($"{item} ");
}

//Metodo Clear - remove todos os elementos sem alterar capacidade
lista.Clear();

Console.WriteLine($"\n\nLista de elemento depois do Clear possui {lista.Count} elementos");


Console.ReadKey();

