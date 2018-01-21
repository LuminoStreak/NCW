using CoreDal.Repository;
using Microsoft.EntityFrameworkCore;
using NCWApi.Entity;
using NCWApi.Repository;

namespace Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
       public UserRepository(DbContext context): base(context)
       {
           
       }       
   }
}