using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Informacion_Geografico
{
    class User
    {
        private int idUser;
        private string userName;
        private int userLevel;
        private string password;

        public int IdUser
        {
            get { return idUser; }
            set { idUser = value; }
        }

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public int UserLevel
        {
            get { return userLevel; }
            set { userLevel = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}
