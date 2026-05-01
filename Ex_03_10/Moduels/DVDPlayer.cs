using System.Net.Http.Headers;
namespace Ex_03_10.Moduels;

public class DVDPlayer : Player
{
    public DVDPlayer(string Media) : base(Media)
    {

    }
    public override void Play()
    {
        Console.WriteLine("DVD : " + Media + "を再生しています");
    }
    public override void Stop()
    {
        Console.WriteLine("DVD : " + Media + "の再生を停止しました");
    }
}
