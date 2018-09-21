/*
 * Created by SharpDevelop.
 * User: nukiyama.makoto
 * Date: 2018/09/21
 * Time: 10:15
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Linq;

namespace test
{
	class Program
	{
		public static void Main(string[] args)
		{
			try {
				Console.WriteLine("Input ...");
				int? input = Convert.ToInt32(Console.ReadLine());
			
				if (new[] { 0, 1, 2 }.Contains(input ?? 0))
				{
					Console.WriteLine("Safe");
				}
				else
				{
					Console.WriteLine("Out");
				}
			}
			catch(Exception ex)
			{
				Console.WriteLine("Input Error.[{0}]",ex.ToString());
			}

			Console.ReadKey(true);
		}
	}
}