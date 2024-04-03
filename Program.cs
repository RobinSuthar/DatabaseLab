using MySqlConnector;

namespace DatabaseLab

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Database!");

            SQLiteManager sqliteDB = new SQLiteManager();

            
            
            //Making 5 Coursed according the question
            Courses course1 = new Courses
            {
                CourseId = 1001,
                Credit = 3,
                Name = "Fundamentals of Web Devlopment"
            };

            Courses course2 = new Courses
            {
                CourseId = 1002,
                Credit = 3,
                Name = "Introduction to Full Stack Programming"
            };

            Courses course3 = new Courses
            {
                CourseId = 1003,
                Credit = 3,
                Name = "Databases"
            };

            Courses course4 = new Courses
            {
                CourseId = 1004,
                Credit = 4,
                Name = "Principles of Software Design and Analysis"
            };

            Courses course5 = new Courses
            {
                CourseId = 1005,
                Credit = 4,
                Name = "Object- Orented Programming"
            };
            ////Till here 
            //////----------------------------------------//


            ///------------------------------------------///
            //////Now Add those courses into database.
            sqliteDB.AddCourse(course1);
            sqliteDB.AddCourse(course2);
            sqliteDB.AddCourse(course3);
            sqliteDB.AddCourse(course4);
            sqliteDB.AddCourse(course5);
            ////////We Having add 5 course into the table.
            //Console.WriteLine("5 Course's succesfull added.");

            ////Reading through the table
            ////Looping through courses and getting printing all the courses
            List<Courses> courses = sqliteDB.GetAllCourse();

            foreach (Courses course in courses)
            {
                Console.WriteLine(course.ToString());
            }

            //------------------------------NOTE--------------------------/
            // Hi, samuel you might have to uncomment the lines in order for them to perform
            //-----------------------------NOTE---------------------------/
            //////////Drop Course By ID
            //sqliteDB.DropCourseById(1002);
            ////Console.WriteLine("course Droped");

            ////////Update the course
            //course5.Name = "CRPG250";
            //sqliteDB.UpdateCourse(course5);
            //Console.WriteLine("Updated");
        }
    }
}
