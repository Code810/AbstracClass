﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstracClass.Domain.Models
{
    public class Student:Person
    {
        public string Group { get; set; }
        public string Specialty { get; set; }
    }
}
