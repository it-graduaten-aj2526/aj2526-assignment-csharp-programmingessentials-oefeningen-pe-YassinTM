//array syntax: int[] numbers = [0, 1, 2, 3]; console.writeline(numbers[0])
//foreach is for but to list out items in a collection like array/list
//array = vaste waarde, List = length is adjustable
//list syntax List<int> numberList = [0, 1, 2, 3]; 
//omdat list dynamically is kan je numberList.Add(waarde) en numberList.Remove(waarde)
//int[] getallen = new int[5] --> voor set array length
string antwoord, naam;
List<string> namenlijst = [];
do
{
    System.Console.WriteLine("Wil je een naam toevoegen?");
    antwoord = Console.ReadLine();
} while (antwoord.ToLower() != "ja" && antwoord.ToLower() != "nee");

while (antwoord.ToLower() == "ja")
{

    do
    {
        System.Console.Write("Geef een naam in: ");
        naam = Console.ReadLine();
    } while (string.IsNullOrEmpty(naam));
    namenlijst.Add(naam);

    do
    {
        System.Console.WriteLine("Wil je een anam toevoegen?");
        antwoord = Console.ReadLine();
    } while (antwoord.ToLower() != "ja" && antwoord.ToLower() != "nee");

}
if (namenlijst.Count() > 0)
{
    System.Console.WriteLine("Namen:");
    foreach (string n in namenlijst)
{
    System.Console.WriteLine(n);
}

}
