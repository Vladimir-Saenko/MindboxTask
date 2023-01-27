using CalcShapeArea;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcShapeConsoleApp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double area = 0; // Инициализация переменной площади фигуры

			// Выбор фигуры
			Console.WriteLine("Выберите фигуру:");
			Console.WriteLine("1 - круг, 2 - треугольник");
			int f = (int)Int64.Parse(Console.ReadLine());

			switch (f) 
			{
				case 1: // Круг
					{
						Console.Write("Введите радиус круга: ");
						double r = (double.Parse(Console.ReadLine()));
						area = CalcArea.GetArea(r);
						break;
					}
				case 2: // Треугольник
					{
						Console.Write("Введите длину 1-й стороны: ");
						double a = (double.Parse(Console.ReadLine()));
						Console.Write("Введите длину 2-й стороны: ");
						double b = (double.Parse(Console.ReadLine()));
						Console.Write("Введите длину 3-й стороны: ");
						double c = (double.Parse(Console.ReadLine()));
						CalcTriangle triangle = CalcArea.GetArea(a, b, c);
						area = triangle.Area;
						if (triangle.IsRect) 
						{
							Console.WriteLine("Это прямоугольный треугольник");
						}
						break;
					}
			}

			if (area <= 0)
			{
				Console.WriteLine("Нет такой фигуры.");
			}
			else 
			{
				Console.WriteLine($"Площадь фигуры = {area}");
			}
			Console.WriteLine("Нажмите любую клавишу");
			Console.ReadKey();
		}
	}
}
