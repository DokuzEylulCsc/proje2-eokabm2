using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2_OOP
{
    abstract class User
    {
        private string userId;
        private string password;

        protected User(string userId, string password)
        {
            this.userId = userId;
            this.password = password;
        }

        private string UserId { get => userId; }

    }
}
