namespace commify_test_task.Server.Features.UKIncomeTaxCalculator.Dtos
{
	public class UKTaxBandData
	{
		public int LowerLimit { get; set; }
		public int? UpperLimit { get; set; }
		public int TaxRate { get; set; }
	}
}
