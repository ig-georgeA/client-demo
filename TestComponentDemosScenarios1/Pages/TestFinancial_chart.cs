using Bunit;
using Microsoft.Extensions.DependencyInjection;
using ComponentDemosScenarios1.Pages;
using ComponentDemosScenarios1.FinTech_API;

namespace TestComponentDemosScenarios1
{
	[Collection("ComponentDemosScenarios1")]
	public class TestFinancial_chart
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbListModule),
				typeof(IgbAvatarModule),
				typeof(IgbFinancialChartModule));
			ctx.Services.AddScoped<IFinTech_APIService>(sp => new MockFinTech_APIService());
			var componentUnderTest = ctx.RenderComponent<Financial_chart>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
