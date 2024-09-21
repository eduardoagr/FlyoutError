using CommunityToolkit.Maui;

using FlyoutError.View;
using FlyoutError.ViewModels;

using Microsoft.Extensions.Logging;

using Syncfusion.Maui.Core.Hosting;

namespace FlyoutError {
    public static class MauiProgram {
        public static MauiApp CreateMauiApp() {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiCommunityToolkit()
                .UseMauiApp<App>()
                .ConfigureSyncfusionCore()
                .ConfigureFonts(fonts => {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<AppShell, AppShellViewModel>();
            builder.Services.AddSingleton<A>();
            builder.Services.AddSingleton<B>();

            return builder.Build();
        }
    }
}
