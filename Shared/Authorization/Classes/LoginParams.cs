using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDevelopmentCenter.Shared.Authorization.Classes
{
    public class LoginParams
    {
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public LoginParams(string username, string password)
        {
            this.UserName = username;
            this.Password = password;
        }
    }
}
