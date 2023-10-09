using Microsoft.EntityFrameworkCore;
using Stock_Control_Infrastructure.Interfaces;
using Stock_Control_Infrastructure.Repositories;
using Stock_Control_Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Control_Services.Services
{
    public class BaseService<T> : IBaseService<T> where T : class
    {
        public IBaseRepository<T> _repository;
        public BaseService(BaseRepository<T> repository)
        {
            _repository = repository;
        }
        public IEnumerable<T> Get()
        {
            return _repository.Get();
        }
        public IEnumerable<T> Get(Expression<Func<T, bool>> predicate)
        {
            return _repository.Get(predicate);
        }
        public T? GetById(Expression<Func<T, bool>> predicate)
        {
            return _repository.GetById(predicate);
        }
        public void Add(T entity)
        {
            _repository.Add(entity);
        }
        public void Delete(T entity)
        {
            _repository.Delete(entity);
        }
        public void Update(T entity)
        {
            _repository.Update(entity);
        }
    }
}
