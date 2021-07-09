using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class ControllerLogIn 
    {
        public string userName { get; set; }
        public string userPassword { get; set; }

        public ControllerLogIn(string userLogin, string userPassword)
        {
            this.userName = userLogin;
            this.userPassword = userPassword;
        }
        
        public string login()
        {
            string result;
            ModelPerson user = new ModelPerson();
            Console.WriteLine("" +user.getUserName(userName));
            if (userName == "")
                result = "You need to set an user name";
            else if (userPassword == "")
                result = "You need to set your password";
            else if (userName != user.getUserName(userName))
                result = "That user does not exist";
            else if (userPassword != user.getUserPassword(userPassword))
                result = "Incorrect password";
            else
            {
                user.personId = user.getUserId(userName);
                Session.userLogIn = userName;
                Session.userId = user.personId;
                Session.userRole = user.getUserRole();
                Session.userPassword = userPassword;
                result = "";
            }
                return result;

        }
        
        

        

    }
}
