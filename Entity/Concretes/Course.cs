﻿using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concretes;

public class Course : IEntity
{
    public int CourseId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    //public int CategoryID { get; set; }
    public Category Category { get; set; } = null!;
    public Instructor Instructor { get; set; } = null!;
}