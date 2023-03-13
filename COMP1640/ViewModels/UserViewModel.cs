using Microsoft.AspNetCore.Identity;

namespace COMP1640.ViewModels
{
    public class UserViewModel
    {
        public string Id { get; set; }
        public string Address { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName    {get;set;}
        public string Email       {get;set;}
        public string Password{get;set;}
        public string PhoneNumber {get;set;}
        public string RolesName { get; set; }

        public string DepartmentId { get; set; }
    }
    
}
