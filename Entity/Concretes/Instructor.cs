using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concretes;

public class Instructor : IEntity
{
    public int InstructorId { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public decimal Salary { get; set; }
    public List<Course> Courses { get; set; }
}