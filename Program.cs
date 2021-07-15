using System;

namespace FibSequence
{
	class Program
	{
		static void Main(string[] args)
		{
			ulong c = 1;
			ulong n = 0;
			ulong o = 0;

			while (0 == 0)
			{
				Console.WriteLine(c);
				n = c + o;
				if (n < c) break;
				o = c;
				c = n; 
			}
		}
	}
}
