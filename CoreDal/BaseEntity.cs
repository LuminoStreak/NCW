using System;
using System.ComponentModel.DataAnnotations;

namespace CoreDal
{
   public class BaseEntity
    {  
        [Key]
        public Int64 Id { get; set; }  
        public DateTime AddedDate { get; set; }  
        public DateTime ModifiedDate { get; set; } = DateTime.UtcNow;    
    }  
}
