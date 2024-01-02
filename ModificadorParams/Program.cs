
Console.WriteLine("## Modificador Params ##\n\n");
Console.WriteLine("Soma de números inteiros\n");

//modo 1
int[] valores = {1, 2, 3, 10};
var resultado = Calcular.Soma(valores);
Console.WriteLine(resultado);

//modo 2
var resultado2 = Calcular.Soma(new int[] {10, 20, 30});
Console.WriteLine(resultado2);

//modo params
var resultado3 = Calcular.Soma(50, 20, 10);
Console.WriteLine(resultado3);






Console.ReadKey();


public class Calcular
{
    public static int Soma(params int[] numeros)
    {
        int total = 0;
        foreach (var numero in numeros)
        {
            total += numero;
        }
        return total;
    }
}
