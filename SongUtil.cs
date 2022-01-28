using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace PA1_321
{
    public class SongUtil
    {
        public static void PrintAllSongs(List<Song> songs)
        {
            foreach(Song song in songs)
            {
                if(song.Deleted == false)
                {
                    System.Console.WriteLine(song.ToString());
                }
                
            }
        }
        public void PrintSongOrder()
        {
            Song compare = new Song();
            List<Song> songs = SongFile.GetSongs();
            Console. ForegroundColor = ConsoleColor. Green; //changes color to green for the sign directing user of how songs are showed
            Console.WriteLine("****Sorted in descending date order****");
            Console. ForegroundColor = ConsoleColor. White; //color back to white
            var dateOrder = songs.OrderByDescending(e => e.Date); //creates a variable of how the songs are ordered by 
            PrintAllSongs(songs);
        }
        public void AddSong()
        {
            List<Song> songs = SongFile.GetSongs();
            Guid guid = Guid.NewGuid(); //guid is working 
            System.Console.WriteLine("The ID of your new song is: " + guid);
            System.Console.WriteLine("Please enter the name of the song you would like to add");
            string newSong = Console.ReadLine();
            var currDate = DateTime.Now; //date is correct 
            songs.Add(new Song(){ID = guid, Title = newSong, Date = currDate}); //this is a way to add a new song to the list created 
            
            StreamWriter outfile = new StreamWriter("songs.txt");
            foreach(Song song in songs)
            {
                outfile.WriteLine(song.ToFile());
            }
            outfile.Close();
        }
        public void DeleteSong(List<Song> songs) //do a soft delete 
        {
            string userInput = GetExistingSongByTitle(songs); //be careful that the song actually exists
            if(userInput == "0")
            {
                return; //this returns nothing and they will leave the system
            }
            songs.Sort();
            StreamWriter outFile = new StreamWriter("songs.txt");
            foreach(Song song in songs) //this deletes everything in the file...
            {
                if(song.Title == userInput)
                {
                    outFile.WriteLine(song.ToFileDeleted()); 
                }
                else
                {
                    outFile.WriteLine(song.ToFile());
                }
            }
            outFile.Close();
        }

        public string GetExistingSongByTitle(List<Song> songs)
        {
            // PrintAllSongs(songs);
            PrintSongOrder();
            System.Console.WriteLine("\nPlease enter the name of the song you would like to delete and if there are none please press 0 to exit");
            string targetSongTitle = Console.ReadLine();
            bool found = false; //boolean 
            while(!found && targetSongTitle != "0") //not "or"
            {
                foreach(Song song in songs)
                {
                    if(song.Title == targetSongTitle)
                    {
                        found = true;
                        return targetSongTitle;
                    }
                }
                PrintSongOrder();
                System.Console.WriteLine("\nInvalid title entered. Please enter another title");
                System.Console.WriteLine("If you want to exit, please enter 0");
                targetSongTitle = Console.ReadLine();
            }
            return "0";
        }
    }
}