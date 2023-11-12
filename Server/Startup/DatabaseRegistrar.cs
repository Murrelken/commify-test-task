using commify_test_task.Server.Database;
using commify_test_task.Server.Features.UKIncomeTaxCalculator.Entities;
using Microsoft.EntityFrameworkCore;

namespace commify_test_task.Server.Startup
{
	public static class DatabaseRegistrar
	{
		public static void AddDatabase(this IServiceCollection services)
		{
			services.AddDbContext<TaxCalculatorDbContext>
				(o => o.UseInMemoryDatabase("PriceFetchInMemory"));

			services.AddScoped<DbContext, TaxCalculatorDbContext>();
		}

		public static void SeedTaxBands(this IServiceProvider serviceProvider)
		{
			using var scope = serviceProvider.CreateScope();
			var dbContext = scope.ServiceProvider.GetRequiredService<DbContext>();
			var taxBands = new List<UKTaxBand>
			{
				new UKTaxBand(0, 5000, 0),
				new UKTaxBand(5000, 20000, 20),
				new UKTaxBand(20000, null, 40)
			};
			dbContext.AddRange(taxBands);
			dbContext.SaveChanges();
		}
	}
}
