using commify_test_task.Server.Features.UKIncomeTaxCalculator.Dtos;
using commify_test_task.Server.Features.UKIncomeTaxCalculator.Handlers;
using Moq;

namespace UKTaskCalculatorTests
{
	public class UKTaskCalculatorTests
	{
		[Theory]
		[InlineData(10000, 833.33, 9000, 750, 1000, 83.33)]
		[InlineData(40000, 3333.33, 29000, 2416.67, 11000, 916.67)]
		[InlineData(5000, 416.67, 5000, 416.67, 0, 0)]
		[InlineData(5001, 416.75, 5000.80, 416.73, 0.20, 0.02)]
		public void TestDefaultBands(decimal grossAnnualSalary, decimal expectedGrossMonthlySalary,
			decimal expectedNetAnnualSalary, decimal expectedNetMonthlySalary, decimal expectedAnnualTaxPaid, decimal expectedMonthlyTaxPaid)
		{
			var ukTaxBandProviderMock = new Mock<IUKTaxBandProvider>();
			ukTaxBandProviderMock.Setup(x => x.GetUKTaxBandsData())
				.Returns(new List<UKTaxBandData>
				{
					new UKTaxBandData()
					{
						LowerLimit = 0,
						UpperLimit = 5000,
						TaxRate = 0
					},
					new UKTaxBandData()
					{
						LowerLimit = 5000,
						UpperLimit = 20000,
						TaxRate = 20
					},
					new UKTaxBandData()
					{
						LowerLimit = 20000,
						UpperLimit = null,
						TaxRate = 40
					}
				});

			var ukTaxCalculator = new UKTaxCalculator(ukTaxBandProviderMock.Object);

			var results = ukTaxCalculator.CalculateUKTaxes(new UKTaxCalculatorInput() { GrossAnnualSalary = grossAnnualSalary });

			Assert.Equal(grossAnnualSalary, results.GrossAnnualSalary);
			Assert.Equal(expectedGrossMonthlySalary, results.GrossMonthlySalary);
			Assert.Equal(expectedNetAnnualSalary, results.NetAnnualSalary);
			Assert.Equal(expectedNetMonthlySalary, results.NetMonthlySalary);
			Assert.Equal(expectedAnnualTaxPaid, results.AnnualTaxPaid);
			Assert.Equal(expectedMonthlyTaxPaid, results.MonthlyTaxPaid);
		}
	}
}