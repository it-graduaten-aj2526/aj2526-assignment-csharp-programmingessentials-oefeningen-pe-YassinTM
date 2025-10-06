// bij een for loop weet je ALTIJD hoeveel keer je wilt herhalen/loopen
//for loop: bestaat uit 3 delen
//Deel1 = variable aanmaken
//Deel2 = BOOLEAANSE VOORWAARDEN > IF TRUE = CODE UITVOEREN IN DE LOOP
//DEEL 3 = WAT DOEN NA DE CODE IS UITGEVOERD
// DIT LOOPT TOT DAT DEEL 2 = ONWAAR
int getal;
Console.Write("Geef een getal in: ");
getal = int.Parse(Console.ReadLine());

for (int i = 0; i < 10; i++)
{
    ++getal;
    Console.WriteLine($"{getal}");
}