using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ScottPlot;
using System;
using System.Collections.Generic;
using System.Text;

namespace MauiMvvmApp;

internal partial class MainPageViewModel:ObservableObject
{
    [ObservableProperty]
    public partial List<double> DataX { get; set; } = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    [ObservableProperty]
    public partial List<double> DataY { get; set; } = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    public MainPageViewModel()
    {
        MyPlot.Add.Scatter(DataX,DataY);
        MyPlot.PlotControl?.Refresh();
    }

    [ObservableProperty]
    public partial Plot MyPlot { get; set; } = new Plot();

    [ObservableProperty]
    public partial string Title { get; set; } = "Hello, Maui MVVM!";

    [ObservableProperty]
    public partial int Count { get; set; }

    [ObservableProperty]
    public partial string ButtonText { get; set; } = "Click Me";

    [RelayCommand]
    private void Click()
    {
        Title = $"Clicked at {DateTime.Now:HH:mm:ss}";
        ButtonText = $"Clicked {++Count} time(s)";
    }

}
