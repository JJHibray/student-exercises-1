using System.Collections.Generic;

namespace StudentExercises
{

    class Student{
        public string firstName { get; set; }

        public string lastName { get; set; }

        public string slackHandle { get; set; }

        public Cohort studentCohort = new Cohort();

        public List<Exercise> excerciseList = new List<Exercise>();

    }
}