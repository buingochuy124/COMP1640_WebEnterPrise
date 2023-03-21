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

        public bool IsActive﻿ { get; set; }
        public bool IsAnonymous { get; set; }

        [ForeignKey("Category")]
        public string CategoryId { get; set; }
        public string CategoryName { get; set; }
        public DateTime CategoryClosureDate { get; set; }

        public CategoryModel Category {get;set;}

        [ForeignKey("User")]
        public string UserId { get; set; }
        public AppUserModel User { get; set; }

        public List<PostCommentModel> PostComments {get; set;}   
        public List<PostInteractModel> PostInteracts {get; set;}
    }
}
