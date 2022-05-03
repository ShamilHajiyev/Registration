using System;
using System.Collections.Generic;
using System.Text;

namespace Registration
{
    class Admin : User
    {
        public bool IsSuperAdmin;
        public string Section;
        public Admin(string username, string password, bool isSuperAdmin, string section)
        {
            Username = username;
            Password = password;
            IsSuperAdmin = isSuperAdmin;
            Section = section;
        }
        public string GetInfo()
        {
            return $"Username: {Username}\nPassword: {Password}\n";
        }
    }
}
