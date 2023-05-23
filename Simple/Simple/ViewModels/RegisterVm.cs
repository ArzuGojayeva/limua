using System.ComponentModel.DataAnnotations;

namespace Simple.ViewModels
{
    public class RegisterVm
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        [MaxLength(100),DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [MaxLength(100),DataType(DataType.Password)]
        public string Password { get; set; }
        [MaxLength(100), DataType(DataType.Password),Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }

    }
}
