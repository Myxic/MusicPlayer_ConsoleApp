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
        //MainMenu();
        SongControls.AlphabeticSong();
    }
    private static void MainMenu()
    {
        Start:  Console.WriteLine("Enter No: \n" +
            "1: View All Playlists \n" +
            "2: View All Songs \n" +
            "3: Add Playlist \n" +
            "4: Edit Songs in Playlist \n" +
            "5: Delete Playlist \n" +
            "6: Delete Song in Playlist \n" +
            "7: Add Song to an existing Playlist");
        string Input = Console.ReadLine();
        switch (Input)
        {
            case "1":
                Console.Clear();
                PlaylistOperation.DisplayPlaylist();
                break;
            case "2":
                Console.Clear();
                break;
            case "3":
                Console.Clear();
                PlaylistOperation.AddPlaylist();
                break;
            case "4":
                Console.Clear();
                break;
            case "5":
                Console.Clear();
                break;
            case "6":
                Console.Clear();
                break;
            case "7":
                Console.Clear();
                break;
            default:
                Console.Clear();
                Console.WriteLine($"{Input} is an Invalid Input");
                goto Start;
                
        }
    }
}

