using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace COMP1640.Models
{
    public class PostModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id {get;set;}
        public string Content {get;set;}
        public DateTime Date {get;set;}
        public bool IsApproved { get;set;}
        public bool IsActive { get; set; } 
        [ForeignKey("Category")]
        public string CategoryId { get; set; }
        public CategoryModel Category {get;set;}

        [ForeignKey("User")]
        public string UserId { get; set; }
        public AppUserModel User { get; set; }

        [NotMapped]
        public List<PostCommentModel> PostComments {get; set;}   
        public List<PostInteractModel> PostInteracts {get; set;}
    }
}
