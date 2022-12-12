using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Kalorikalkulaator
{
    public class Toidud
    {
        [PrimaryKey, AutoIncrement]
        public int ToitId { get; set; }
        public int Date { get; set; }
        public string Name { get; set; }
        public int Num { get; set; }
    }
}

