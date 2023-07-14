using ShoppingList;
using Microsoft.Maui.Controls;
using System;

namespace ShoppingList;

public partial class RegisterPageView : ContentPage
{
    public RegisterPageView()
    {
        InitializeComponent();
    }
    private void SignUpBtn_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }


}