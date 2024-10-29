using Bunit;
using Microsoft.Extensions.DependencyInjection;
using ComponentDemosScenarios1.Pages;
using ComponentDemosScenarios1.NestedDataRepeat;

namespace TestComponentDemosScenarios1
{
	[Collection("ComponentDemosScenarios1")]
	public class TestExpansion_panels_tree
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbCardModule),
				typeof(IgbAvatarModule),
				typeof(IgbButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbExpansionPanelModule),
				typeof(IgbListModule),
				typeof(IgbTreeModule),
				typeof(IgbInputModule),
				typeof(IgbCheckboxModule),
				typeof(IgbAccordionModule));
			ctx.Services.AddScoped<INestedDataRepeatService>(sp => new MockNestedDataRepeatService());
			var componentUnderTest = ctx.RenderComponent<Expansion_panels_tree>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
