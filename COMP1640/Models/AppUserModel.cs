using Microsoft.AspNetCore.Identity;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace COMP1640.Models
{
    public class AppUserModel : IdentityUser<string>
    {
      

        public string Address {get;set;}
        public string FirstName {get;set;}
        public string LastName {get;set;}

        [NotMapped]
        public List<PostCommentModel> PostComments {get;set;}

        [ForeignKey("Department")]
        public string DepartmentId { get; set; }
        public DepartmentModel Department { get; set; }
       

        [NotMapped]
        public List<PostInteractModel> postInteracts {get;set;}  
    }
}
