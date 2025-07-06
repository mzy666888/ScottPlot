namespace ScottPlot.MauiMvvm;

public static class PlotExtension
{
    public static void Refresh(this Plot plot)
    {
        plot.Axes.AutoScale();
        plot.PlotControl?.Refresh();
    }
}
