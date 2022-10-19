using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Q7計算兩數之和,並只呈現小數二位數
			double value1 = 103.519;
			double value2 = 104.758;
			string answer=(value1+value2).ToString("###.##");
			Console.WriteLine(answer);
		}
	}
}
