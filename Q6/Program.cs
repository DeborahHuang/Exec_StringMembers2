using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Q6比對使用者輸入值是否為 "Allen", 區分大小寫
			Console.WriteLine("請輸入\"Allen\"");
			string input=Console.ReadLine();
			string answer = "Allen";

			if (string.IsNullOrEmpty(input))
			{
				Console.WriteLine("您沒有輸入");
				return;
			}
			if (input != answer)
			{
				Console.WriteLine("請檢查輸入名稱並注意大小寫");
				return ;
			}
			Console.WriteLine("您輸入正確");	
		}
	}
}
