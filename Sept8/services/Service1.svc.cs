using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.SqlClient;
using Newtonsoft.Json;
namespace facebookfinal.Views.Home
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class Service1 : IService1
    {
        public void DoWork()
        {
        }
        public string Login()
        {
            SqlConnection con = new SqlConnection("Data Source=KUTTYCHATTAN-PC;Integrated Security=True");
            string str;
            con.Open();
            str = "select * from  Userlogin";
            SqlCommand cmd = con.CreateCommand();
          //  cmd.Dispose();
            //con.Close();
            SqlDataReader rdr=cmd.ExecuteReader();
            Logginuser logg =new Logginuser();
            while(rdr.Read())
            {
                if(((logg.LoginID.Equals(rdr["LoginID"].ToString()))&&(((logg.Password.Equals(rdr["Password"].ToString())))
                {     
                    logg.LoginID=rdr["LoginID"].ToString();
                    logg.Password=rdr["Password"].ToString();

                }
            }


           
        
        }  
    }

