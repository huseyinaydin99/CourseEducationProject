using Business.Abstracts;
using DataAccess.Abstracts;
using Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes;

public class InstructorManager : ICategoryService
{
    private readonly IInstructorDal _instructorDal;

    public InstructorManager(IInstructorDal instructorDal)
    {
        _instructorDal = instructorDal;
    }

    public void TDelete(Category t)
    {
        _instructorDal.Delete(t);
    }

    public Category TGetByID(int id)
    {
        return _instructorDal.GetByID(id);
    }

    public List<Category> TGetList()
    {
        return _instructorDal.GetList();
    }

    public void TInsert(Category t)
    {
        _instructorDal.Insert(t);
    }

    public void TUpdate(Category t)
    {
        _instructorDal.Update(t);
    }
}