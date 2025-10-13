int tijd = 0;
double hoeveelheid;

System.Console.WriteLine("Hoeveel koffie (mg): ");
hoeveelheid = double.Parse(Console.ReadLine());

while (hoeveelheid > 1)
{
    tijd += 5;
    hoeveelheid = hoeveelheid / 2;
}

System.Console.WriteLine($"Totale tijd: {tijd} uur");