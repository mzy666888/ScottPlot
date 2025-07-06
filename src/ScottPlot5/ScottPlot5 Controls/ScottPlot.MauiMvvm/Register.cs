using SkiaSharp.Views.Maui.Controls.Hosting;

namespace ScottPlot.MauiMvvm;

// All the code in this file is included in all platforms.
public static class Register
{
    public static MauiAppBuilder UseScottPlot(this MauiAppBuilder builder)
    {
        builder.UseSkiaSharp();
        return builder;
    }
}
