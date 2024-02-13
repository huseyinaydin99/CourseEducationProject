using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts;

public interface IGenericDal<T> where T : class, IEntity, new()
{
    void Insert(T t);
    void Update(T t);
    void Delete(T t);
    List<T> GetList();
    T GetByID(int id);
}