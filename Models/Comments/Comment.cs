using System.ComponentModel.DataAnnotations;

namespace NewsSite.Models.Comments
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = " نام کاربری")]
        [Required]
        [MaxLength(50, ErrorMessage = "نام کاربری نمیتواند از 350 کاراکتر بیشتر شود")]
        [MinLength(3, ErrorMessage = "نام کاربری  نمیتواند از 3 کاراکتر کمتر شود")]
        [DataType(DataType.Text)]
        public string UserName { get; set; }



        [Display(Name = "متن")]
        [Required]
        [MaxLength(350, ErrorMessage = "متن کامنت نمیتواند از 350 کاراکتر بیشتر شود")]

        [MinLength(3, ErrorMessage = "متن کامنت نمیتواند از 350 کاراکتر کمتر شود")]
        [DataType(DataType.Text)]
        public string Description { get; set; }


        [Display(Name = "تصویر خبر ")]
        [Required]
        public string ImageName { get; set; }


        [Display(Name = "تاریخ ثبت ")]
        public DateTime CreateDate { get; set; }

        public ICollection<PostComments> Comments { get; set; }

    }
}
