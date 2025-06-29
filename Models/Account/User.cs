using System.ComponentModel.DataAnnotations;
using NewsSite.Models.Posts;

namespace NewsSite.Models.Account
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "نام کاربری")]
        [Required]
        [MaxLength(50 , ErrorMessage ="تعداد حروف  نام کاربری زیاد است ")]
        public string UserName { get; set; }


        
        [Display(Name = "ایمیل")]
        [Required]
        [MaxLength(50, ErrorMessage = "تعداد حروف  ایمیل زیاد است ")]
        public string Email { get; set; }    
        
        
        [Display(Name = "رمزکاربری")]
        [Required]
        [MaxLength(50, ErrorMessage = "تعداد حروف  رمزکاربری زیاد است ")]
        public string Password { get; set; }


        [Display(Name = "تاریخ ثبت نام ")]
        public DateTime CreateDate { get; set; }


        public ICollection<Post> Posts { get; set; }
    }
}
