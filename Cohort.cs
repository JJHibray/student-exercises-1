using System;
using System.Collections.Generic;

namespace StudentExercises{

    class Cohort{
        public string cohortName { get; set; }

        public List<Student> studentList { get; set; } = new List<Student>();

        public List<Instructor> instructorList { get; set; } = new List<Instructor>();

    }
}