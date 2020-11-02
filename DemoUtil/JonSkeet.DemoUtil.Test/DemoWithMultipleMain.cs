using System;
using System.ComponentModel;

namespace JonSkeet.DemoUtil.Test
{
	[Description("More than one Main Method.")]
	class DemoWithMultipleMain
	{
		static void Main(string args) => Console.WriteLine("Main(string args)");
		static void Main() => Console.WriteLine("Main()");
		static void Main(int i) => Console.WriteLine("Main(int i)");
		static void Main(string[] args) => Console.WriteLine("Main(string [] args)");
	}
}
