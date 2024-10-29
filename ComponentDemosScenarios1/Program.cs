using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ComponentDemosScenarios1;
using ComponentDemosScenarios1.IG_NorthwindAPI;
using ComponentDemosScenarios1.FinTech_API;
using ComponentDemosScenarios1.Financial;
using ComponentDemosScenarios1.NestedDataRepeat;
using ComponentDemosScenarios1.Northwind;
using IgniteUI.Blazor.Controls;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IIG_NorthwindAPIService, IG_NorthwindAPIService>();
builder.Services.AddScoped<IFinTech_APIService, FinTech_APIService>();
builder.Services.AddScoped<IFinancialService, FinancialService>();
builder.Services.AddScoped<INestedDataRepeatService, NestedDataRepeatService>();
builder.Services.AddScoped<INorthwindService, NorthwindService>();
RegisterIgniteUI(builder.Services);

await builder.Build().RunAsync();

void RegisterIgniteUI(IServiceCollection services)
{
    services.AddIgniteUIBlazor(
        typeof(IgbNavbarModule),
        typeof(IgbIconButtonModule),
        typeof(IgbRippleModule),
        typeof(IgbNavDrawerModule),
        typeof(IgbNavDrawerItemModule),
        typeof(IgbGridModule),
        typeof(IgbListModule),
        typeof(IgbAvatarModule),
        typeof(IgbFinancialChartModule),
        typeof(IgbComboModule),
        typeof(IgbButtonModule),
        typeof(IgbSelectModule),
        typeof(IgbChipModule),
        typeof(IgbDataGridToolbarModule),
        typeof(IgbActionStripModule),
        typeof(IgbTreeGridModule),
        typeof(IgbTabsModule),
        typeof(IgbCardModule),
        typeof(IgbCalendarModule),
        typeof(IgbInputModule),
        typeof(IgbCategoryChartModule),
        typeof(IgbExpansionPanelModule),
        typeof(IgbTreeModule),
        typeof(IgbCheckboxModule),
        typeof(IgbAccordionModule),
        typeof(IgbStepperModule),
        typeof(IgbRatingModule),
        typeof(IgbDatePickerModule),
        typeof(IgbPivotDataSelector),
        typeof(IgbPieChartModule),
        typeof(IgbTextareaModule),
        typeof(IgbSliderModule),
        typeof(IgbRangeSliderModule),
        typeof(IgbBadgeModule),
        typeof(IgbButtonGroupModule),
        typeof(IgbToggleButtonModule),
        typeof(IgbSwitchModule),
        typeof(IgbRadioGroupModule),
        typeof(IgbRadioModule),
        typeof(IgbDropdownModule),
        typeof(IgbDropdownHeaderModule),
        typeof(IgbDropdownItemModule),
        typeof(IgbSnackbarModule)
    );
}