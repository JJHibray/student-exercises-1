using System;
using System.Collections.Generic;

namespace StudentExercises{

    class Cohort{
        public string cohortName { get; set; }

        public List<Student> studentList = new List<Student>();

        public List<Instructor> instructorList = new List<Instructor>();

    }
}