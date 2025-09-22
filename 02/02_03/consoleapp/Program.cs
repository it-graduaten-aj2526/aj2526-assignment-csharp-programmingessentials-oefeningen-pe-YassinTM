string voornaam, familienaam, leeftijdgroep = "Volwassenen";
int leeftijd;

Console.Write("Geef je voornaam: ");
voornaam = Console.ReadLine();

Console.Write("Geef je familienaam: ");
familienaam = Console.ReadLine();

Console.Write("Geef je leeftijd: ");
leeftijd = int.Parse(Console.ReadLine());

if (leeftijd <18)
{
    leeftijdgroep = "Jeugd";
}

Console.WriteLine($"{voornaam} {familienaam}: {leeftijdgroep}");