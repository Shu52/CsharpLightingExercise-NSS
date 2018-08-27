using System;
using System.Collections.Generic;

namespace Lighting{
    public class Student:Person{
    public List<Exercise> AssignedExercises {get;} = new List<Exercise>();
    
    public Student(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }
        //     private fields for first name and last name
// 2. Public calculated property that returns "Firstname Lastname" of student
// 3. Constructor that accepts first name and last name
// 4. A public list of exercises

    }
}