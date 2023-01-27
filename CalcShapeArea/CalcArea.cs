using System;
using System.Linq;

/// --------------------------------------------
/// Задание 3 от Mindbox 
/// --------------------------------------------
/// Библиотека со статическими методами
/// Вычисление площади круга с заданным радиусом
/// и треугольника по трем сторонам
/// + проверка треугольника на прямоугольность


namespace CalcShapeArea
{
	public class CalcTriangle // класс для результатов вычисления площади треугольника
	{
		public double Area = 0;
		public bool IsRect = false;
	}

	public static class CalcArea
	{ 

		// Вычисление площади круга
		public static double GetArea(double radius)
		{
			return (double)(Math.PI * radius * radius / 2);
		}

		// Вычисление площади треугольника по трем сторонам (формула Герона)
		public static CalcTriangle GetArea(double a, double b, double c)
		{
			CalcTriangle t = new CalcTriangle();
			double p = (a + b + c) / 2;
			t.Area = (double)Math.Sqrt(p * (p - a) * (p - b) * (p - c));

			// Проверка на прямоугольность
			// Для прямоугольного треугольника справедлива теорема Пифагора
			t.IsRect = false;
			double[] sides = new[] {a, b, c };
			double gip = sides.Max(); // гипотенуза
			var katets = sides.Where(k => k < gip);
			double gip2 = 0;
			foreach (var katet in katets) 
			{
				gip2 += katet * katet;
			}
			if (gip*gip == gip2) // Квадрат гипотенузы равен сумме квадратов катетов?
			{
				t.IsRect = true;
			}

			// Возврат результата
			return t;
		}

	}
}
