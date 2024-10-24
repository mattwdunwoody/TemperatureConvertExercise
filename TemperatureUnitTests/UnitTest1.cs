using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TemperatureUnitTests
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void FahrenheitToCelsiusTest()
		{
			//Arrange
			double fahrenheit = 77;
			double expected = 25;

			//Act
			double actual = TemperatureClassLibrary.TemperatureConversions.ToCelsius(fahrenheit);

			//Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void CelsiusToFahrenheitTest()
		{
			//Arrange
			double celsius = 25;
			double expected = 77;

			//Act
			double actual = TemperatureClassLibrary.TemperatureConversions.ToFahrenheit(celsius);

			//Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
