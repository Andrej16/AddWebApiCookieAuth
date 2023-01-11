using System;

namespace AddWebApiCookieAuth.Models
{
    public class LoginCredentials
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
