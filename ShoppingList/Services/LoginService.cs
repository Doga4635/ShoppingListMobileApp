using ShoppingList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingList.Services
{
    public class LoginService : ILoginRepository
    {
        public async Task<User> Login(string username, string password)
        {
            try
            {
                if(Connectivity.Current.NetworkAccess == NetworkAccess.Internet)
                {
                    var User = new User();
                    var client = new HttpClient();
                    string url = "";
                    client.BaseAddress = new Uri(url);
                    HttpResponseMessage response = await client.GetAsync("");
                    if (response.IsSuccessStatusCode)
                    {
                        User = await response.Content.ReadFromJsonAsync<User>();
                        return await Task.FromResult(User);
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }

                
          }

            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
