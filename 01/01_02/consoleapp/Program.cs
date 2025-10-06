//version 1
float prijsminbtw;
int percentage;

Console.Write("Geef de prijs exclusief btw: ");
prijsminbtw = float.Parse(Console.ReadLine());

Console.Write("Geef het percentage btw: ");
percentage = int.Parse(Console.ReadLine());

float prijsincbtw = prijsminbtw + (prijsminbtw / 100 * percentage);


Console.Write($"Prijs inclusief BTW: {Convert.ToInt32(prijsincbtw)}");
