using System.ComponentModel.DataAnnotations;

namespace TodoApi.ViewModels
{
    public class RegisterViewModel
    {
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        [DataType(DataType.Password)]
        [Required]
        public string? Password { get; set; }
    }
}
