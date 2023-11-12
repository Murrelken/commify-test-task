namespace commify_test_task.Server.Features.UKIncomeTaxCalculator.Entities
{
	public class UKTaxBand
	{
		protected UKTaxBand() { }

		public UKTaxBand(int lowerBoundary, int upperBoundary, int taxRate)
		{
			LowerLimit = lowerBoundary;
			UpperLimit = upperBoundary;
			TaxRate = taxRate;
		}

		public int Id { get; set; }
		public int LowerLimit { get; set; }
		public int UpperLimit { get; set; }
		public int TaxRate { get; set; }
	}
}
