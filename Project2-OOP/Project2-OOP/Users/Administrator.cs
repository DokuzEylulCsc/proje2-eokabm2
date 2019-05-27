using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2_OOP
{
    class Administrator : User
    {
        private string name;

        public Administrator(string userId, string password, string name) : base(userId, password)
        {
            this.name = name;
        }
    }
}
