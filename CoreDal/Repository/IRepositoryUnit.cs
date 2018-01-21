using System;
using Core.EntityMetaModel;

namespace CoreDal.Repository 
{
    public interface IRepositoryUnit : IDisposable
    {
        // IRepository<Model> ModelRepository { get; }
        // IRepository<TEntity> Repository<TEntity>() where TEntity : BaseEntity;

        void Save();
    }
}