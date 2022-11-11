using System;
using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class ForgotPassword
    {

        [Required, EmailAddress, Display(Name = "Registered email address")]
        public string Email { get; set; }

        public int MyProperty { get; set; }

    }
}
