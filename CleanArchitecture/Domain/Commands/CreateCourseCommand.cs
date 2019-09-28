﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Domain.Commands
{
    public class CreateCourseCommand : CourseCommand
    {
        public CreateCourseCommand(string name, string description, string imageUr)
        {
            Name = name;
            Description = description;
            ImageUrl = imageUr;
        }
    }
}
