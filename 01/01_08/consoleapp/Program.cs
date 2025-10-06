//version 1
double pi = 3.14;
Console.WriteLine("Wat is de straal van je cirkel");
double diameter = double.Parse(Console.ReadLine()) * 2;
double omtrek = diameter * pi;
Console.WriteLine($"{omtrek}");
