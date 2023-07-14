using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Newtonsoft.Json;
using ShoppingList.Models;
using ShoppingList.Services;
using ShoppingList.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ShoppingList.ViewModels
{
    public partial class LoginPageViewModel : BaseViewModel
    {
        [ObservableProperty]
        private String userName;
        
        [ObservableProperty]
        private String password;

        readonly ILoginRepository loginRepository = new LoginService();

        [ICommand]
        public async void Login()
        {
            if(!string.IsNullOrWhiteSpace(userName) && !string.IsNullOrWhiteSpace(password))
            {
                User user = await loginRepository.Login(userName, password);

                if(Preferences.ContainsKey(nameof(App.User))) 
                {
                    Preferences.Remove(nameof(App.User));
                }

                string userDetails = JsonConvert.SerializeObject(user);
                Preferences.Set(nameof(App.User),userDetails);
                App.User = user;

                await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
            }
        }
    }

     
}
