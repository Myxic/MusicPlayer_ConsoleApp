using System;
using MusicPlayer;

namespace MusicPlayer_ConsoleApp
{
    public partial class EditMusicApp
    {
        public static void EditSongsInPlaylist()
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

                            EditingSong(Index);
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
        private static void EditingSong(int Index)
        {
        start: ShowSongsinPlaylist(Index);
            int Offset = 1;
            int RealIndex = Index - Offset;

            Console.Write("\n\n" +
                "Enter Song No to Edit\n" +
                "Enter 0 to return to Main Menu\n" +
                "====>  ");
            string Input = Console.ReadLine();
            if (reg1.IsMatch(Input))
            {
                int Index2 = Convert.ToInt32(Input);
                int SongIndex = Index2 - 1;


                Count = 0;


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
                            Console.Clear();
                        here: Console.Write($"Enter Song to Replace {MyPlaylist[MyListPlaylist[RealIndex]][SongIndex]} with\n" +
                              "====>  ");
                            string Input2 = Console.ReadLine();
                            if (reg.IsMatch(Input2))
                            {
                                MyPlaylist[MyListPlaylist[RealIndex]][SongIndex] = Input2;
                                EditingSong(Index);
                            }
                            else
                            {
                                Console.WriteLine($"{Input2} is not a valid input");
                                goto here;
                            }

                            break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"{Input} is an invalid Option");

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
}


