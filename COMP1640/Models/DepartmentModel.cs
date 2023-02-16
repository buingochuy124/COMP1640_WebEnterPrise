using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace COMP1640.Models
{
    public class DepartmentModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public string Name { get; set; }

        [ForeignKey("User")]
        public string CordinatorId { get; set; }
        public AppUserModel Cordinator { get; set; }
    }
}
