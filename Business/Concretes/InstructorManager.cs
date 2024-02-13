using Business.Abstracts;
using DataAccess.Abstracts;
using Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes;

public class InstructorManager : IInstructorService
{
    private readonly IInstructorDal _instructorDal;

    public InstructorManager(IInstructorDal instructorDal)
    {
        _instructorDal = instructorDal;
    }

    public void TDelete(Instructor t)
    {
        _instructorDal.Delete(t);
    }

    public Instructor TGetByID(int id)
    {
        return _instructorDal.GetByID(id);
    }

    public List<Instructor> TGetList()
    {
        return _instructorDal.GetList();
    }

    public void TInsert(Instructor t)
    {
        _instructorDal.Insert(t);
    }

    public void TUpdate(Instructor t)
    {
        _instructorDal.Update(t);
    }
}