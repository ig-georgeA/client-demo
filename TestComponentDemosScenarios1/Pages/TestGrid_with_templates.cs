using Bunit;
using Microsoft.Extensions.DependencyInjection;
using ComponentDemosScenarios1.Pages;
using ComponentDemosScenarios1.IG_NorthwindAPI;

namespace TestComponentDemosScenarios1
{
	[Collection("ComponentDemosScenarios1")]
	public class TestGrid_with_templates
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbAvatarModule),
				typeof(IgbChipModule),
				typeof(IgbButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbGridModule));
			ctx.Services.AddScoped<IIG_NorthwindAPIService>(sp => new MockIG_NorthwindAPIService());
			var componentUnderTest = ctx.RenderComponent<Grid_with_templates>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
