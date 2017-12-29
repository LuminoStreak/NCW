using System;

namespace CoreDal 
{
    public interface IEntity
    {        
        Int64 Id { get; set; }  
        DateTime AddedDate { get; set; }  
        DateTime ModifiedDate { get; set; }         
    }
}