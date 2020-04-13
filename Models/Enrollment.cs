using System;

namespace EnumTen.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public Guid ID { get; set; }
        public Guid CourseID { get; set; }
        public Guid MealID { get; set; }
        public Grade? Grade { get; set; }

        public Meal Meal { get; set; }
        public Student Student { get; set; }
    }
}