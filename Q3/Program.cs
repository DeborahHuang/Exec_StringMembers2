using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Q3將字串 "aLLeN kUO" 轉換成 "Allen Kuo"
			string name = "aLLeN kUO";
			string firstNameChar = name.Substring(0,1).ToUpper();
			string secondNameChar= name.Substring(6,1).ToUpper();
			string firstName=name.Substring(1,4).ToLower();
			string secondName=name.Substring(7,2).ToLower();
			
			Console.WriteLine($"{firstNameChar}{firstName} {secondNameChar}{secondName}");
		}
	}
}
