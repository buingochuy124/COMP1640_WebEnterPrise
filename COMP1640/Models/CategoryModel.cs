using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace COMP1640.Models
{
    public class CategoryModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public string Name { get; set; }
        public bool IsActive﻿ { get; set; }
        public DateTime FinalClosureDate { get; set; }

        [NotMapped]
        public List<PostModel> Posts { get; set; }
    }
}
