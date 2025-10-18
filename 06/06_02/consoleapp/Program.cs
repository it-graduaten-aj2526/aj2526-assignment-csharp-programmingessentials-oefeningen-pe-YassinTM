string voornaam, achternaam;
int hobbynummer;
bool numberornot, conditional = true;
{
    System.Console.WriteLine("voornaam: ");
    voornaam = Console.ReadLine();

} while (string.IsNullOrEmpty(voornaam));

do
{
    System.Console.WriteLine("achternaam: ");
    achternaam = Console.ReadLine();

} while (string.IsNullOrEmpty(achternaam));

do
{

    do
    {

        System.Console.WriteLine("hobby nummer");
        numberornot = int.TryParse(Console.ReadLine(), out hobbynummer);

    } while (!numberornot);

    
    switch (hobbynummer)
        {
            case 1:
            System.Console.WriteLine("Wij raden \"Anna\" aan.");
            conditional = true;
            break;

            case 2:
            System.Console.WriteLine("Wij raden \"Knippie\" aan.");
conditional = true;
            break;

            case 3:
            System.Console.WriteLine("Wij raden \"VtWonen\" aan.");
conditional = true;
            break;

            case 4:
            System.Console.WriteLine("Wij raden \"Voetbal International\" aan.");
conditional = true;
            break;

            case 5:
            System.Console.WriteLine("Wij raden \"Wandelen & fietsen\" aan.");
conditional = true;
            break;

            case 6:
            System.Console.WriteLine("Wij raden \"Zoom NL\" aan.");
conditional = true;
            break;

            case 7:

            System.Console.WriteLine("Wij raden \"Runners\" aan.");
            conditional = true;
            break;

            case 8:
            System.Console.WriteLine("Wij raden niets aan.");
            conditional = false;
            break;
        }

} while (conditional);