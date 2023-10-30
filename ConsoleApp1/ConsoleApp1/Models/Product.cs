using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
	public abstract class Product
	{
		private static int _id = 0;
		public int Id;
		public Product() 
		{
			_id++;
			Id = _id;
		}
        public string Name
        {
			get;
            set; 
        }
        public int Price
		{
			get;
			set;
		}
		public int Count
		{
			get;
			set;
		}
		protected int TotalInCome
		{
			get;
			set;
		}
		public int Sold = 0;
		
		
		public abstract void Sell();
        public abstract void ShowInfo();


	}
}
