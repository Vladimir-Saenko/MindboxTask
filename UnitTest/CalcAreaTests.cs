using CalcShapeArea;

namespace UnitTest
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		// Тест вычисления площади круга с радиусом 10
		public void GetArea_10_157returned()
		{
			// arrange
			double radius = 10;
			double expected = 157.07963267948966192313216916398; /* (double)(Math.PI * 10 * 10 / 2) */

			// act
			double actual = (double)CalcArea.GetArea(radius); 

			//assert
			Assert.AreEqual(expected, actual);
		}
		[Test]
		// Тест вычисления площади треугольника со сторонами 3, 4, и 5
		public void GetArea_3and4and5_6returned()
		{
			// arrange
			double a = 3;
			double b = 4;
			double c = 5;
			double expected = 6;

			// act
			double actual = CalcArea.GetArea(a, b, c).Area;

			//assert
			Assert.AreEqual(expected, actual);
		}
	}
}