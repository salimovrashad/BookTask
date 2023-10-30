using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
	internal class Book : Product
	{
        public string AuthorName { get; set; }
        public int PageCount { get; set; }

		public override void Sell()
		{
            int topprc = Price * Count;
			Count--;
            int endprc = Price * Count;
            Console.WriteLine(topprc - endprc);
        }

		public override void ShowInfo()
		{
            Console.WriteLine($"Count: {Count}, AuthorName: {AuthorName},Name: {Name},Price: {Price}");
        }

	}
}
