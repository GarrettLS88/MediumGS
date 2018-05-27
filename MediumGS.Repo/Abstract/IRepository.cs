using MediumGS.Data.Abstract;
using System.Collections.Generic;

namespace MediumGS.Repo.Abstract
{
    public interface IRepository<T> where T : IEntity
    {
        IEnumerable<T> GetAll();
        T GetSingle(int id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(int id);
        void Remove(int id);
    }
}
