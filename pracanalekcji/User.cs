using System;
using System.Collections.Generic;
using System.Text;

using SQLite;

namespace pracanalekcji
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public bool IsTeacher { get; set; }
    }
}
