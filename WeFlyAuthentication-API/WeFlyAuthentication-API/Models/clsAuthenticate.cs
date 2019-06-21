using System.ComponentModel.DataAnnotations;

namespace WeFlyAuthentication_API.Models
{
    public class clsAuthenticate
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter valid Email Address.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter Password.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
