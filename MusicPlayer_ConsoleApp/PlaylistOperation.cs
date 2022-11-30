using System;
using System.Linq;
using System.Text.RegularExpressions;


namespace MusicPlayer_ConsoleApp
{
    public class PlaylistOperation
    {
        //private static List<string> bigboy = new List<string>() { "hwy", "hhsdtu" };
        public static SortedDictionary<string, List<string>> MyPlaylist = new SortedDictionary<string, List<string>>() ;

        private static bool IsActive;

        
        private static readonly string pattern = @"[a-zA-Z0-9]{1,}";
        private static readonly Regex reg = new Regex(pattern);
        public PlaylistOperation()
        {
            
            IsActive = true;
           
        }

        public static void AddPlaylist()
        {
            //var MyPlaylist = new Dictionary<string, List<string>>();
            Console.WriteLine("Enter new Playlist");
            string Playlist = Console.ReadLine();
            //We akReference dont need to nam the list the playlist is just a key
            
            if (reg.IsMatch(Playlist))
            {
                
                MyPlaylist.Add(Playlist, AddSong());
               

            }
            else
            {
                Console.Clear();
                Console.WriteLine("Playlist not added: Wrong Format");
                AddPlaylist();
            }
            
        }
        private static List<string> AddSong()
        {

            //Console.WriteLine("Enter Name of Song");
            IsActive = true;
            var Songs = new List<string>();
            while (IsActive)
            {

                Console.WriteLine("Enter Name of Song");
                string? Song = Console.ReadLine();
                if (reg.IsMatch(Song))
                {
                    Songs.Add(Song);
                }
                else
                {
                    Console.WriteLine("Song not added: Wrong Format");
                }

                Console.WriteLine("enter n");
                string cancel = Console.ReadLine();
                if (cancel.ToLower() == "n")
                {
                    IsActive = false;
                }
            }
            return Songs;
        }
        public static void DisplayDict()
        {
            foreach (KeyValuePair<string,List<string>> list in MyPlaylist)
            {
                Console.WriteLine(list.Key);
                Console.WriteLine(list.Value);
            }
        }
        public static void ToDoList()
        {
            Console.WriteLine("Enter 1 to Listen to Previous Song, \n" +
                "Enter 2 to Listen to Next Song, \n" +
                "Enter 3 to Shuffle Songs, \n" +
                "Enter 4 to Play Songs Exact Order they were added, \n" +
                "Enter 5 to Play Songs in Alphabetical Order, \n"+
                "Enter 0 to Return to Main Menu.");
        }
    }
}

