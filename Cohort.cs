using System;
using System.Collections.Generic;

namespace Lighting{

    public class Cohort{
       public List<Student> StudentList {get; set;} = new List<Student>();
        public List<Instructor> InstructorList {get; set;} = new List<Instructor>();

        public int CohortNumber {get; set;}
    }
//     Create a `Cohort` class that 

// 1. Maintains a list of students
// 2. Maintains a list of instructors
// 3. Has a property of the cohort number
}