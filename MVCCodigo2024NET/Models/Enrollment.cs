namespace MVCCodigo2024NET.Models
{
    public class Enrollment
    {

        public int EnrollmentID { get; set; }

        public DateTime Date { get; set; }
        public string Number { get; set; }

        public int CourseID { get; set; }
        public Course Course { get; set; }

        public int StudentID { get; set; }
        public Student Student { get; set; }
    }

    public class EnrollmentModel
    {

        public int EnrollmentID { get; set; }

        public DateTime Date { get; set; }
        public string Number { get; set; }

        public string Student { get; set; }
        public string Course { get; set; }


    }

}
