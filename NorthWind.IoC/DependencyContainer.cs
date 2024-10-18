using NorthWind.Writters;

namespace Microsoft.Extensions.DependencyInjection;

public static class DependencyContainer
{
	public static IServiceCollection AddNorthWindServices(
		this IServiceCollection services)
	{
		services.AddDebugWritter();
		services.AddServices();
		return services;
	}
}
