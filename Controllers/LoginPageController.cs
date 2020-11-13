using Repair_Service.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repair_Service.Controllers
{
    public class LoginPageController
    {

        private Database database;
        private LocalUserData localUserData;

        public LoginPageController()
        {
            database = ProxyDatabase.GetDatabase();
            localUserData = new LocalUserData();
        }

        /// <summary>
        /// Metoda, pozwalająca na asynchroniczne logowanie za pomocą logina i hasła
        /// </summary>
        /// <param name="login">Login użytkownika</param>
        /// <param name="password">Hasło użytkownika</param>
        /// <returns>Zwraca TRUE jeżeli udało się zalogować</returns>
        public async Task<bool> SignInWithEmailAndPasswordAsync(string login, string password)
        {
            bool result = false;
            await Task.Run(() =>
                result = database.SingInWithLoginAndPassword(login, password)
            );
            return result;
        }

        /// <summary>
        /// Metoda, pozwalająca na asynchroniczne zapisanie danych logowania użytkownika do pliku
        /// </summary>
        /// <param name="login">Login użytkownika</param>
        /// <param name="password">Hasło użytkownika</param>
        public async Task SaveUserDataAsync(string login, string password)
        {
            await Task.Run(() =>
                localUserData.SaveUserLoginData(login, password)
            );
        }

        /// <summary>
        /// Metoda, pozwalająca na asynchroniczny odczyt danych logowania użytkownika z pliku
        /// </summary>
        /// <returns></returns>
        public async Task<List<string>> ReadUserDataAsync()
        {
            List<string> userCredentials = new List<string>();

            await Task.Run(() =>
                userCredentials = localUserData.ReadUserLoginData()
            );

            return userCredentials;
        }

        /// <summary>
        /// Metoda, pozwalająca na asynchroniczne usuwanie danych logowania użytkownika z pliku
        /// </summary>
        /// <returns></returns>
        public async Task DeleteuserDataAsync()
        {
            await Task.Run(() => 
                localUserData.DeleteUserLoginData()
            );
        }


    }
}
