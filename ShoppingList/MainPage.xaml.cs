using ShoppingList;
using Microsoft.Maui.Controls;
using System;


namespace ShoppingList;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;

        if (count == 1)
            SignInBtn.Text = $"Clicked {count} time";
        else
            SignInBtn.Text = $"Clicked {count} times";

        SemanticScreenReader.Announce(SignInBtn.Text);
    }

    private void OnButtonClick(object sender, EventArgs e)
    {
        Navigation.PushAsync(new RegisterPageView());
    }

    private async void GoToProfile(object sender, EventArgs e)
		{
		await Shell.Current.GoToAsync("Profile");
	}
}

