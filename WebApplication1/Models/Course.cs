﻿using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class Course
    {
        public Course()
        {
            Students = new HashSet<Student>();
        }

        public int Did { get; set; }
        public string Cname { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
