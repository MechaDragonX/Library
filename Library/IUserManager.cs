using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    interface IUserManager
    {
        void Register(string Name, int PIN, string Password); // returns ID
        void Login(int PIN, string Password);
        void Logout(int UserID);
    }
}
