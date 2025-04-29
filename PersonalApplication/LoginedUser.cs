using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOrganizerApplication
{
    class LoginedUser
    {
        private Kullanici user;
        private static LoginedUser loginedUser;
        public Kullanici UserGetSet { get => user; set => user = value; }
        public static LoginedUser getInstance()
        {
            if (loginedUser == null)
            {
                loginedUser = new LoginedUser();
            }
            return loginedUser;
        }
    }
}
