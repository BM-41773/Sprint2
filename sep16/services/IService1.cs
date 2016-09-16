using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace facebookfinal.Views.Home
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        void DoWork();
        [OperationContract]
        string Login(string X_uname,string X_passwd);
        

    } 
        
        public class Logginuser
        { 
            public string Firstname { get; set; }
            public string Lastname { get; set; }
            public string Profilepic { get; set; }
            public string Password { get; set; }
            public string Username { get; set; }
            public int LoginID { get; set; }
            public string X_LoginID { get; set; }
            public string Message { get; set; }

        }
        

    
}
