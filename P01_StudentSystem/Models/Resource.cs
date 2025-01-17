﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Models
{
    internal class Resource
    {
        public int ResourceId { get; set; }
        public string Name { get; set; }  
        public string Url { get; set; }
        public ResourceTypeEnum ResourceType { get; set; }//enum
        
        public int CourseId { get; set; }
        public Course Course { get; set; }  

    }
}
