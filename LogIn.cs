using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feature1.Assignment
{
    public  class Login
    {
        public string Username { get; set; }
        public string Password { get; set; }
        //variable declaration, with properties

             public static void getUserCredentials()
             {
               string username;
               string password;
               Console.WriteLine("Create Username");
               username = Console.ReadLine();
               Console.WriteLine("Create Password");
               password = Console.ReadLine();
               
               
                Login User1 = new Login();
                
                //object creation 


                Console.WriteLine("WATER UTILLITIES CORPORATION ; we keep it flowing for you");
                Console.WriteLine("***********************************************************");
                Console.WriteLine("Enter Username");
                User1.Username = Console.ReadLine();
               
                Console.WriteLine("Enter Password");
                User1.Password = Console.ReadLine();

              if (User1.Username == username && User1.Password == password)
              {

                Console.WriteLine("Login Successfull") ;
                File.AppendAllText("LogReport.cs", "Login Successfull" + DateTime.Now);
              }
              else
              {
                Console.WriteLine("Login Failed, Please try again");
                getUserCredentials();
                File.AppendAllText("LogReport.cs","Login Failed" + DateTime.Now);
              }
             
             }
        
    }
}
    

