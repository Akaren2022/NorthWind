using NorthWind.Entities.Interfaces;
using NorthWind.Entities.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Writters
{
	internal class ConsoleWritter : IUserActionWriter
	{
		public void Write(UserAction action)
		{
			Console.WriteLine("Console Writter: {0}, {1}, {2}", action.CreatedDateTime, action.User, action.Descripcion );
		}
	}
}
