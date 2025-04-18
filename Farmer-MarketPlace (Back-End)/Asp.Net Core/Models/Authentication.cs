﻿namespace DotnetBackend.Models
{
    public class Authentication
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public override string ToString()
        {
            return $"Authentication [Email={Email}, Password={Password}]";
        }
    }
}