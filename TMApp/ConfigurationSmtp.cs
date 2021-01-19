using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TMApp
{
    public class ConfigurationSmtp
    {
        public static string smtpAddress = "smtp.gmail.com";
        public static int portNumber = 587;
        public static bool enableSSL = true;
        public static string from = "damyokunlola@gmail.com";
        public static string password = "mynameisokunlola";
    }
}