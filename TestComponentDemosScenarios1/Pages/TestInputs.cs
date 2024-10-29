using Bunit;
using Microsoft.Extensions.DependencyInjection;
using ComponentDemosScenarios1.Pages;
using ComponentDemosScenarios1.Northwind;

namespace TestComponentDemosScenarios1
{
	[Collection("ComponentDemosScenarios1")]
	public class TestInputs
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbInputModule),
				typeof(IgbDatePickerModule),
				typeof(IgbTextareaModule),
				typeof(IgbChipModule),
				typeof(IgbAvatarModule),
				typeof(IgbSliderModule),
				typeof(IgbRangeSliderModule),
				typeof(IgbRatingModule),
				typeof(IgbButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbIconButtonModule),
				typeof(IgbBadgeModule),
				typeof(IgbButtonGroupModule),
				typeof(IgbToggleButtonModule),
				typeof(IgbSwitchModule),
				typeof(IgbCheckboxModule),
				typeof(IgbRadioGroupModule),
				typeof(IgbRadioModule));
			ctx.Services.AddScoped<INorthwindService>(sp => new MockNorthwindService());
			var componentUnderTest = ctx.RenderComponent<Inputs>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
