﻿using COMP1640.Models;
using System.Collections.Generic;

namespace COMP1640.ViewModels
{
    public class CategoriesViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public bool IsActive﻿ { get; set; }

        public List<PostModel> Posts { get; set; }
    }
}
