using commify_test_task.Server.Features.UKIncomeTaxCalculator.Dtos;
using commify_test_task.Server.Features.UKIncomeTaxCalculator.Entities;
using Microsoft.EntityFrameworkCore;

namespace commify_test_task.Server.Features.UKIncomeTaxCalculator.Handlers
{
	public class UKTaxBandProvider : IUKTaxBandProvider
	{
		private readonly DbContext _dbContext;

		public UKTaxBandProvider(DbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public IEnumerable<UKTaxBandData> GetUKTaxBandsData()
		{
			return _dbContext
				.Set<UKTaxBand>()
				.Select(x => new UKTaxBandData
				{
					LowerLimit = x.LowerLimit,
					UpperLimit = x.UpperLimit,
					TaxRate = x.TaxRate
				})
				.ToArray();
		}
	}
}
