using commify_test_task.Server.Features.UKIncomeTaxCalculator.Dtos;
using commify_test_task.Shared.Dtos;

namespace commify_test_task.Server.Features.UKIncomeTaxCalculator.Handlers
{
	public class UKTaxCalculator : IUKTaxCalculator
	{
		private readonly IUKTaxBandRepository _ukTaxBandRepository;

		public UKTaxCalculator(IUKTaxBandRepository ukTaxBandRepository)
		{
			_ukTaxBandRepository = ukTaxBandRepository;
		}

		public TaxCalculationResults CalculateUKTaxes(UKTaxCalculatorInput input)
		{
			var grossAnnual = Math.Round(input.GrossAnnualSalary, 2);
			var taxBands = _ukTaxBandRepository.GetUKTaxBandsData();
			var annualTax = 0M;

			foreach (var taxBand in taxBands)
			{
				if (taxBand.LowerLimit >= grossAnnual) continue;

				var taxableAmount = taxBand.UpperLimit == null
					? grossAnnual - taxBand.LowerLimit
					: Math.Min(taxBand.UpperLimit.Value - taxBand.LowerLimit, grossAnnual - taxBand.LowerLimit);

				annualTax += taxableAmount / 100 * taxBand.TaxRate;
			}

			var netAnnual = grossAnnual - annualTax;

			return new TaxCalculationResults
			{
				GrossAnnualSalary = grossAnnual,
				GrossMonthlySalary = Math.Round(grossAnnual / 12, 2),
				NetAnnualSalary = Math.Round(netAnnual, 2),
				NetMonthlySalary = Math.Round(netAnnual / 12, 2),
				AnnualTaxPaid = Math.Round(annualTax, 2),
				MonthlyTaxPaid = Math.Round(annualTax / 12, 2)
			};
		}
	}
}
