using Exercicio5;

Console.WriteLine("## Exercício 5 ##\n");

//5 - Dada uma classe Produto contendo duas propriedades : Nome(string) e Preco(decimal). Crie uma lista
//de objetos do tipo Produto usando os seguinte dados:
//Clips, R$ 3,95 - Caneta, R$ 5,99 - - Lápis, R$ 4,15 - Estojo, R$ 6,99 e Caderno, R$ 7,55
//A seguir realize as seguintes operações na lista de objetos Produto criada :
//1 - Crie um método para exibir a relação de produtos , a soma total dos preços dos produtos, a média do
//preço dos produtos e a quantidade de produtos na lista
//2- Inclua na lista o seguinte produto : Mochila, R$ 22,44 e exiba novamente a lista de produtos
//3- Ordene a lista pelo nome do produto e exiba a lista ordenada
//4- Obtenha e exiba no console os produtos com preço inferior a R$ 5,00
//5- Localize na lista o produto com nome Estojo



List<Produto> Produtos = FonteDados.GetProdutos();
ExibirProdutos(Produtos);

Console.WriteLine("\nIncluindo um novo produto : Mochila (R$ 22,44)");
Produto mochila = new Produto() { Nome = "Mochila", Preco = 22.44m };
Produtos.Add(mochila);
ExibirProdutos(Produtos);

Console.WriteLine("\nLocalizando o produto : Estojo ...");
var produto1 = Produtos.Find(n => n.Nome.Equals("Estojo"));
Console.WriteLine($"\nProduto : {produto1.Nome} - {produto1.Preco}");

Console.WriteLine("\nOrdenando o produto por nome...");
//Produtos.Sort();
var listaOrdenada = Produtos.OrderBy(n => n.Nome).ToList();
ExibirProdutos(listaOrdenada);

Console.WriteLine("\nLocalizando e exibindo produtos com preço inferior a R$ 5,00");
var ProdutosMenorCinco = Produtos.FindAll(n => n.Preco <= 5.00m);
Console.Write("\nProdutos com preço menor que R$ 5.00\n");
foreach (var item in ProdutosMenorCinco)
{
    Console.WriteLine($"{item.Nome}\t{item.Preco}");
}

Console.ReadKey();

static void ExibirProdutos(List<Produto> Produtos)
{
    Console.WriteLine("\nRelação de Produtos\n");
    Console.WriteLine("\nNome\tPreço");

    var somaPreco = 0.0m;
    foreach (var item in Produtos)
    {
        Console.WriteLine($"{item.Nome}\t{item.Preco}");
        somaPreco += item.Preco;
    }

    var mediaPreco = somaPreco / Produtos.Count();
    Console.WriteLine($"\nMédia dos preços : {Math.Round(mediaPreco, 2)}");
    Console.WriteLine($"\nTotal de Produtos : {Produtos.Count()}");
}