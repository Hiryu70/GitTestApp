using System;

namespace GitTestApp
{
	class Program
	{
		static void Main(string[] args)
		{
			PrintHelloWorld("Hello World!");
		}

		static void PrintHelloWorld(string str)
		{
			Console.WriteLine($"-!--{str}--!-");
		}
	}
}
