using Italbytz.Adapters.Meal.Mock;
using Italbytz.Ports.Meal;

namespace Mensa;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont(
                    "OpenSans-Regular.ttf",
                    "OpenSansRegular"
                );
                fonts.AddFont(
                    "OpenSans-Semibold.ttf",
                    "OpenSansSemibold"
                );
            });

        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<
            IGetMealsService,
            MockGetMealsService
        >();

        return builder.Build();
    }
}
