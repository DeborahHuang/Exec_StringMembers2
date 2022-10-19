using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Q4 假設有表示日期的字串"1100225"
			//請將它轉成表示西元年的日期"20210225"

			string Date = "1100225";
			string year=Date.Substring(0,3);
			string month=Date.Substring(3,2);
			string day=Date.Substring(5,2);

			DateTime ADDate = new DateTime(Convert.ToInt32(year)+1911, Convert.ToInt32(month), Convert.ToInt32(day));//變西元要+1911
			Console.WriteLine(ADDate);
		}
	}
}
