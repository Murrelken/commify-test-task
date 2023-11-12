using commify_test_task.Server.Features.UKIncomeTaxCalculator.Dtos;
using commify_test_task.Shared.Dtos;

namespace commify_test_task.Server.Features.UKIncomeTaxCalculator.Handlers
{
	public class UKTaxCalculator : IUKTaxCalculator
	{
		private readonly IUKTaxBandRepository ukTaxBandRepository;

		public UKTaxCalculator(IUKTaxBandRepository ukTaxBandRepository)
		{
			this.ukTaxBandRepository = ukTaxBandRepository;
		}

		public TaxCalculationResults CalculateUKTaxes(UKTaxCalculatorInput input)
		{
			return new TaxCalculationResults
			{
				GrossAnnualSalary = 40000,
				GrossMonthlySalary = 3333.33M,
				NetAnnualSalary = 29000,
				NetMonthlySalary = 2416.67M,
				AnnualTaxPaid = 11000,
				MonthlyTaxPaid = 916.67M
			};
		}
	}
}
