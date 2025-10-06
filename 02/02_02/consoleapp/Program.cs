//version 2
int getal1, getal2;

Console.WriteLine("Geef getal 1: ");
getal1 = int.Parse(Console.ReadLine());

Console.WriteLine("Geef getal 2: ");
getal2 = int.Parse(Console.ReadLine());

if(getal1 == 0 ){
 Console.WriteLine($"{getal2} is niet deelbaar door 0.");   
}
else if (getal2 == 0 )
{
    Console.WriteLine($"{getal1} is niet deelbaar door 0.");   
}
else{
    Console.WriteLine($"{getal1} / {getal2} = {getal1/getal2}");
}