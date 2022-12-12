using SQLite;
using System;

namespace Kalorikalkulaator
{
    public class Toit
    {
        [PrimaryKey, AutoIncrement]
        public int ToitID { get; set; }
        public string Spec { get; set; }
        public string Name { get; set; }
        public string Num { get; set; }

        



        
    }
}








