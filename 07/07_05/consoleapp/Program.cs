int inputgetal;
List<int> getallenlijst = [];
do
{
    System.Console.WriteLine("Geef een getal in, 0 op te eindigen: ");
} while (!int.TryParse(Console.ReadLine(), out inputgetal));

while (inputgetal != 0)
{
    getallenlijst.Add(inputgetal);
    do
    {
        System.Console.WriteLine("Geef een getal in, 0 op te eindigen: ");
    } while (!int.TryParse(Console.ReadLine(), out inputgetal));

}
getallenlijst.Sort();

if (getallenlijst.Count() > 0)
{
System.Console.WriteLine("Statistieken:");
System.Console.WriteLine($"Hoogste cijfer: {getallenlijst.Last()}");
System.Console.WriteLine($"Laagste cijfer: {getallenlijst.First()}");
System.Console.WriteLine($"Gemiddelde: {Math.Floor(getallenlijst.Average())}");
    
}
else
{
    System.Console.WriteLine("Lege lijst");
}
//