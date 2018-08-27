using System;

namespace Lighting
{
    // Create some cohorts, students, and instructors in your `Program.cs` and assign the students and instructors to the cohort

    class Program
    {
        static void Main(string[] args)
        {
            Cohort cohort26 = new Cohort()
            {
                CohortNumber = 26
            };

            Student robert = new Student ("Robert","Leddy");
            Student jewel = new Student ("Jewel","Ramirez");
            Instructor steve = new Instructor ("Steve","Brownlee");

            cohort26.StudentList.Add(robert);
            cohort26.InstructorList.Add(steve);

            Exercise ex1 = new Exercise();
            ex1.Name = "ChickenMonkey";
            ex1.Language ="JavaScript";
            ex1.GithubURL = "www.github.com";

            Exercise ex2 = new Exercise(){
                Name = "KillHanson",
                Language = "C#",
                GithubURL = "www.github.com"
            };
            steve.AssignExercise(jewel,ex1);
            steve.AssignExercise(jewel,ex2);

            foreach (Exercise item in jewel.AssignedExercises)
            {
                
                Console.WriteLine($"{jewel.FullName}: {item.Name}");
            }
        }
    }
}
// Create some exercises
// 2. Write a method on the `Instructor` class that will allow you to assign an individual exercise to an individual student
// Pick one of the students and write to the Console each exercise that has been assigned to that student