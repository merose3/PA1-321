using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        public void AddSong()
        {
            System.Console.WriteLine("Please enter the name of the song you would like to add");
            string newSong = Console.ReadLine();
            
        }
    }
}