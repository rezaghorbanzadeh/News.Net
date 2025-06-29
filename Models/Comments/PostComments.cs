using System.ComponentModel.DataAnnotations;
using NewsSite.Models.Posts;

namespace NewsSite.Models.Comments
{
    public class PostComments
    {
        [Key]
        public int Id { get; set; }
        public int PostId { get; set; }
        public int CommentId { get; set; }


        public Post Post { get; set; }
        public Comment Comment { get; set; }



    }
}
