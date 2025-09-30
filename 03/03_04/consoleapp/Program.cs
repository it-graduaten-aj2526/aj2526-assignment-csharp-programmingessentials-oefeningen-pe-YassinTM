string naam, voornaam, cijferAlsString;
int cijfer;

System.Console.WriteLine("Wat is jou voornaam?: ");
voornaam = Console.ReadLine();

System.Console.WriteLine("Wat is jou naam?: ");
naam = Console.ReadLine();

System.Console.WriteLine("Wat is jou hobby?\n1 - Handwerk\n2 - Kleding maken\n3 - Interieur\n4 - Voetballen\n5 - Fietsen\n6 - Fotografie");
cijferAlsString = Console.ReadLine();

cijfer = int.Parse(cijferAlsString);

switch (cijfer)
{
    case 1:
        System.Console.WriteLine($"{voornaam.ToLower()} {naam.ToUpper()}, tijdschrift: \"Anna\"");
        break;
    case 2:
        System.Console.WriteLine($"{voornaam.ToLower()} {naam.ToUpper()}, tijdschrift: \"Knippie\"");
        break;
    case 3:
        System.Console.WriteLine($"{voornaam.ToLower()} {naam.ToUpper()}, tijdschrift: \"VtWonen\"");
        break;
    case 4:
        System.Console.WriteLine($"{voornaam.ToLower()} {naam.ToUpper()}, tijdschrift: \"Voetbal International\"");
        break;
    case 5:
        System.Console.WriteLine($"{voornaam.ToLower()} {naam.ToUpper()}, tijdschrift: \"Wandelen & fietsen\"");
        break;
    case 6:
        System.Console.WriteLine($"{voornaam.ToLower()} {naam.ToUpper()}, tijdschrift: \"Zoom NL\"");
        break;
    case 7:
        System.Console.WriteLine($"{voornaam.ToLower()} {naam.ToUpper()}, tijdschrift: \"Runners\"");
        break;
    default:
        System.Console.WriteLine($"{voornaam.ToLower()} {naam.ToUpper()}, tijdschrift: -") ;
        break;

}