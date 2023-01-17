//using ArrayÜbungen;

//Auto auto1 = new Auto();
//Auto auto2 = new Auto();
//auto1.Raeder = 10;
//auto2.Raeder = 13;

//auto1.SetReader(11);
//auto2.SetReader(13);

//int raeder = auto1.Raeder;

//auto1.Beschleunigen(5);
//auto1.Beschleunigen(10);
//auto1.Beschleunigen(5);
//auto1.Beschleunigen(20);


int zeilen = 21;
int[] zahl = new int[zeilen];
var random = new Random();
for (int i = 1; i < zeilen; i++)
{
    zahl[i] = random.Next(1002);
}

int ergebnis = MaxWert(zahl);
    
Console.WriteLine("Die größte Zahl ist {0}", ergebnis);

// Programmende

/// Funktionsbereich

static int MaxWert(int[] zahl)
{

     int speicher = 0;
    for (int i = 1; i < 21; i++)
    {
        Console.WriteLine("Zahl {0}: {1}", i, zahl[i]);
        if (zahl[i] > speicher )
        {
            speicher = zahl[i];
        }
     
    }
    int ergebnis = speicher;
    return ergebnis;
}

