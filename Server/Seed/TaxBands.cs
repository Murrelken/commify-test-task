using commify_test_task.Server.Features.UKIncomeTaxCalculator.Entities;

namespace commify_test_task.Server.Seed
{
	public static class TaxBands
	{
		public static List<UKTaxBand> DefaultTaxBands => new List<UKTaxBand>
			{
				new UKTaxBand(0, 5000, 0),
				new UKTaxBand(5000, 20000, 20),
				new UKTaxBand(20000, null, 40)
			};
	}
}
