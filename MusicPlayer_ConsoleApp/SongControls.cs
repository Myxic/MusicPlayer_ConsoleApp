using System;
using System.ComponentModel;
using MusicPlayer;

namespace MusicPlayer_ConsoleApp
{
    public class SongControls
    {
        private static int _count;

        public SongControls()
        {
            _count = 0;
        }
        private static List<string> Songs()
        {
            List<string> Songs = new List<string>();  
            foreach (var Values in PlaylistOperation.MyPlaylist.Values)
            {
                foreach (var item in Values)
                {
                    Songs.Add(item);
                }
            }
            return Songs;
        }
        public static int NextSong()
        {
          
                 _count++;
         
            return _count;

        }
        public static int PreviousSong()
        {
    

                _count--;
            return _count;

        }
        public static void Shuffle()
        {
            int Limit = Songs().Count;
            Random rd = new Random();
            //int rand_num = rd.Next(0, Limit);
            List<int> CatchRepeatNo = new List<int>();
            for (int i = 0; i < Limit; i++)
            {
                int rand_num = rd.Next(0, Limit);
                if (!CatchRepeatNo.Contains(rand_num))
                {
                    CatchRepeatNo.Add(rand_num);
                    Console.WriteLine($"Now Playing \"{Songs()[rand_num]}\" Don'tPress anything please please");
                    Thread.Sleep(1000);
                }
            }
            PlaylistOperation.ReturnToMainMenu();
        }
        public static void AlphabeticSong()
        {
        start: _count = 0;
            var SortedSongs = Songs() ;
            SortedSongs.Sort();
            foreach (var song in SortedSongs)
            {
                Console.WriteLine(song);
            }
            Console.WriteLine("\n \nEnter No:\n" +
                "1: To Play songs \n" +
                "2: To Shuffle songs\n" +
                "0: To Return to Main Menu");
            string input = Console.ReadLine();
            switch (input)
            {
                case "0":
                    Console.Clear();
                    Program.Run();
                    break;
                case "1":
                    Console.Clear();
                    Play(SortedSongs,0);
                    break;
                case "2":
                    Console.Clear();
                    Shuffle();
                    break;
                default:
                    goto start;
            }
        }
        public static void ExactSongs()
        {
          start:  _count = 0;
            foreach (var song in Songs())
            {
                Console.WriteLine(song);
            }
            Console.WriteLine("\n \nEnter No:\n" +
                "1: To Play songs \n" +
                "2: To Shuffle songs\n" +
                "0: To Return to Main Menu");
            string input = Console.ReadLine();
            switch (input)
            {
                case "0":
                    Console.Clear();
                    Program.Run();
                    break;
                case "1":
                    Console.Clear();
                    Play(Songs(),0);
                    break;
                case "2":
                    Console.Clear();
                    Shuffle();
                    break;
                default:
                    goto start;
            }
        }
       
        private static void Play(List<string> Playthis, int Count)
        {

            if (Count < 0)
            {
                _count = Songs().Count - 1;

            }
            if (Count > Songs().Count - 1)
            {

                    _count = 0;

            }
        start:  Console.WriteLine($"Now Playing \"{Playthis[_count]}\"\n" +
                "\n" +
                "Enter No: \n"+
                "1: For Next Song\n" +
                "2: For Prev Song\n" +
                "0: To Return to Main Menu");
            string Option = Console.ReadLine();
           
            switch (Option)
            {
                case "0":
                    Console.Clear();
                    Program.Run();
                    break;
                case "1":
                    Console.Clear();
                    Play(Playthis, NextSong());
                    break;
                case "2":
                    Console.Clear();
                    Play(Playthis, PreviousSong());
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine($"{Option} is an Invalid Option");
                    goto start;
                    
            }
        }
    }
}

