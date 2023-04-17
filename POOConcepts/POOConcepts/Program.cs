// See https://aka.ms/new-console-template for more information


using POOConcepts;

Console.WriteLine("Hello, World!");
Console.WriteLine("=============");



try
{
	Console.WriteLine(new Date(2024, 2, 29));

	Console.WriteLine(new Date(2023, 8, 19));

	Console.WriteLine(new Date(1990, 12, 25));

	Console.WriteLine(new Date(2023, 11, 31));
}
catch (Exception error)
{

	Console.WriteLine(error.Message);
}
