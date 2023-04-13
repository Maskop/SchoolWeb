using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;

namespace SchoolWeb.Models
{
    public class LoginViewModel
    {
        [EmailAddress(ErrorMessage = "Neplatná emailová adresa")]
        public string Email { get; set; } = "";

        [DataType(DataType.Password)]
        [Display(Name = "Heslo")]
        public string Password { get; set; }

        [Display(Name = "Neodhlašovat")]
        public bool RememberMe { get; set; }
    }
}
