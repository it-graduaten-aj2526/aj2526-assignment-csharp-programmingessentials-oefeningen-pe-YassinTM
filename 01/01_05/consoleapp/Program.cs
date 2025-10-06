//version 1
int celcius, fahrenheit;

Console.Write("Geef een temperatuur in Celcius: ");
celcius = int.Parse(Console.ReadLine());

fahrenheit = celcius * 9 / 5 + 32;
Console.Write($"Fahrenheit: {fahrenheit}");