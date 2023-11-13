using commify_test_task.Server.Database;
using commify_test_task.Server.Seed;
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
			var taxBands = TaxBands.DefaultTaxBands;
			dbContext.AddRange(taxBands);
			dbContext.SaveChanges();
		}
	}
}
