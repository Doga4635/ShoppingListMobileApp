using ShoppingList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingList.Services
{
    internal interface ILoginRepository
    {
        Task<User> Login(string username, string password);
    }
}
