using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VA_4lb
{
	public class Solver
	{
		/// <summary>  Функция </summary>
		private static readonly Func<double, double> func = (x) => Math.Pow(Math.E, x) + 3 * x - 4.2;

		/// <summary> Производная функции func </summary>
		private static readonly Func<double, double> dfunc = (x) => Math.Pow(Math.E, x) + 3;

		/// <summary> Вторая производная функции func </summary>
		private static readonly Func<double, double> ddfunc = (x) => Math.Pow(Math.E, x);

		/// <summary> Событие выполняется каждую итерацию при поиске интервала </summary>
		public event Action<(double, double)> DoAfterStepOnRootBranches;

		/// <summary> Событие выполняется каждую итерацию при уточнение корней методом половинного деления </summary>
		public event Action<(double, double), (double, double), (double, double)> DoAfterStepOnHalfDivision;

		/// <summary> Событие выполняется каждую итерацию при уточнение корней методом Ньютона </summary>
		public event Action<double, double> DoAfterStepOnNewtonsMethod;

		/// <summary>
		/// Поиск интервала, на котором расположен корень уравнения
		/// </summary>
		/// <param name="a">левая граница отрезка</param>
		/// <param name="b">правая граница отрезка</param>
		/// <param name="n">кол-во частей, на которые будет разбиваться отрезок [a;b]</param>
		/// <returns>найденный интервал</returns>
		public (double, double) RootBranches(double a, double b, int n)
		{
			if (b < a) (a, b) = (b, a);

			double step = (b - a) / n;
			for (int i = 0; i < n - 1; i++)
			{
				double x = a + i * step;
				double x1 = a + (i + 1) * step;
				double f = func(x);
				double f1 = func(x1);

				DoAfterStepOnRootBranches?.Invoke((x, f));

				if (f * f1 < 0)
				{
					DoAfterStepOnRootBranches?.Invoke((x1, f1));
					return (x, x1);
				}
			}

			return (default, default);
		}

		/// <summary>
		/// Уточнение корней методом половинного деления
		/// </summary>
		/// <param name="interval">интервал на котором уточняется корень</param>
		/// <param name="countDigit">до скольки знаков после запятой округляем</param>
		/// <returns>уточненное решение</returns>
		public double HalfDivision((double a, double b) interval, int countDigit = 4)
		{
			double left = interval.a;
			double right = interval.b;
            double x;
            do
			{
				x = (left + right) / 2;
				double fLeft = func(left);
				double fX = func(x);
				double fRight = func(right);

				DoAfterStepOnHalfDivision?.Invoke((left, fLeft), (x, fX), (right, fRight));

				if (Math.Sign(fLeft) != Math.Sign(fX))
					right = x;

				if (Math.Sign(fX) != Math.Sign(fRight))
					left = x;
			}
			while (Math.Abs(right - left) > Math.Pow(10, -countDigit));

			return Math.Round(x, countDigit);
		}

		/// <summary>
		/// Уточнение корней методом Ньютона
		/// </summary>
		/// <param name="interval">интервал на котором уточняется корень</param>
		/// <param name="countDigit">до скольки знаков после запятой округляем</param>
		/// <returns>уточненное решение</returns>
		public double NewtonsMethod((double a, double b) interval, int countDigit = 4)
		{
			double x = default;

			if (func(interval.a) * ddfunc(interval.a) > 0)
				x = interval.a;

			if (func(interval.b) * ddfunc(interval.b) > 0)
				x = interval.b;

			double prev = default;
			while (Math.Abs(x - prev) > Math.Pow(10, -countDigit))
			{
				prev = x;
				x -= func(x) / dfunc(x);

				DoAfterStepOnNewtonsMethod?.Invoke(prev, x);
			}

			return Math.Round(x, countDigit);
		}
	}
}
