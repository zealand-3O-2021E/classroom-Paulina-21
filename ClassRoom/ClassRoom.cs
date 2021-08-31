using System;
using System.Collections.Generic;

namespace ClassRoom
{
    public class ClassRoom
    {
        public string ClassName { get; set; }
        public List<Student> ClassList { get; set; }
        public DateTime SemesterStart { get; set; }

        public ClassRoom(string name, List<Student> list, DateTime Start)
        {
            ClassName = name;
            ClassList = list;
            SemesterStart = Start;
        }
    }
}