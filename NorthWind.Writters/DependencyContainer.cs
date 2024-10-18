using NorthWind.Writters;

namespace Microsoft.Extensions.DependencyInjection;

public static class DependencyContainer
{
	public static IServiceCollection AddConsoleWritter(this IServiceCollection services)
	{
		services.AddSingleton<IUserActionWriter, ConsoleWritter>();
		return services;
	}
	public static IServiceCollection AddDebugWritter(this IServiceCollection services)
	{
		services.AddSingleton<IUserActionWriter, DebugWritter>();
		return services;
	}

	public static IServiceCollection AddFileWritter(this IServiceCollection services)
	{
		services.AddSingleton<IUserActionWriter, FileWritter>();
		return services;
	}
}
