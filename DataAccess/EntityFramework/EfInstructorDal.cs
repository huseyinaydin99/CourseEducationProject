using DataAccess.Abstracts;
using DataAccess.Concretes;
using DataAccess.Repositories;
using Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityFramework;

public class EfInstructorDal : GenericRepository<Instructor>, IInstructorDal
{

}