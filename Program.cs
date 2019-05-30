using System;
using System.Collections.Generic;

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


            Instructor Andy = new Instructor()
            {
                firstName = "Andy",
                lastName = "Collins",
                slackHandle = "Andy_C",
                specialty = "C-Sharpin'"
            };

            Instructor Jisie = new Instructor()
            {
                firstName = "Jisie",
                lastName = "David",
                slackHandle = "Jisie_D",
                specialty = "J-Scriptin'"
            };
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

            List<Student> students = new List<Student>(){
            Josh, Rose, Clif
        };

             List<Exercise> exercises = new List<Exercise>(){
                VinylGrayl, Kennels, UrbanPlanner, EnglishIdioms
            };

            foreach(Student person in students){
                Console.Write($"{person.firstName} {person.lastName} is working on these exercises:  ");
                foreach(Exercise assignment in person.excerciseList){
                    Console.Write($"{assignment.name}, ");
                }
                Console.WriteLine();
            }
        }
    }
}
