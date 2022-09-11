using Exercise01;

Console.WriteLine("Enter an integer to convert to words");
var number = Console.ReadLine();

Console.WriteLine($"{number} in words:");
int value = int.Parse(number);
Console.WriteLine(value.ToWords());
