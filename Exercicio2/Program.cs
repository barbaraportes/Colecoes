Console.WriteLine("## Exercício 2 ##");


//2- Crie um programa em C# que sirva para pesquisar um array de valores inteiros. Para fazer isso, siga estas
//etapas a seguir

//a-) Solicite via teclado o número de valores do array (deve ser um número inteiro)
//b-) Declare e inicialize um array de inteiros com a quantidade de números inteiros informados
//c-) Solicite ao usuário um valor de um número inteiro a procurar no array
//d-) Exiba se o número informado existe no array de inteiros ou não
//e-) Repita até que o texto ‘fim’ seja inserido via teclado
//d- Ordene a coleção de frutas na ordem ascendente
//e- Exiba no console a coleção de nomes de frutas na ordem inversa


Console.WriteLine("\nInforme o número de elementos inteiros no array");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nInforme os valores dos números no array\n");

int[] numeros = new int[x];

for (int i = 0; i < x; i++)
{
    Console.Write($"numeros[{i}] = ");
    numeros[i] = Convert.ToInt32(Console.ReadLine());
}

string numero;

Console.WriteLine("\nInforme o número a localizar no array (Tecle [fim] para encerrar) : \n");
do
{
    numero = Console.ReadLine();

    if (numero != "fim")
    {
        int valor = Convert.ToInt32(numero);

        if (Array.BinarySearch(numeros, valor) >= 0)
        {
            Console.WriteLine($"\nO número {numero} Existe no array");
        }
        else
        {
            Console.WriteLine($"\nO número {numero} NÃO Existe no array");
        }
    }
}
while (numero != "fim");