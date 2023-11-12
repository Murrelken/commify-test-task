using commify_test_task.Server.Features.UKIncomeTaxCalculator.Entities;
using Microsoft.EntityFrameworkCore;

namespace commify_test_task.Server.Database
{
	public class TaxCalculatorDbContext : DbContext
	{
		public TaxCalculatorDbContext(DbContextOptions<TaxCalculatorDbContext> options) : base(options)
		{
		}

		public DbSet<UKTaxBand> UKTaxBands { get; set; }
	}
}
