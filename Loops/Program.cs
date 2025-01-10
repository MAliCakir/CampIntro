class Program
{
    static void Main(string[] args)
    {
        //For loop
        for (int i = 0; i < 10; i+=2)
        {
            Console.WriteLine(i);
        }
        //foreach loop using for arrays
        // we should not do this style
        string kurs1 = "Python";
        string kurs2 = "Java";
        string kurs3 = "C#";

        string[] kurslar = {kurs1,kurs2,kurs3};
        //we should not do this style. btw we will get this data a database actualy
        //this data can be  text file or another type
        string[] courses = new string[] { "Python", "Java", "C#" };

        foreach (string s in kurslar)
        {
            Console.WriteLine(s);
        }

        for (int i = 0;i < courses.Length; i++)
        {
            Console.WriteLine(courses[i]);
        }

        

        
    }
}