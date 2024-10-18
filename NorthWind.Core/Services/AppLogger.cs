using NorthWind.Entities.Interfaces;
using NorthWind.Entities.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.ConsoleApp.Services
{
	internal class AppLogger(IEnumerable<IUserActionWriter> writters):IAppLogger
	{
		public void WriteLog(string messagge)
		{ 
			UserAction Log = new UserAction("System", messagge);
			foreach(var writter in writters)
				writter.Write(Log);
		}
	}
}
