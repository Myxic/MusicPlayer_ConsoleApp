using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using Microsoft.VisualBasic.FileIO;
using MusicPlayer;

namespace MusicPlayer_ConsoleApp
{
    public partial class EditMusicApp : PlaylistOperation
    {
        public EditMusicApp()
        {
        }

        public static void DeletePlaylist()
        {
        start: Count = 0;
            Console.WriteLine("Enter the Numbers to Select Playlist to Delete");
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
                int Limit = MyPlaylist.Count;
                if (Count <= Index & Index <= Limit)
                {
                    switch (Index)
                    {
                        case 0:
                            Console.Clear();
                            Program.Run();
                            break;
                        default:

                            MyPlaylist.Remove(MyListPlaylist[Index - 1]);
                            MyListPlaylist.Clear();
                            Console.Clear();
                            DeletePlaylist();
                            break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"{Index} is an invalid Option");

                    goto start;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"{Option} is an invalid Option");

                goto start;
            }

        }
        public static void AddSongToPlaylist()
        {
        start: Count = 0;
            Console.WriteLine("Enter the Numbers to Select Playlist to Delete");
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
                int Limit = MyPlaylist.Count;
                if (Count <= Index & Index <= Limit)
                {
                    switch (Index)
                    {
                        case 0:
                            Console.Clear();
                            Program.Run();
                            break;
                        default:

                            AddingSong(Index);
                            break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"{Index} is an invalid Option");

                    goto start;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"{Option} is an invalid Option");

                goto start;
            }
        }
        public static void DeleteSongInPlaylist()
        {
        start: Count = 0;
            Console.WriteLine("Enter the Numbers to Select Playlist to Delete");
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
                int Limit = MyPlaylist.Count;
                if (Count <= Index & Index <= Limit)
                {
                    switch (Index)
                    {
                        case 0:
                            Console.Clear();
                            Program.Run();
                            break;
                        default:

                            DeleteSong(Index);
                            break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"{Index} is an invalid Option");

                    goto start;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"{Option} is an invalid Option");

                goto start;
            }
        }
        private static void DeleteSong(int Index)
        {
        start: ShowSongsinPlaylist(Index);
            int Offset = 1;
            int RealIndex = Index - Offset;

            Console.Write("\n\n" +
                "Enter Song No to Remove\n" +
                "Enter 0 to return to Main Menu\n" +
                "====>  ");
            string Input = Console.ReadLine();
            if (reg1.IsMatch(Input))
            {
                Count = 0;

                int Index2 = Convert.ToInt32(Input);
                int SongIndex = Index2 - 1;
                int Limit = MyPlaylist[MyListPlaylist[RealIndex]].Count;
                if (Count <= Index & Index <= Limit)
                {
                    switch (Index2)
                    {
                        case 0:
                            Console.Clear();
                            Program.Run();
                            break;
                        default:
                            MyPlaylist[MyListPlaylist[RealIndex]].Remove(MyPlaylist[MyListPlaylist[RealIndex]][SongIndex]);
                            goto start;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"{Input} is an invalid Option");

                    goto start;


                }
            }

        }
        private static void AddingSong(int Index)
        {
            ShowSongsinPlaylist(Index);
            int Offset = 1;
            int RealIndex = Index - Offset;

            Console.Write("\n\n" +
                $"Enter Song to Add to playlist \"{MyListPlaylist[RealIndex]}\"\n" +
                "Enter 0 to return to Main Menu\n" +
                "====>  ");
            string Input = Console.ReadLine();
            if (reg.IsMatch(Input))
            {
                switch (Input)
                {
                    case "0":
                        Console.Clear();
                        Program.Run();
                        break;
                    default:
                        MyPlaylist[MyListPlaylist[RealIndex]].Add(Input);
                        Count = 0;
                        AddingSong(Index);
                        break;
                }

            }

        }

    }
}
