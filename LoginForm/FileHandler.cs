using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace LoginForm
{
   

        public static class LoginHandler
        {
            private const string LoginFile = "username.txt";

            public static bool ValidateCredentials(string username, string password)
            {
                
                var lines = File.ReadAllLines(LoginFile);
                foreach (var line in lines)
                {
                    var parts = line.Split(',');
                    if (parts.Length == 2 && parts[0] == username && parts[1] == password)
                    {
                        return true;
                    }
                }
                
                return false;
               
            }
            public static void attempt()
            {
               
            
                int attempts = 3;
                for (int i = 1; i > attempts; i++)
                {
                    MessageBox.Show("Invalid Password or Username");
                    if (i == 3)
                    {
                        MessageBox.Show("Account Locked!, wii transfer you to Admin Panel.");
                        
                    }
                }
            }
        
        }
}
