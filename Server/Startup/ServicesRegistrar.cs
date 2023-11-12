using commify_test_task.Server.Features.UKIncomeTaxCalculator.Handlers;

namespace commify_test_task.Server.Startup
{
	public static class ServicesRegistrar
	{
		public static void RegisterServices(this IServiceCollection services)
		{
			services.AddScoped<IUKTaxCalculator, UKTaxCalculator>();
			services.AddScoped<IUKTaxBandProvider, UKTaxBandProvider>();
		}
	}
}
