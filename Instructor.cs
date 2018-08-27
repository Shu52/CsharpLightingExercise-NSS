using System;

namespace Lighting
{

    //   Create an `Instructor` class with the following properties and fields

    // 1. private fields for first name and last name
    public class Instructor:Person
    {
       
       public Instructor(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }
        public void AssignExercise(Student student, Exercise exercise)
        {
            student.AssignedExercises.Add(exercise);
        }
    }
    // public void AssignExercise (Student student, Exercise exercise)
    //     {
    //         /*
    //             Refactor this method and the `AssignedExercises` property
    //             on Student to keep track of which instructor assigned the
    //             exercise, and when.
    //         */
    //         student.AssignedExercises.Add(exercise);
    //     }

    // 2. Public calculated property that returns "Firstname Lastname" of instructor
    // 3. Constructor that accepts first name and last name
    // Write a method on the `Instructor` class that will allow you to assign an individual exercise to an individual student
}
