using NorthWind.ConsoleApp.Services;
using NorthWind.Entities.Interfaces;

IUserActionWriter writer = default;

AppLogger logger = new AppLogger(writer);
logger.WriteLog("Application Started");
