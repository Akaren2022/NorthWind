using NorthWind.ConsoleApp.Services;
using NorthWind.Entities.Interfaces;
using NorthWind.Writters;

IUserActionWriter writer = new ConsoleWritter();

AppLogger logger = new AppLogger(writer);
logger.WriteLog("Application Started");

ProductService Service = new ProductService(writer);
Service.Add("Demo", "Azucar");