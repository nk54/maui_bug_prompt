﻿namespace MauiAppli;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnCounterClicked(object sender, EventArgs e)
    {
        string result;

        result = await Application.Current!.MainPage!.DisplayPromptAsync(
            "Default keyboard works",
            "DisplayPrompt works with classic keyboard in release mode");

        result = await Application.Current!.MainPage!.DisplayPromptAsync(
            "Numeric keyboard is broken",
            "DisplayPrompt is broken in release mode when using numeric keyboard",
            keyboard: Keyboard.Numeric);

        string breakpoint = result;
    }
}
