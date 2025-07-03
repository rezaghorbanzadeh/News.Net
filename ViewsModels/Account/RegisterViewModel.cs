using System.ComponentModel.DataAnnotations;

namespace NewsSite.ViewsModels.Account;

public class RegisterViewModel
{
        [Display(Name = "نام کاربری")]
        [Required]
        [MaxLength(50, ErrorMessage = "تعداد حروف  نام کاربری زیاد است ")]
        public string UserName { get; set; }

        [Display(Name = "ایمیل")]
        [Required]
        [MaxLength(50, ErrorMessage = "تعداد حروف  ایمیل زیاد است ")]
        public string Email { get; set; }

        [Display(Name = "رمزکاربری")]
        [Required]
        [MaxLength(50, ErrorMessage = "تعداد حروف  رمزکاربری زیاد است ")]
        public string Password { get; set; }


}

public enum RegisterResult
{
        Success,
        Error,
        EmailExsist
}


