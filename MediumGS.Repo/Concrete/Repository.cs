using MediumGS.Data.Concrete;
using MediumGS.Repo.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace MediumGS.Repo.Abstract
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        protected readonly TestContext _context;
        protected DbSet<T> _entities { get; set; }

        // _context is disposed using .net core DI in Startup.cs
        public Repository(TestContext context)
        {
            _context = context;
            _entities = context.Set<T>();
        }

        public T GetSingle(int id)
        {
            return _entities.Where(e => e.Id == id).SingleOrDefault();
        }

        public IEnumerable<T> GetAll()
        {
            return _entities.AsEnumerable();
        }

        public void Insert(T entity)
        {
            _entities.Add(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _entities.Update(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            T entity = _entities.Where(e => e.Id == id).SingleOrDefault();
            entity.Deleted = true;
            _context.SaveChanges();
        }

        public void Remove(int id)
        {
            T entity = _entities.Where(e => e.Id == id).SingleOrDefault();
            _entities.Remove(entity);
            _context.SaveChanges();
        }
    }
}