Console.Write("What is your name? ");
string name = Console.ReadLine() ?? "";
Console.Write("How old are you? ");
int age = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Your name is {name}. Your are {age} years old.");