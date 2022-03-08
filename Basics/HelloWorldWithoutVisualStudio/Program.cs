// See https://aka.ms/new-console-template for more information
// In the latest version of C#, a new feature named top-level statements lets you omit the Program class and the Main method. Most existing C# programs don't use top-level statements, so this tutorial doesn't use this new feature. But it's available in C# 10, and whether you use it in your programs is a matter of style preference.
Console.WriteLine("Hello, World!");

Console.WriteLine("What is your name?");
var name = Console.ReadLine();
var currentDate = DateTime.Now;
Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!"); // set breakpoint here
Console.Write($"{Environment.NewLine}Press any key to exit...");
Console.ReadKey(true);
