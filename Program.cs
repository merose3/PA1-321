using System;
using System.Collections.Generic;
using System.IO;

namespace PA1_321
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Welcome to Big Al's Playlist website! \n Please pick if you would like to: \n 1) View all songs \n 2) Add a song \n 3) Delete a song by ID \n 4) Exit the system"); 
            int userChoice = int.Parse(Console.ReadLine()); 
            MenuOptions(userChoice);
        }
        static void MenuOptions(int userChoice)
        {
            SongUtil manipulation = new SongUtil();
            while(userChoice != 4) //error checking
            {
                switch(userChoice)
                {
                    case 1: //This is to view all songs
                        SongUtil util = new SongUtil();
                        util.PrintSongOrder(); 
                        break;
                    case 2: //this is to add a song
                        manipulation.AddSong();
                        break;
                    case 3: //this is to delete a song
                        List<Song> songies = SongFile.GetSongs();
                        manipulation.DeleteSong(songies);
                        break;
                    default: //get me out of the system 
                        System.Console.WriteLine("Invalid Option"); 
                        break;
                }
            System.Console.WriteLine("Please pick if you would like to: \n 1) View all songs \n 2) Add a song \n 3) Delete a song by Name \n 4) Exit the system"); 
            userChoice = int.Parse(Console.ReadLine()); 
            }
            Console.WriteLine("You will now exit the system");
        }
    }
}
