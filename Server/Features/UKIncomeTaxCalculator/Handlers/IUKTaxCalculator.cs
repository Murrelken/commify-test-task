using commify_test_task.Server.Features.UKIncomeTaxCalculator.Dtos;
using commify_test_task.Shared.Dtos;

namespace commify_test_task.Server.Features.UKIncomeTaxCalculator.Handlers
{
	public interface IUKTaxCalculator
	{
		TaxCalculationResults CalculateUKTaxes(UKTaxCalculatorInput input);
	}
}
