using Bunit;
using Microsoft.Extensions.DependencyInjection;
using ComponentDemosScenarios1.Pages;
using ComponentDemosScenarios1.Financial;

namespace TestComponentDemosScenarios1
{
	[Collection("ComponentDemosScenarios1")]
	public class TestCategory_charts
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbCategoryChartModule),
				typeof(IgbPieChartModule),
				typeof(IgbGridModule));
			ctx.Services.AddScoped<IFinancialService>(sp => new MockFinancialService());
			var componentUnderTest = ctx.RenderComponent<Category_charts>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
