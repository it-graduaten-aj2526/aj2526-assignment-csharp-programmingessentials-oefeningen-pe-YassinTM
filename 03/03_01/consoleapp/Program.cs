int getal1, getal2, getal3, cijfercode;
string lettercode, getalAlsString;

System.Console.WriteLine("Geef een getal: ");
getalAlsString = Console.ReadLine();
getal1 = int.Parse(getalAlsString);

System.Console.WriteLine("Geef nog een getal: ");
getalAlsString = Console.ReadLine();
getal2 = int.Parse(getalAlsString);

System.Console.WriteLine("Geef nog een getal: ");
getalAlsString = Console.ReadLine();
getal3 = int.Parse(getalAlsString);

System.Console.WriteLine("Geef lettercode A of B: ");
lettercode = Console.ReadLine().ToUpper();

System.Console.WriteLine("Geef cijfercode 1, 2 of 3: ");
getalAlsString = Console.ReadLine();
cijfercode = int.Parse(getalAlsString);


switch (lettercode)
{
    case "A":
        if (cijfercode == 1)
        {
            System.Console.WriteLine($"{getal1} + {getal2} = {getal1 + getal2}");
        }
        else if (cijfercode == 2)
        {
            System.Console.WriteLine($"{getal2} + {getal3} = {getal2 + getal3}");
        }
        else
        {
            System.Console.WriteLine($"{getal1} + {getal3} = {getal1 + getal3}");

        }
        break;
    case "B":
    if (cijfercode == 1)
        {
            System.Console.WriteLine($"{getal1} - {getal2} = {getal1 - getal2}");
        }
        else if (cijfercode == 2)
        {
            System.Console.WriteLine($"{getal2} - {getal3} = {getal2 - getal3}");
        }
        else
        {
            System.Console.WriteLine($"{getal1} - {getal3} = {getal1 - getal3}");

        }
        break;
}