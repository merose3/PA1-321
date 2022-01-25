using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PA1_321
{
    public class Song
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }

        public int CompareByDate(Song x, Song y) //int because it returns either a 0, -1, or 1 (temp bc we dont know whats gonna be brought in)
        {
            return x.Date.CompareTo(y.Date); //need to find out what order it is seen in (We want decending)
        }
        
        public override string ToString()
        {
            return this.Title + " was added on " + this.Date;
        }
    }
}