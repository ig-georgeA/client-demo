using Bunit;
using Microsoft.Extensions.DependencyInjection;
using ComponentDemosScenarios1.Pages;
using ComponentDemosScenarios1.IG_NorthwindAPI;

namespace TestComponentDemosScenarios1
{
	[Collection("ComponentDemosScenarios1")]
	public class TestSelection_detail
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbListModule),
				typeof(IgbSelectModule),
				typeof(IgbComboModule),
				typeof(IgbAvatarModule),
				typeof(IgbGridModule),
				typeof(IgbButtonModule),
				typeof(IgbRippleModule));
			ctx.Services.AddScoped<IIG_NorthwindAPIService>(sp => new MockIG_NorthwindAPIService());
			var componentUnderTest = ctx.RenderComponent<Selection_detail>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
