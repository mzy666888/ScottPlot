using Microsoft.Extensions.Logging;
using MPowerKit.Navigation;
using MPowerKit.Navigation.Utilities;
using ScottPlot.MauiMvvm;

namespace MauiMvvmApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseScottPlot()
                .UseMPowerKitNavigation(powerBuilder =>
                {
                    powerBuilder.ConfigureServices(services =>
                    {
                        
                        services.RegisterForNavigation<MainPage, MainPageViewModel>();
                       
                    }).OnAppStart("NavigationPage/MainPage");
                })
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
