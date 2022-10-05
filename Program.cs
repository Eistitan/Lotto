//ZahlenArrayErstellung
using System;

int[] zahlen = new int[49];

for (int i = 0; i < 49; i++)
{
    zahlen[i] =(i+1);
}

//foreach (var item in zahlen)
//{
//    Console.WriteLine(item);
//}
//Console.WriteLine("\n\n");


//ZahlenZiehung
Random rnd = new Random();
int[] lottozahlen = new int[6];
int counter = 48;

for (int i = 0; i < 6; i++)
{
    var rndIndex = rnd.Next(0, counter);
    lottozahlen[i] = zahlen[rndIndex];
    zahlen =zahlen.Where((val, idx) => idx != rndIndex).ToArray();
    counter--;
}

Array.Sort(lottozahlen);
Console.WriteLine("Die Lottozahlen sind: \n");


foreach (var item in lottozahlen)
{
    Console.WriteLine(item);
}
int rndSupp = rnd.Next(0, 9);
Console.WriteLine($"\nDie Superzahl ist {rndSupp}.");

//Console.WriteLine("\n\n");

//foreach (var item in zahlen)
//{
//    Console.WriteLine(item);
//}
Console.WriteLine("\nLeider schon wieder verloren. ");
