using System.ComponentModel.DataAnnotations;

namespace NewsSite.ViewsModels.Account;

public class LoginVieModel
{
        [Display(Name = "ایمیل")]
        [Required]
        [MaxLength(50, ErrorMessage = "تعداد حروف  ایمیل زیاد است ")]
        public string Email { get; set; }

        [Display(Name = "رمزکاربری")]
        [Required]
        [MaxLength(50, ErrorMessage = "تعداد حروف  رمزکاربری زیاد است ")]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
}

public enum LoginResult
{
        Success,
        Error,
        NotFound
}


