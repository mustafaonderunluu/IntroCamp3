using Intro_Camp.Entity;

namespace Intro_Camp.DataAccess.Concretes;

public class EfCourseDal   //veritabanı ile çalışan katman 
{
    List<Course> Courses;    
    public EfCourseDal()   //gerçek veri tabanıymış gibi simüle ediyor
    {
        Course course1 = new Course();
        course1.Name = "jAVASCRİPT ";
        course1.Description = ".Net 8";
        course1.Id = 1;
        course1.Price = 122.1;

        Course course2 = new Course();
        course2.Name = "Java ";
        course2.Description = "  ";
        course2.Id = 2;
        course2.Price = 128.1;

        Course course3 = new Course();
        course3.Name = "php ";
        course3.Description = " ";
        course3.Id = 3;
        course3.Price = 130.1;

        Courses= new List<Course> {  course1, course2,course3 };

    }
    public List<Course> GelAll() { 
    

        //sql öğren 
    // Burada db işlemleri yapılır
    return Courses;
    
    }
    public void Add(Course course)
    {

        Courses.Add(course);

    }
}
public class CourseDal
{
    public List<Course> GetAll()
    {
        throw new NotImplementedException();
    }
}