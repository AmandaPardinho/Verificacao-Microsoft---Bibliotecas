//Implementar um desafio da classe Math que retorna o maior de dois números

Random number = new Random();
int firstValue = number.Next(101);
int secondValue = number.Next(101);
int largerValue = Math.Max(firstValue, secondValue);

Console.WriteLine($"LargerValue: {largerValue}\nFirstValue: {firstValue}\nSecondValue: {secondValue}");

Console.ReadKey();