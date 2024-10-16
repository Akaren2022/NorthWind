using NorthWind.Entities.Interfaces;
using NorthWind.Entities.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.ConsoleApp.Services
{
	internal class ProductService(IUserActionWriter writter)
	{
		public void Add(string user, string ProductName) 
		{
			UserAction Action = new UserAction(user, $"Created: {ProductName}");
			writter.Write( Action );
		}
	}
}
