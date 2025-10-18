double mg, uur = 0;
bool trueornah;
do
{
    System.Console.WriteLine("Hoeveel mg: ");
    trueornah = double.TryParse(Console.ReadLine(), out mg);
} while (!trueornah);


while (mg > 1)
{
    mg = mg / 2;
    uur = uur +5;
}
System.Console.WriteLine($"Totale tijd: {uur} uur");