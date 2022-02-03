using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PA1_321
{
    public class SongFile
    {
        public static List<Song> GetSongs() //method to pull songs in from the file 
        {
            List<Song> songList = new List<Song>(); // () this is a no-arg constructor 
            StreamReader infile = null; //opening the file 
            try
            {
                infile = new StreamReader("songs.txt");
            }
            catch(FileNotFoundException e) 
            {
                System.Console.WriteLine("Something went wrong {0}", e);
                return songList;
            }
            string line = infile.ReadLine(); //priming read 
            while(line != null)
            {
                string [] temp = line.Split("#"); //pulls everything in as a string 
                // Guid tempID = Guid.Parse(temp[0]); //parsing the song ID
                DateTime date = DateTime.Parse(temp[2]);
                bool delete = bool.Parse(temp[3]);
                songList.Add(new Song(){ID = temp[0], Title = temp[1], Date = date, Deleted = delete}); //this is a way to add a new song to the list created 
                line = infile.ReadLine(); //update read 
               
            }
            infile.Close(); //closing the file 

            return songList;
        }
       
    }
}