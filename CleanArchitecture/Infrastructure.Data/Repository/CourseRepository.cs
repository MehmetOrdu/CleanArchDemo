﻿using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domain.Models;
using CleanArchitecture.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
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
        public IEnumerable<Course> GetCourses()
        {
            return _dBContext.Courses;
        }
    }
}
