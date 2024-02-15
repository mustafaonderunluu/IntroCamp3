using Intro_Camp.DataAccess.Concretes;
using Intro_Camp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Intro_Camp.Business;

public class CourseManager
{

    private readonly CourseDal _courseDal;

    public CourseManager(CourseDal courseDal)
    {
        _courseDal = courseDal; 
    }

    public List<Course> GetAll()
    {
        //Business Rules // şu şunu sağlıyorsa şu alınır mesela.

        return _courseDal.GetAll();
    }

}
