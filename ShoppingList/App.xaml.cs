using ShoppingList.Models;

namespace ShoppingList;

public partial class App : Application
{ 
	public static User User;

	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
