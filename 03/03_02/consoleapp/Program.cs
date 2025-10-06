//version 2
int jaartal;
string jaaralsString;

System.Console.WriteLine("geef een jaartal in: ");
jaaralsString = Console.ReadLine();
jaartal = int.Parse(jaaralsString);

if (jaartal >= 1582)
{
    if ((jaartal % 4000) == 0)
    {
        System.Console.WriteLine($"{jaartal} is geen schrikkeljaar");
    }
    else if ((jaartal % 400) == 0)
    {
        System.Console.WriteLine($"{jaartal} is een schrikkeljaar");
    }
    else if ((jaartal % 100) == 0)
    {
        System.Console.WriteLine($"{jaartal} is een schrikkeljaar");
    }
    else if ((jaartal % 4) == 0)
    {
        System.Console.WriteLine($"{jaartal} is een schrikkeljaar");
    }

}
else
{
    if ((jaartal % 4) == 0)
    {
        System.Console.WriteLine("Wel schrikkeljaar");
    }
    else
    {
                System.Console.WriteLine("Niet schrikkeljaar");

    }
}