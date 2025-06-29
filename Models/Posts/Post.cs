using System.ComponentModel.DataAnnotations;
using NewsSite.Models.Account;
using NewsSite.Models.Comments;
using NewsSite.Models.Categories;

namespace NewsSite.Models.Posts
{
    public class Post
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = " عنوان خبر")]
        [Required]
        [MaxLength(350, ErrorMessage = "عنوان حبر نمیتواند از 350 کاراکتر بیشتر شود")]
        public string Title { get; set; }



        [Display(Name = "متن")]
        [Required]
        public string Description { get; set; }


        [Display(Name = "تصویر خبر ")]
        [Required]
        public string ImageName { get; set; }


        [Display(Name = "تاریخ ثبت ")]
        public DateTime CreateDate { get; set; }


        public User User { get; set; }
        public ICollection<PostComments> Comments { get; set; }
        public ICollection<Category> Categories { get; set; }

    }
}
