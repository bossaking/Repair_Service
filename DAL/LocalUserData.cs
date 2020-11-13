using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repair_Service.DAL
{
    public class LocalUserData
    {

        public LocalUserData()
        {

        }

        public List<string> ReadUserLoginData()
        {
            if (!UserDataExists())
                return null;

            List<string> userCredentials = new List<string>();
            using(StreamReader streamReader = new StreamReader("data.txt"))
            {
                userCredentials.Add(streamReader.ReadLine());
                userCredentials.Add(streamReader.ReadLine());
            }

            return userCredentials;
        }

        public void SaveUserLoginData(string login, string password)
        {
            if (UserDataExists()) return; 
            using (StreamWriter streamWriter = new StreamWriter("data.txt"))
            {
                streamWriter.WriteLine(login);
                streamWriter.WriteLine(password);
            }
        }

        public void DeleteUserLoginData()
        {
            if (!UserDataExists())
                return;
            File.Delete("data.txt");
        }

        public bool UserDataExists()
        {
            return File.Exists("data.txt");
        }

    }
}
