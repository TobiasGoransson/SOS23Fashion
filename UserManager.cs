using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace SOSFashion
{
    public class UserManager
    {
        public bool isloggedin=false;
        List<User> users = new List<User>();
        string userFilePath = "Users/Users.csv";
        

        public UserManager() 
        {
            

        }

        public List<User> CreateUserList()
        {
            using (StreamReader sr = new StreamReader(userFilePath))
            {
                string nextLine = sr.ReadLine();
                while (nextLine != null)
                {
                    string[] variables = nextLine.Split(';');

                    User user = new User(variables[0], variables[1], variables[2], variables[3], variables[4], variables[5], variables[6], variables[7]);
                    users.Add(user);
                    nextLine = sr.ReadLine();
                }
            }
            return users;
        }

        public void RegisterNewUser(User user)
        {
            using (StreamWriter sw = File.AppendText(userFilePath))
            {
                sw.WriteLine(user.GetCSV());
            }
        }
        public bool Isloggedin()
        {
            return isloggedin = true;
        }
    }
}
