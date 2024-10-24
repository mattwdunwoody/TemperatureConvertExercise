using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			//Converting Fahrenheit to Celsius
			Console.WriteLine("Convert F to C:\nEnter the temperature in F: ");

			//Get user input
			double fahrenheit = Convert.ToDouble(Console.ReadLine());

			//Calculate result from class library
			double result = TemperatureClassLibrary.TemperatureConversions.ToCelsius(fahrenheit);

			//Print result
			Console.WriteLine("Result = " + result + " degrees Celcius");

			//---------------------

			//Converting Celsius to Fahrenheit
			Console.WriteLine("\nConvert C to F:\nEnter the temperature in C: ");

			//Get user input
			double celsius = Convert.ToDouble(Console.ReadLine());

			//Calculate result from class library
			double result2 = TemperatureClassLibrary.TemperatureConversions.ToFahrenheit(celsius);

			//Print result
			Console.WriteLine("Result = " + result2 + " degrees Fahrenheit");

			Console.ReadKey();
		}
	}
}
