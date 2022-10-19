using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Q5比對使用者輸入值是否為 "Allen" 不拘大小寫
			Console.WriteLine("請輸入\"Allen\"，不拘大小寫");
			string input = Console.ReadLine();
			string value=input.ToLower();
			string value2= "Allen";

			if (string.IsNullOrEmpty(input))
			{
				Console.WriteLine("您沒有輸入");
				return;
			}

			if (value == "allen")
			{
				Console.WriteLine("您輸入正確");
			}
		}
	}
}
