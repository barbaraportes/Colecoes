
using Indexadores;

Console.WriteLine("## Indexadores ##\n\n");

Time time = new Time();

//atribuir valores = get
time[1] = "Palmeiras";
time[3] = "Santos";
time[5] = "Sao Paulo";
time[7] = "Vasco";
time[-1] = "Flamengo";
time[1000] = "Bahia";

//obtendo valores = set
string valor1 = time[1];
string valor2 = time[3];
string valor3 = time[5];
string valor4 = time[7];
string valor5 = time[-1];
string valor6 = time[-3];

//exibir
Console.WriteLine(valor1);
Console.WriteLine(valor2);
Console.WriteLine(valor3);
Console.WriteLine(valor4);
Console.WriteLine(valor5);
Console.WriteLine(valor6);



Console.ReadKey();






