using commify_test_task.Server.Features.UKIncomeTaxCalculator.Dtos;

namespace commify_test_task.Server.Features.UKIncomeTaxCalculator.Handlers
{
	public interface IUKTaxBandProvider
	{
		IEnumerable<UKTaxBandData> GetUKTaxBandsData();
	}
}
