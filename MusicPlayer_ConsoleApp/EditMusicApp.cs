using System;
using System.Collections.Generic;
using MusicPlayer;

namespace MusicPlayer_ConsoleApp
{
    public class EditMusicApp : PlaylistOperation
    {
        //private static int Count = 0;
        public EditMusicApp()
        {
        }

        public  static  void DeletePlaylist()
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
                            
                            MyPlaylist.Remove(MyListPlaylist[Index-1]);
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
                    //DisplayPlaylist();
                    goto start;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"{Option} is an invalid Option");
                //DisplayPlaylist();
                goto start;
            }

        }
        public static void AddSongToPlaylist()
        {
            DisplayPlaylist();
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
                        here:
                            ShowSongsinPlaylist(Index);


                            break;

                            //goto here;
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
                Console.WriteLine($"{Option} is an invalid Option");
                //DisplayPlaylist();
                goto start;
            }
        }
        public static void EditSongsInPlaylist()
        {
            DisplayPlaylist();
        }
    }
}

