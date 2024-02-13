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


Course course1 = new Course();
course1.Name = "C#";
course1.Description = "C# Microsoft usulü Java'dır.";
course1.Instructor = null;
course1.Category = null;
course1.Price = 50;

Course course2 = new Course();
course2.Name = "Java";
course2.Description = "Java açık kaynak kodlu, sıradan işletmeli, hem derlenen hem yorumlanan, derlendiğinde Java'nın byte koduna derlenen, JVM üzerinde yorumlanıp işletim sistemi koduna çevrilen, platform bağımsız programlama dili ve teknoloji imparatorluğudur. Hem derlenme hemde yorunlanması ve platform bağımsızlığı onu özel kılıyor. Bili the GTS C#'ı Java'dan Windows'u ise MacOS'dan çaldı.";
course2.Instructor = null;
course2.Category = null;
course2.Price = 50;

Category category = new Category()
{
    Courses = new List<Course>() { course1, course2 },
    Name = "Nesne Tabanlı Programlama"
};

Instructor instructor = new()
{
    Name = "Hüseyin",
    Surname = "AYDIN",
    Salary = 999999999,
    Courses = new List<Course> { course1, course2 }
};

InstructorManager instrcutorManager = new InstructorManager(new EfInstructorDal());
instrcutorManager.TInsert(instructor);