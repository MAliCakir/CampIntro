class Program
{
    private static void Main(string[] args)
    {
        Course course1 = new Course();
        course1.CourseName = "C#";
        course1.Tutor = "Engin Demirog";
        course1.ViewingRate = 100;

        Course course2 = new Course();
        course2.CourseName = "Java";
        course2.Tutor = "Kerem Varis";
        course2.ViewingRate = 90;

        Course course3 = new Course();
        course3.CourseName = "Python";
        course3.Tutor = "Berkay Bilgin";
        course3.ViewingRate = 80;

        //Console.WriteLine(course1.CourseName + " : " + course1.Tutor);
        //List<Course> courseList = new List<Course>() // create list
        //{ course1,course2,course3};

        Course[] Courses = new Course[] { course1, course2, course3 };

        foreach (Course course in Courses)
        {
            Console.WriteLine(course.CourseName + " : " + course.Tutor);
        }
    class Course
    {

        // Properties of classes
        public string CourseName { get; set; } // Kurs adı
        public string Tutor { get; set; } // Eğitmen
        public int ViewingRate { get; set; } // İzlenme oranı
    }
}
