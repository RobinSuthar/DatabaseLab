using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLab
{
    public class Constants
    {
        public const string DatabaseFileName = "student.db3";

        public static string DatabasePath => Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, DatabaseFileName);


        public Constants() { }
    }
}
