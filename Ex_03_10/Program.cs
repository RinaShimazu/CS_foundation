using System.Security;
using Ex_03_10.Moduels;
namespace Ex_03_10;

static class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("DVDのタイトルを入力してください->");
        string content1 = Console.ReadLine();
        Player dvd = new DVDPlayer(content1);
        dvd.Play();
        dvd.Stop();
    }
}
