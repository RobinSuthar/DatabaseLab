using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLab
{
   public class SQLiteManager
   {
        //**************
        //According to the requirement of the question
        //WE will have CRUD.
        //Functions to create,read,update,and delete the table

        private SQLiteConnection database;

        public SQLiteManager()
        {
            this.database = new SQLiteConnection(Constants.DatabasePath);

            //creating a replaces sql query to create a table for student
            this.database.CreateTable<Courses>();
        }

        //CRUD: C => Create
        public void AddCourse(Courses course)
        {
            this.database.Insert(course);
        }


        //CRUD: R => Read
        public List<Courses> GetAllCourse()
        {
            return this.database.Table<Courses>().ToList(); 
        }

        //CRUD: D => Delete 
        //Droptable is to delte the entire table
        //DropCourseById is to deop specific table
        public void DropTable()
        {
            this.database.DropTable<Courses>();
        }

        public void DropCourseById(int id)
        {

            if( id < 1000 || id >1005)
            {
                Console.WriteLine("There is no such element in the table");
                return;
            }
            Courses courseToRemove = new Courses() { CourseId =  id};
            this.database.Delete(courseToRemove);

        }

        //CRUD => Update 
        public void UpdateCourse(Courses course)
        {
            this.database.Update(course);
        }


    }
}
