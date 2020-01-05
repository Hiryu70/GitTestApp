using System;

namespace GitTestApp
{
	class Program
	{
		static void Main(string[] args)
		{
			PrintHelloWorld("Hello World!");
			PrintHelloWorld("Hello World1!");
			PrintHelloWorld("Hello World2!");
		}

		static void PrintHelloWorld(string str)
		{
			Console.WriteLine(str);
		}
	}
}
