using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDevelopmentCenter.Shared.Authorization.Classes
{
    public enum SecurityRoleEnum
    {
        BASIC_USER = 1,
        ADMINISTRATOR = 2
    }
    public class User
    {
        public string DisplayName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string SecurityRole { get; set; }

        public User(string name, string user_name, string password, SecurityRoleEnum securityRole = SecurityRoleEnum.BASIC_USER)
        {
            this.DisplayName = name;
            this.UserName = user_name;
            this.Password = password;
            SecurityRole = securityRole == SecurityRoleEnum.BASIC_USER ? "BasicUser" : "Admin";
        }

    }
}
