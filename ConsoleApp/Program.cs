using Business.Concretes;
using DataAccess.EntityFramework;
using Entity.Concretes;


// Created by Hüseyin AYDIN...

//بسم الله الرحمن الرحيم
/**
 *
 * @author Huseyin_Aydin
 * @since 1994
 * @category C#, .NET Core...
 * Selamlar Engin Demiroğ hocam nasılsın?
 * Benimle iletişime geç huseyniaydin99@gmail.com
 *
 */


Category category = new Category()
{
    //Courses = new List<Course>() { course1, course2 },
    Name = "Veritabanı Programlama"
};

Instructor instructor = new()
{
    Name = "Buğra",
    Surname = "Dost",
    Salary = 8000,
    //Courses = new List<Course> { course1, course2 }
};

Course course1 = new Course();
course1.Name = "TSQL";
course1.Description = "TSQL MSSQLServer'ın Procedural dilidir.";
course1.Instructor = null;
course1.Category = null;
course1.Price = 50;

Course course2 = new Course();
course2.Name = "PL/SQL";
course2.Description = "PL/SQL Oracle'ın Procedural dilidir.";
course2.Instructor = instructor;
course2.Category = category;
course2.Price = 50;

instructor.Courses.Add(course1);
instructor.Courses.Add(course2);

category.Courses.Add(course1);
category.Courses.Add(course2);


//Insert
/*
InstructorManager instrcutorManager = new InstructorManager(new EfInstructorDal());
instrcutorManager.TInsert(instructor);*/

CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
categoryManager.TInsert(category);

/*
CourseManager courseManager = new CourseManager(new EfCourserDal());
courseManager.TInsert(course1);
courseManager.TInsert(course2);*/

Console.WriteLine("Kayıt işlemi başarılı");