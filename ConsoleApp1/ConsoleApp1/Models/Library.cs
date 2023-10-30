using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
	internal class Library
	{
		Book[] Books;

		public void AddBook(Book book) 
		{ 
			Array.Resize(ref Books, Books.Length + 1);
			Books[Books.Length - 1] = new Book();
		}
	}
}
