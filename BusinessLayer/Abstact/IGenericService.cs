using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        T GetById(int id);
        void Add(T entity);
        void Delete(T entity);
        List<T> GetList();
        void Update(T entity);
    }
}
