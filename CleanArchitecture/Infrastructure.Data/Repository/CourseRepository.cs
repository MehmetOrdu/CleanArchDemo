using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domain.Models;
using CleanArchitecture.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleanArchitecture.Infrastructure.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private UniversityDBContext _dBContext;
        public CourseRepository(UniversityDBContext dBContext)
        {
            _dBContext = dBContext;
        }

        public void Add(Course course)
        {
            _dBContext.Add(course);
            _dBContext.SaveChanges();

        }

        public IQueryable<Course> GetCourses()
        {
            return _dBContext.Courses;
        }
    }
}
