using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PA1_321
{
    public class Song : IComparable<Song>
    {
        public Guid ID { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public bool Deleted { get; set; }

        // public static int CompareTo(Song y, Song x) //this is ascending order 
        // {
        //     return x.Date.CompareTo(y.Date); //need to find out what order it is seen in (We want decending)
        // }
        
        public override string ToString()
        {
            return this.Title + " was added on " + this.Date;
        }
         public string ToFile()
        {
            return ID + "#" + Title + "#" + Date + "#" + Deleted;
        }
        public string ToFileDeleted()
        {
            Deleted = true;
            return ID + "#" + Title + "#" + Date + "#" + Deleted;
        }
        public int CompareTo(Song compareSong)
        {
            return this.Date.CompareTo(this.Date);
        }
    }
}
