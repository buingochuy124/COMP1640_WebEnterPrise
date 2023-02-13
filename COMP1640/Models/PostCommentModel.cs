using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace COMP1640.Models
{
    public class PostCommentModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }
        public AppUserModel User{get;set;}

        [ForeignKey("Post")]
        public string PostId { get; set; }
        public PostModel Post{get;set;}

        public bool IsAnonymous { get;set;}
        public string Content{get;set;}
    }
}
