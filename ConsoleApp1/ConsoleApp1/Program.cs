using System.Linq.Expressions;
using ConsoleApp1.Models;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Book book = new Book();
			while (true) 
			{
                Console.WriteLine("1.Add Product \n2.Sell \n3.Info");
				int num = Convert.ToInt32(Console.ReadLine());
                switch (num)
				{
					case 1:
						Console.WriteLine("AuthorName: ");
						book.AuthorName = Console.ReadLine();
						Console.WriteLine("Count: ");
						book.Count = Convert.ToInt32(Console.ReadLine());
						Console.WriteLine("Name: ");
						book.Name = Console.ReadLine();
						Console.WriteLine("Price: ");
						book.Price = Convert.ToInt32(Console.ReadLine());
						break;
					case 2:
						Console.WriteLine("Satisdan gelen gelir: ");
						book.Sell();
						break;
					case 3:
						book.ShowInfo();
						break;
					default:
						break;
				}
			}
        }
	}
}