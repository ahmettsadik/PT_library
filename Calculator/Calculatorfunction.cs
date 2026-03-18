using System;
namespace Calculator
{
	public class Calculatorfunction
	{
		public Calculatorfunction()
		{
		}
		public int ADD(int v1, int v2)
			{
			return v1 + v2;

			}
		public int Div (int v1, int v2)
		{
			if (v2 == 0)
				throw new DivideByZeroException();
			return v1 / v2;

		}
	}
}

