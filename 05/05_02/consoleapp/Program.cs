int totaalprijs = 0;
int prijs;
int lidjaren;
bool istrue;
for (int i = 0; i < 5; i++)
{
    System.Console.WriteLine("Geef de prijs: ");
    istrue = int.TryParse(Console.ReadLine(), out prijs);
    while (!istrue)
    {
        System.Console.WriteLine("Geef de prijs: ");
        istrue = int.TryParse(Console.ReadLine(), out prijs);
    }
    totaalprijs += prijs;
}
System.Console.WriteLine("Hoeveel jaren lid (max 5): ");
istrue = int.TryParse(Console.ReadLine(), out lidjaren);
while (!istrue || lidjaren > 5)
{
    System.Console.WriteLine("Hoeveel jaren lid (max 5): ");
    istrue = int.TryParse(Console.ReadLine(), out lidjaren);
}
    
switch (lidjaren)
{
    case 1:
            System.Console.WriteLine($"Totaalprijs: {totaalprijs - 5} euro");
        break;

     case 2:
            System.Console.WriteLine($"Totaalprijs: {totaalprijs - 10} euro");
        
break;

 case 3:
            System.Console.WriteLine($"Totaalprijs: {totaalprijs - 20} euro");
        
break;

 case 4:
            System.Console.WriteLine($"Totaalprijs: {totaalprijs - 30} euro");
        
break;

 case 5:
            System.Console.WriteLine($"Totaalprijs: {totaalprijs - 50} euro");

        break;
    default:
                        System.Console.WriteLine($"Totaalprijs: {totaalprijs} euro");

        break;

}
