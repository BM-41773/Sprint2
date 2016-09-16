using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace facebookfinal.Models
{
    public class ModalClass
    {
        public string name="";
        public string pwd="";
        public string x_username
    {
        get
        {
            return name;
        }
            set
            {
                name=value;
            }
    }
        public string x_password
        {
            get
            {
                return pwd;
            }
            set
            {
                pwd = value;
            }
        }
        public string login()
        {
            ServiceReference1.Service1Client ser1 = new ServiceReference1.Service1Client();
            String msg=ser1.Login(x_username, x_password);
            return msg;

        }
    }
}
