using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Prolab2
{
    public interface ILoginable
    {
        void Login(string kullaniciAdi, string sifre);
    }

    public abstract  class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
        public virtual bool CheckCredentials(string enteredUsername, string enteredPassword)
        {
            return Username == enteredUsername && Password == enteredPassword;
        }
        public abstract bool Login(string enteredUsername, string enteredPassword);
        
    }
    public class Admin : User
    {
        public string AdminRole { get; set; }

        public Admin(string username, string password, string adminRole) : base(username, password)
        {
           
            AdminRole = adminRole;
        }
        public bool CheckAdminLogin(string enteredUsername, string enteredPassword)
        {
            return Username == enteredUsername && Password == enteredPassword;
        }
        public override bool Login(string enteredUsername, string enteredPassword)
        {
            if (CheckCredentials(enteredUsername, enteredPassword))
            { 
                AdminEkrani adminScreen = new AdminEkrani();
                adminScreen.Show();
                return true;
            }
            return false;
        }

    }
}
    

    

        
