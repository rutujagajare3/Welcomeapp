using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeApp
{
    public class Signin
    {
        public string Authenticate(string userName, string password)
        {
            string msg;
                if ((string.IsNullOrEmpty(userName)) || string.IsNullOrEmpty(password))
            {
                msg = "User name and password requires";
            }
            else
            {
                if ((userName == "admin") && (password == "admin@1256")){
                    msg = "Authentication Pass";
                }
                else
                {
                    msg = "Authentication Fail";
                }

            }
            return msg;
        }

    }
    }
