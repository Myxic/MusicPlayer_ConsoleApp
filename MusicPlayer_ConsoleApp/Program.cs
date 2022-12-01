using MusicPlayer_ConsoleApp;

namespace MusicPlayer;
class Program
{
    static void Main(string[] args)
    {
       
        Run();
        
    }
    public static void Run()
    {
        MainMenu();

    }
    private static void MainMenu()
    {
        Start:  Console.Write("__________________________________________________________________\n" +
            "\t\t MUSIC PLAYER MENU \n" +
            "__________________________________________________________________\n" +
            "------------------------------------------------------------------\n" +
            "Enter No: \n" +
            "1: View All Playlists \n" +
            "2: View All Songs \n" +
            "3: Add Playlist \n" +
            "4: Edit Songs in Playlist \n" +
            "5: Delete Playlist \n" +
            "6: Delete Song in Playlist \n" +
            "7: Add Song to an existing Playlist\n" +
            "8: Shuffle Songs\n" +
            "9: Exit\n" +
            "===>  ");
        string Input = Console.ReadLine();
        switch (Input)
        {
            case "1":
                Console.Clear();
                PlaylistOperation.DisplayPlaylist();
                break;
            case "2":
                Console.Clear();
                ViewSongs();
                break;
            case "3":
                Console.Clear();
                PlaylistOperation.AddPlaylist();
                break;
            case "4":
                Console.Clear();
                EditMusicApp.EditSongsInPlaylist();
                break;
            case "5":
                Console.Clear();
                EditMusicApp.DeletePlaylist();
                break;
            case "6":
                Console.Clear();
                EditMusicApp.DeleteSongInPlaylist();
                break;
            case "7":
                Console.Clear();
                EditMusicApp.AddSongToPlaylist();
                break;
            case "8":
                Console.Clear();
                SongControls.Shuffle();
                break;
            case "9":
                break;
            default:
                Console.Clear();
                Console.WriteLine($"{Input} is an Invalid Input");
                goto Start;
                
        }
    }
    public static void ViewSongs()
    {
        start:  Console.WriteLine("Enter No:\n" +
            "1: To Display and Play Songs \n" +
            "2: To Display and Play Songs in Alphabetic Order \n" +
            "0: To Return to Main Menu");
        string Input = Console.ReadLine();
        switch (Input)
        {
            case "0":
                Console.Clear();
                Run();
                break;
            case "1":
                Console.Clear();
                SongControls.ExactSongs();
                break;
            case "2":
                Console.Clear();
                SongControls.AlphabeticSong();
                break;
            default:
                Console.Clear();
                Console.WriteLine($"{Input} is an invalid option");
                goto start;
        }
    }
}

