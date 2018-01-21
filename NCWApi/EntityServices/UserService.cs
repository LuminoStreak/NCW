using Core.Service;
using CoreDal.Repository;
using NCWApi.Entity;
using NCWApi.Repository;

namespace NCWApi.EntityService
{
    public interface IUserService : IEntityService<User>
    {
        
    }
    public class UserService : EntityService<User>, IUserService
    {
        IRepositoryUnit _repositoryUnit;
        IUserRepository _userRepository;
        public UserService(IRepositoryUnit repositoryUnit, IUserRepository repository) : base(repositoryUnit, repository)
        {
            _repositoryUnit = repositoryUnit;
            _userRepository = repository;
        }
    }
}