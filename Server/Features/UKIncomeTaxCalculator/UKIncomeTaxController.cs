using commify_test_task.Server.Features.UKIncomeTaxCalculator.Dtos;
using commify_test_task.Server.Features.UKIncomeTaxCalculator.Handlers;
using commify_test_task.Shared.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace commify_test_task.Server.Features.UKIncomeTaxCalculator
{
	[ApiController]
	[Route("[controller]")]
	public class UKIncomeTaxController : ControllerBase
	{
		private readonly IUKTaxCalculator _ukTaxCalculator;

		public UKIncomeTaxController(IUKTaxCalculator ukTaxCalculator)
		{
			_ukTaxCalculator = ukTaxCalculator;
		}

		[HttpGet("{grossAnnualSalary}")]
		public TaxCalculationResults Get(decimal grossAnnualSalary)
		{
			return _ukTaxCalculator.CalculateUKTaxes(new UKTaxCalculatorInput { GrossAnnualSalary = grossAnnualSalary });
		}
	}
}
