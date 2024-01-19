using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace pracanalekcji
{
    public class Score
    {
        [PrimaryKey, AutoIncrement]
        public int Score_id { get; set; }
        public string User_id { get; set; }
        public string Subject_id { get; set; }
        public string Subject_name { get; set; }
        public string Value { get; set; }
        public DateTime Date { get; set; }
        public string Discription { get; set; }
        public string Period { get; set; }
    }
}
