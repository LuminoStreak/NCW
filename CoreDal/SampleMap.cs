using Microsoft.EntityFrameworkCore.Metadata.Builders;  
  
namespace CoreDal 
{  
    public class SampleMap  
    {  
        public SampleMap(EntityTypeBuilder<SampleEntity> entityBuilder)  
        {  
            entityBuilder.HasKey(t => t.Id);  
            entityBuilder.Property(t => t.FirstName).IsRequired();  
            entityBuilder.Property(t => t.LastName).IsRequired();  
            entityBuilder.Property(t => t.Email).IsRequired();  
            entityBuilder.Property(t => t.EnrollmentNo).IsRequired();  
        }  
    }  
} 