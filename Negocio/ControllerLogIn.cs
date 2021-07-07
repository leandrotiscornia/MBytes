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
        public string userLogin { get; set; }
        public string userPassword { get; set; }

        public ControllerLogIn(string userLogin, string userPassword)
        {
            this.userLogin = userLogin;
            this.userPassword = userPassword;
        }
        
        public string login()
        {
            string result;
            ModelPerson user = new ModelPerson();
            List<string> logInData = new List<string>();
            logInData = user.getLogInData(userLogin, userPassword);


           // result = "tbUser: " + userLogin + "dbUser: " + logInData[0];
               
            if (userLogin != logInData[0])
                result = "That user does not exist";
            else if (userPassword != logInData[1])
                result = "Incorrect password";
            else
            {
                user.personId = user.getUserId(userLogin);
                Session.userLogIn = userLogin;
                Session.userId = user.personId;
                Session.userRole = user.getUserRole();
                Session.userPassword = userPassword;
                result = "";
            }
                return result;

        }
        
        

        

    }
}
