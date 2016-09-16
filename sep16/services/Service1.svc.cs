using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.SqlClient;
namespace facebookfinal.Views.Home
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class Service1 : IService1
    {
        public void DoWork()
        {
        }
        public string Login(string X_uname, string X_passwd)
        {
            SqlConnection con = new SqlConnection("Data Source=KUTTYCHATTAN-PC\\SQLEXPRESS;Initial Catalog=facebooklogin;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from Userlogin";
            //  cmd.Dispose();
            //con.Close();
            SqlDataReader rdr = cmd.ExecuteReader();
            Logginuser logg = new Logginuser();
            logg.Username = X_uname;
            logg.Password = X_passwd;
            while (rdr.Read())
            {
                if ((logg.Username.Equals(rdr["username"].ToString())) && (logg.Password.Equals(rdr["Password"].ToString())))
                {
                    logg.Firstname = rdr["Firstname"].ToString();
                    logg.Lastname = rdr["Lastname"].ToString();
                    logg.Username = rdr["Username"].ToString();
                    logg.LoginID = Convert.ToInt32(rdr["LogginId"].ToString());
                    logg.X_LoginID = logg.LoginID.ToString();
                    logg.Profilepic = rdr["Profilepic"].ToString();
                    string str = "LoginId:" + logg.LoginID + "Firstname:" + logg.Firstname + "Lastname:" + logg.Lastname + "Profilpic:" + logg.Profilepic + "Responsecode;200 Message;success";
                    return str;

                }
                else if ((logg.Username.Equals(rdr["username"].ToString())) && (!(logg.Password.Equals(rdr["password"].ToString()))))
                {
                    logg.Firstname = rdr["Firstname"].ToString();
                    logg.Lastname = rdr["Lastname"].ToString();
                    logg.Username = rdr["Username"].ToString();
                    logg.LoginID = Convert.ToInt32(rdr["LogginId"].ToString());
                    logg.X_LoginID = logg.LoginID.ToString();
                    logg.Profilepic = rdr["Profilepic"].ToString();
                    string str = "Responsecode;404 Message;Password incorrect";
                    return str;
                }
                else if (!(logg.Username.Equals(rdr["Username"].ToString())) && (!(logg.Password.Equals(rdr["Password"].ToString()))))
                {
                    logg.Firstname = rdr["Firstname"].ToString();
                    logg.Lastname = rdr["Lastname"].ToString();
                    logg.Username = rdr["Username"].ToString();
                    logg.LoginID = Convert.ToInt32(rdr["LogginId"].ToString());
                    logg.X_LoginID = logg.LoginID.ToString();
                    logg.Profilepic = rdr["Profilepic"].ToString();
                    string str = "Username:" + logg.Username +"Responsecode;500 Message;Email id doesnot exist";
                    return str;
                }







            }
            return null;

        }
    }
}