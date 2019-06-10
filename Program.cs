using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {

            Exercise VinylGrayl = new Exercise()
            {
                name = "VinylGrayl",
                language = "JavaScript"
            };

            Exercise Kennels = new Exercise()
            {
                name = "kennels",
                language = "JavaScript"
            };

            Exercise UrbanPlanner = new Exercise()
            {
                name = "Urban Planner",
                language = "C#"
            };

            Exercise EnglishIdioms = new Exercise()
            {
                name = "English Idioms",
                language = "C#"
            };


            Cohort C31 = new Cohort()
            {
                cohortName = "Cohort 31",

            };


            Cohort C30 = new Cohort()
            {
                cohortName = "Cohort 30"
            };

            Cohort DS6 = new Cohort()
            {
                cohortName = "Data Science 6"
            };


            Student Josh = new Student()
            {
                firstName = "Josh",
                lastName = "Hibray",
                slackHandle = "JJHibray"
            };

            Josh.studentCohort = C31;

            Student Clif = new Student()
            {
                firstName = "Clifton",
                lastName = "Matuszewski",
                slackHandle = "Theskiman",
            };

            Clif.studentCohort = C31;

            Student Rose = new Student()
            {
                firstName = "Rose",
                lastName = "Wisotzky",
                slackHandle = "Rose_W"
            };

            Rose.studentCohort = C31;

            Student dumbStudent = new Student()
            {
                firstName = "Dumb",
                lastName = "Student",
                slackHandle = "Dumb_S"

            };



            Instructor Andy = new Instructor()
            {
                firstName = "Andy",
                lastName = "Collins",
                slackHandle = "Andy_C",
                specialty = "C-Sharpin'",

            };

            Andy.instructorsCohort = C31;

            Instructor Jisie = new Instructor()
            {
                firstName = "Jisie",
                lastName = "David",
                slackHandle = "Jisie_D",
                specialty = "J-Scriptin'"
            };

            Jisie.instructorsCohort = C31;

            Instructor Leah = new Instructor()
            {
                firstName = "Leah",
                lastName = "Hoefling",
                slackHandle = "Leah_H",
                specialty = "Jr-Instructin'"
            };

            Leah.addExcercise(EnglishIdioms, Josh);
            Leah.addExcercise(UrbanPlanner, Clif);
            Andy.addExcercise(EnglishIdioms, Clif);
            Andy.addExcercise(UrbanPlanner, Rose);
            Andy.addExcercise(UrbanPlanner, Rose);
            Jisie.addExcercise(Kennels, Josh);
            Jisie.addExcercise(VinylGrayl, Josh);
            Jisie.addExcercise(Kennels, Rose);
            Leah.addExcercise(UrbanPlanner, Josh);

            List<Student> students = new List<Student>(){
            Josh, Rose, Clif, dumbStudent
        };

            List<Exercise> exercises = new List<Exercise>(){
                VinylGrayl, Kennels, UrbanPlanner, EnglishIdioms
            };

            List<Cohort> Cohorts = new List<Cohort>() {
                C30, C31, DS6
            };

            List<Instructor> Instructors = new List<Instructor>(){
                Andy, Jisie, Leah
            };

            foreach (Student person in students)
            {
                Console.Write($"{person.firstName} {person.lastName} is working on these exercises:  ");
                foreach (Exercise assignment in person.excerciseList)
                {
                    Console.Write($"{assignment.name}, ");
                }
                Console.WriteLine();
            }
            var javaList = exercises.Where(exercise => exercise.language == "JavaScript");
            foreach(var excercise in javaList){
                Console.WriteLine(excercise.name);
            }

            var StudentC31 = students.Where(student => student.studentCohort == C31);
            foreach (var chort in StudentC31){
                Console.WriteLine(chort.firstName + chort.lastName);
            }

            var InstructorC31 = Instructors.Where(instructor => instructor.instructorsCohort == C31);
            foreach (var Ichort in InstructorC31){
                Console.WriteLine(Ichort.firstName);
            }

            var sLast = students.OrderBy(student => student.lastName); {
                foreach(var stu in sLast){
                    Console.WriteLine(stu.lastName);
                }
            }

            IEnumerable<Student> noExercise = students.Where(student => student.excerciseList.Count == 0
            );

            foreach(Student person in noExercise) {
                Console.WriteLine(person.firstName + "" + person.lastName);
            }

            Student mostExercises = students.Single(student => student.excerciseList.Count == students.Max(exercise => exercise.excerciseList.Count));
            Console.WriteLine(mostExercises.firstName + "" + mostExercises.lastName);

            C31.studentList.Add(Josh);
            C31.studentList.Add(Clif);
            C31.studentList.Add(Rose);

            Cohorts.ForEach(cohort => Console.WriteLine(cohort.studentList.Count())

            );
    }
}
}
