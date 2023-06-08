Random dice = new Random();

int roll1 = dice.Next(); //retorna valor entre zero e 2147483647 (valor máximo de um int)
int roll2 = dice.Next(101); //retorna um valor entre zero e 100
int roll3 = dice.Next(50, 101); //retorna um valor entre 50 e 100

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");

Console.ReadKey();
