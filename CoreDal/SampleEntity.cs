using CoreDal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreDal 
{  
    [Table("Users")]
    public class User : BaseEntity, IEntity  
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

    [Table("UserDepartments")]
    public class UserDepartment: BaseEntity, IEntity  
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