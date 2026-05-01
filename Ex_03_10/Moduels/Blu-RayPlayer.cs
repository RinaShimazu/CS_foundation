namespace Ex_03_10.Moduels;

public class BlurayPlayer : Player
{
    public BlurayPlayer(string Media) : base(Media)
    {

    }
    public override void Play()
    {
        Console.WriteLine("Blu-ray : " + Media + "を再生しています");
    }
    public override void Stop()
    {
        Console.WriteLine("Blu-ray : " + Media + "を再生しています");
    }
}
// Console.Write($"{Media}を再生しています");
