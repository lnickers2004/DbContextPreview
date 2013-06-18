using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbContextPreview
{
	public partial class Amount 
	{

		public string DisplayAmount
		{
			get
			{
				return this.MinimumAmount +
					" to " + this.MaximumAmount
					+ " " + this.Unit;
			}

		}
		

		/// <summary>
		/// 
		/// </summary>
		public void OnMaximumAmountChanging()
		{
			Console.WriteLine("maximum amount is changing"); 
		}
	}
}
