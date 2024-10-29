using Bunit;
using Microsoft.Extensions.DependencyInjection;
using ComponentDemosScenarios1.Pages;
using ComponentDemosScenarios1.IG_NorthwindAPI;

namespace TestComponentDemosScenarios1
{
	[Collection("ComponentDemosScenarios1")]
	public class TestStepper
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbStepperModule),
				typeof(IgbInputModule),
				typeof(IgbButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbGridModule));
			ctx.Services.AddScoped<IIG_NorthwindAPIService>(sp => new MockIG_NorthwindAPIService());
			var componentUnderTest = ctx.RenderComponent<Stepper>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
