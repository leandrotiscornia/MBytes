using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public static class ExceptionController
    {
        public static string handleException(Exception ex)
        {
            string message = null;
            Console.WriteLine("Exception: " + ex.Message);
           
            switch (ex.Message)
            {
                case "Unknown Database":
                    message = "Cannot connect to server, please try again. \n If the problem persists, contact the administrator"; break;
                case "Incorrect Database Credentials":
                    message = "Cannot connect to server, please try again. \n If the problem persists, contact the administrator"; break;
                case "Cannot Connect To Server":
                    message = "Cannot connect to server, please try again. \n If the problem persists, contact the administrator"; break;
                case "Access To Server Dennied":
                    message = "This terminal is not allowed to use this application"; break;
                case "Foregin Key Constraint Error":
                    message = "Invalid operation"; break;
                default:
                    message = "UNHANDLED EXCEPTION: " + ex.Message; break;
            }
            return message;
        }
    }
}
