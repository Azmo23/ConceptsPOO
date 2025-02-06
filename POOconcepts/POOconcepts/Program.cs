
using POOconcepts;

Console.WriteLine("Hello, World!");
try
{
	Console.WriteLine(new Date(2024, 2, 29));
	Console.WriteLine(new Date(2014, 2, 29));
	Console.WriteLine(new Date(1999, 21, 30));
}
catch (Exception error)
{

	Console.WriteLine(error.Message);
}



