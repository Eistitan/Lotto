//ZahlenArrayErstellung
using System;
int i = 0;
int[] zahlen = new int[49];

for (i = 0; i < 49; i++)
{
    zahlen[i] =(i+1);
}

//ZahlEingabe
Console.WriteLine("Geben Sie 6 Zahlen ein:\n");
int[] einZahlen = new int[6];
int einSupp;

i = 0;
string strZahl;
int intZahl;
bool boolZahl = false;

do
{
    Console.WriteLine($"Die Zahl Nr.{1 + i}: ");
    strZahl=(Console.ReadLine());
    if (boolZahl = Char.IsDigit(strZahl, 0))
    {   
        intZahl = Convert.ToInt32(strZahl);
        
        if (intZahl >= 1 && intZahl <= 49 )
        {
            bool doppler = false;
            doppler =Array.Exists(einZahlen, ele => ele == intZahl);
            if (doppler==false)
            {
                einZahlen[i] = intZahl;
                i++;
            }
            else
            {
                Console.WriteLine($"Die Zahl {intZahl} wurde schon gewählt.\n");
            }
        }
        else
        {
            Console.WriteLine("Falscher Wert!\n");
        }
    }else
    {
        Console.WriteLine("Hier ist Lotto, keine ABC-Lerngruppe!\n");
    }
    
} while (i<6);
Array.Sort(einZahlen);

Console.WriteLine("\nDie gewählten Zahlen sind:\n");
foreach (var item in einZahlen)
{
    Console.WriteLine(item);
}

//ZahlenZiehung
Random rnd = new Random();
int[] lottozahlen = new int[6];
int counter = 49;

for (i = 0; i < 6; i++)
{
    var rndIndex = rnd.Next(0, counter); //der Obere Wert ist Excluding
    lottozahlen[i] = zahlen[rndIndex];
    zahlen =zahlen.Where((val, idx) => idx != rndIndex).ToArray();
    counter--;
}
Array.Sort(lottozahlen);
Console.WriteLine("\nDie Lottozahlen sind: \n");

foreach (var item in lottozahlen)
{
    Console.WriteLine(item);
}

int match = 0;
for ( i = 0; i < 6; i++)
    {
     if (lottozahlen[i] == einZahlen[i])
        {
            match++;
            Console.WriteLine($"\nDie Zahl {einZahlen[i]} wurde richtig getippt!");
         }
}
Console.WriteLine($"\nDie Anzahl der Treffer ist {match}.\n");
    