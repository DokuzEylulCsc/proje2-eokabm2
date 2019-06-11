using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2_OOP
{
    class Administrator : User
    {
        public Administrator(string userId, string password) : base(userId, password){}

        public override string ToString()
        {
            return "(Admin) " + " " + this.UserId;
        }
    }
}
