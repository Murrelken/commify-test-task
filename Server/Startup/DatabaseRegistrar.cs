using commify_test_task.Server.Database;
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
	}
}
