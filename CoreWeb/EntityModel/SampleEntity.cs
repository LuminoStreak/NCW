using Core.EntityMetaModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityModel 
{  
    [Table("User")]
    public class User : AuditableEntity  
    {   
        [Required]       
        public string FirstName { get; set; }  
        [Required]
        public string LastName { get; set; }  
        [Required]
        public string Email { get; set; }  

        [ForeignKey("UserDepartmentId")]
        public UserDepartment UserDepartment { get; set;}
    }

    [Table("UserDepartment")]
    public class UserDepartment: AuditableEntity  
    {
        public int DeptNo { get; set; }
        [Required]
        [MaxLength(20)]
        public string DeptName { get; set; }
        [Required]
        [MaxLength(20)]
        public string Location { get; set; }
        [Required]
        public int Capacity { get; set; }
    }

}