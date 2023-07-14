using ShoppingList.Views;

namespace ShoppingList;

public partial class ProfilePage : ContentPage
{
	public ProfilePage()
	{
		InitializeComponent();

       

    }

	public void Edit(object sender, EventArgs e)
	{
        Navigation.PushAsync(new UpdateProfilePage());
    }

	
}