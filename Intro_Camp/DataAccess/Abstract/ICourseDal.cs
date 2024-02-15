using Intro_Camp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_Camp.DataAccess.Abstract;

public interface ICourseDal
{
    List<Course> Getall();

    void Add (Course course);
}
