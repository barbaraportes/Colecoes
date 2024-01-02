
Console.WriteLine("## Array Bidimensional ##\n");


//int[,] a = new int[2, 2] { { 20, 30 }, { 40, 50 } };
int[,] a = { { 20, 30 }, { 40, 50 } };

Console.WriteLine(a[0, 0]);
Console.WriteLine(a[0, 1]);
Console.WriteLine(a[1, 0]);
Console.WriteLine(a[0, 1]);



//ARRAY BIDIMENSIONAL COM LAÇO FOR


int[,] n = { 
                { 11, 22, 33 }, //  n[0,0] n[0,1] n[0,2]
                { 44, 55, 66 }, //  n[1,0] n[1,1] n[1,2]
                { 77, 88, 99}   //  n[2,0] n[2,1] n[2,2]
           };

Console.WriteLine("\nFOR\n");
for (int i = 0; i < n.GetLength(0); i++)
{
    for (int j = 0; j < n.GetLength(1); j++)
    {
        Console.Write($"{n[i, j]} ");
    }
    Console.WriteLine();
}


//ARRAY BIDIMENSIONAL COM LAÇO FOREACH
Console.WriteLine("\nFOREACH\n");
foreach (int x in n)
{
    Console.Write($"{x} ");
}


Console.ReadKey();



