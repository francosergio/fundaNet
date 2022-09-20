using Humanizer;

Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, age please!");

int age= int.Parse(Console.ReadLine());
Console.WriteLine($"tengo {age.ToWords(new System.Globalization.CultureInfo("es") )}");