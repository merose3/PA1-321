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
                System.Console.WriteLine(song.ToString());
            }
        }
        public void PrintSongOrder()
        {
            Song compare = new Song();
            List<Song> songs = SongFile.GetSongs();
            // songs.Sort(delegate (Song x, Song y) //this is sorting by title
            // {
            //     return x.Date.CompareTo(y.Date);
            // });
            Console. ForegroundColor = ConsoleColor. Green;
            Console.WriteLine("****Sorted in descending order****");
            Console. ForegroundColor = ConsoleColor. White;
            var dateOrder = songs.OrderByDescending(e => e.Date);
            foreach (var theSongs in dateOrder)
            {
                Console.WriteLine(theSongs);
            }
        }
        public void AddSong()
        {
            List<Song> songs = SongFile.GetSongs();
            Guid guid = Guid.NewGuid(); //guid is working 
            System.Console.WriteLine("The ID of your new song is: " + guid);
            System.Console.WriteLine("Please enter the name of the song you would like to add");
            string newSong = Console.ReadLine();
            var currDate = DateTime.Now; //date is correct 
            songs.Add(new Song(){ID = guid, Title = newSong, Date = currDate}); //this is a way to add a new song to the list created []
            
            StreamWriter outfile = new StreamWriter("songs.txt");
            foreach(Song song in songs)
            {
                outfile.WriteLine(song.ToFile());
            }
            outfile.Close();
        }
        public void DeleteSong(List<Song> songs) //do a soft delete 
        {
            PrintAllSongs(songs);
            System.Console.WriteLine("Please enter the name of the song you would like to delete");
            int userInput = int.Parse(Console.ReadLine());
            songs.Sort();
            
            // try //dont I put parameters here?
            // {
                
            // }
            // catch
            // {
            //     System.Console.WriteLine(userInput + " does not exist");
            // }
        }
    }
}