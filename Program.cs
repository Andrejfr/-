using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolnoePrilogenie
{
	class Program
	{
		static void Main(string[] args)
		{   
			bool ff;
		
			do {
				Console.Write("Ввод:");
				string text = Console.ReadLine();
				int len = text.Length;
				bool flag = true;

				for (int i = 0; i < len / 2; i++)
				{
					if (text[i] != text[len - (i + 1)])
					{
						flag = false;
						break;
					}
				}
				if (flag)
				{
					Console.WriteLine("{0} является палиндромом", text);
				}
				else
				{
					Console.WriteLine("{0} не является палиндромом", text);
				}
				Console.WriteLine("Для продолжения нажмите (1)");
				int q = Int32.Parse(Console.ReadLine());
				if (q == 1) ff = true;
				else ff = false;
				Console.Clear();
			}
			while (ff==true);
			
			Console.ReadLine();
		}
	}
}
