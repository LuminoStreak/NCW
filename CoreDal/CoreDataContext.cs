using System;
using System.Linq;
using System.Reflection;
using Microsoft.EntityFrameworkCore;  
  
namespace CoreDal
{  
    public class CoreDataContext:DbContext  
    {  
        public CoreDataContext(DbContextOptions<CoreDataContext> options) : base(options)  
        {  
            
        }  
        
        public DbSet<User> Users { get; set; }
        public DbSet<UserDepartment> UserDepartments { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)  
        {  
            base.OnModelCreating(modelBuilder);  
            // Type[] typesToRegister = Assembly.GetExecutingAssembly().GetTypes()
            // .Where(type => !String.IsNullOrEmpty(type.Namespace))
            // .Where(type => type.BaseType != null && type.BaseType.IsGenericType && type.BaseType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>));
            // foreach (var type in typesToRegister)
            // {                
            //     dynamic configurationInstance = Activator.CreateInstance(type);
            //     // modelBuilder.ApplyConfiguration.Add(configurationInstance);
            // }
            // new BaseEntityModelMap(modelBuilder);  
        }          

    }  
}  