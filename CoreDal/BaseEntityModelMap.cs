using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;  

namespace CoreDal 
{  
    public class BaseEntityModelMap 
    {  
        public BaseEntityModelMap(ModelBuilder modelBuilder)  
        {  
           
        }

        public void AddEntityModelMap(BaseEntity entity)
        {

        } 
    }

    public class EntityModelmapper<T> where T:class,IEntity
    {
        public void AddEntityModelMap(EntityTypeBuilder<T> entityTypeBuilder)
        {

        }
    }  
} 