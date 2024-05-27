using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finaldeneme.Models
{
    public class EnrollClass
    {
        [PrimaryKey, AutoIncrement]
        public int EnrollID { get; set; }

        public int StudentID { get; set;}

        public string CourseCode { get; set; }
    }
}
