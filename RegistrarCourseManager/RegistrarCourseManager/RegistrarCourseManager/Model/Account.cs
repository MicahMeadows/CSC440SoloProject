using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrarCourseManager.Model
{
    public class Account
    {
        public Account(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public string Username { get; set; }
        public string Password { get; set; }

        public override bool Equals(object obj)
        {
            var dst = obj as Account;
            bool userCheck = this.Username.Equals(dst.Username);
            bool passCheck = this.Password.Equals(dst.Password);

            return userCheck && passCheck;
        }
    }
}
