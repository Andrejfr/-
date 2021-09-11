using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication2
{
	class Program
	{
		static void Main(string[] args)
		{
			bool ff;
			string[] len = File.ReadAllLines(@"C:\Users\047-19\Desktop\val.txt");
			do
			{
				foreach (var text in len)
				{
					bool flag = true;
					for (int i = 0; i < text.Length / 2; i++)
					{
						if (text[i] != text[text.Length - (i + 1)])
						{
							flag = false;
							break;
						}
					}
					if (flag)
						Console.WriteLine("{0} является палиндромом", text);
					else
						Console.WriteLine("{0} не является палиндромом", text);
				}
					Console.WriteLine("Для продолжения нажмите (1)");
					int q = Int32.Parse(Console.ReadLine());
					if (q == 1) ff = true;
					else ff = false;
					Console.Clear();
			}
			while (ff == true);

				Console.ReadLine();
			
	   }
	}
} 
