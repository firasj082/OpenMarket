
using System.ComponentModel.DataAnnotations;


namespace projectweb.Models
{
    public class user
    {
     public int userid { get; set; }
    
        [Required(ErrorMessage = "Please enter a name.")]
        public string Username { get; set; } = string.Empty ;

        [Required(ErrorMessage = "Please enter a password.")]
        public string Password { get; set; }
       
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter a phone number.")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please enter your credit card number.")]
        public string Ccnum { get; set; } //credit card number
    }
}
