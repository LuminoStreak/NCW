using CoreDal;

namespace EntityModel 
{  
    public class SampleEntityA : BaseEntity, IEntity  
    {  
        public string FirstName { get; set; }  
        public string LastName { get; set; }  
        public string Email { get; set; }  
        public string EnrollmentNo { get; set; }  
    }
}