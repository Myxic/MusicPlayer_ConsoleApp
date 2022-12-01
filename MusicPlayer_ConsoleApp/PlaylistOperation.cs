using System;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text.RegularExpressions;
using MusicPlayer;

namespace MusicPlayer_ConsoleApp
{
    public class PlaylistOperation
    {
        private static List<string> ABetterDay = new List<string>() { "Failure", "Loser1", "Raise", "Fuck around and Find out" };
        private static List<string> BetterDays = new List<string>() { "Passable", "Father say", "Raise Hell", "Fuck around and Find See" };
        private static List<string> HorrorDays = new List<string>() { "C#", "Python", "Wow", "Fuck C and Find C++" };
        private static List<string> PeaceDay = new List<string>() { "Able", "Loser", "Raise", "Hmmm around and Find out" };
        private static List<string> NoPlace4PeaceDay = new List<string>() { "Failure HEY", "Loser WOW", "Raise Except", "Fuck around and See Hell" };
        public static Dictionary<string, List<string>> MyPlaylist = new Dictionary<string, List<string>>() {
            {"A Better Day", ABetterDay },
            {"Better Days", BetterDays },
            {"Horror Days", HorrorDays },
            {"Peace Day", PeaceDay },
            {"No Place 4 Peace Day", NoPlace4PeaceDay },

        };
        public static SortedDictionary<string, List<string>> SortedPlaylist = new SortedDictionary<string, List<string>>(MyPlaylist);
        private static bool IsActive;
        private static int Count = 0;
        private static List<string> MyListPlaylist = new List<string>();
        private static readonly string pattern = @"[a-zA-Z0-9]{1,}";
        private static readonly string pattern1 = @"[0-9]{1,}";
        private static readonly Regex reg = new Regex(pattern);
        private static readonly Regex reg1 = new Regex(pattern1);
        public PlaylistOperation()
        {

            IsActive = true;

        }

        public static void AddPlaylist()
        {
          
           start: Console.WriteLine("Enter new Playlist");
            string Playlist = Console.ReadLine();
           

            if (reg.IsMatch(Playlist))
            {

                MyPlaylist.Add(Playlist, AddSong());


            }
            else
            {
                Console.Clear();
                Console.WriteLine("Playlist not added: Wrong Format");
                //AddPlaylist();
                goto start;
            }

            ReturnToMainMenu();

        }
        private static void ReturnToMainMenu()
        {
            start:  Console.WriteLine("\nEnter 0 to Return to Main Menu.");
            string menu = Console.ReadLine();

            switch (menu)
            {
                case "0":
                    Console.Clear();
                    Program.Run();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine($"{menu} is an invalid option");
                    goto start;
                    
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

                Console.Write("Enter N to Stop Adding Song");
                string cancel = Console.ReadLine();
                if (cancel.ToLower() == "n")
                {
                    IsActive = false;
                }
            }
            return Songs;
        }
        public static void DisplayPlaylist()
        {
           start: Count = 0;
            Console.WriteLine("Enter the Numbers to Select Playlist");
            foreach (KeyValuePair<string, List<string>> list in MyPlaylist)
            {
                Count++;
                Console.Write($"{Count}:  ");
                Console.WriteLine(list.Key);
                MyListPlaylist.Add(list.Key);

            }
            Console.WriteLine("Enter 0 To Return to Main Menu");
            string? Option = Console.ReadLine();
            if (reg1.IsMatch(Option))
            {
                Count = 0;
              
                int Index = Convert.ToInt32(Option);
                int Limit = MyPlaylist.Count ;
                if (0 <= Index & Index <= Limit )
                {
                    switch (Index)
                    {
                        case 0:
                            Console.Clear();
                            Program.Run();
                            break;
                        default:
                            
                            SongInPlayList(Index);             
                            break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"{Index} is an invalid Option");
                    //DisplayPlaylist();
                    goto start;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("hmm");
                Console.WriteLine($"{Option} is an invalid Option");
                //DisplayPlaylist();
                goto start;
            }
            
        }
        public static void SongInPlayList(int Index)
        {
            string Playlist = MyListPlaylist[Index - 1];
            Console.Clear();
            Console.WriteLine($"Displaying Playlist \"{Playlist}\"");
            foreach (string ThisSong in MyPlaylist[Playlist])
            {
                Count++;
                Console.Write($"{Count}: ");
                Console.WriteLine(ThisSong);
            }
            
            ReturnToMainMenu();
        }
        public static void ToDoList()
        {
        start: Console.WriteLine("Enter /'P/'  to Listen to Previous Song, \n" +
                "Enter /'N/' to Listen to Next Song, \n" +
                "Enter /'S/' to Shuffle Songs, \n" +
                "Enter /'E/' to Play Songs Exact Order they were added, \n" +
                "Enter /'A/' to Play Songs in Alphabetical Order, \n" +
                "Enter 0 to Return to Main Menu.");

         
            string menu = Console.ReadLine();

            switch (menu.ToUpper())
            {
                case "0":
                    Console.Clear();
                    Program.Run();
                    break;
                case "P":
                    break;
                case "N":
                    break;
                case "S":
                    break;
                case "E":
                    break;
                case "A":
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine($"{menu} is an invalid option");
                    goto start;

            }
        }
    }
}

