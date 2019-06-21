using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeFlyAuthentication_API.Models
{
    public class clsUser
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false,ErrorMessage ="Please enter First Name.")]
        [DataType(DataType.Text)]
        public string FirstName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter Last Name.")]
        [DataType(DataType.Text)]
        public string LastName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter valid Email Address.")]
        [DataType(DataType.EmailAddress)]
        [Key]
        public string Email { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter Password.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter Mobile No.")]
        [DataType(DataType.PhoneNumber)]
        public string ContactNo { get; set; }
    }
}
