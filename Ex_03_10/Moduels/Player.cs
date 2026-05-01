using System.Net.Mime;
using System.Runtime.InteropServices.Marshalling;
using Microsoft.VisualBasic;

namespace Ex_03_10.Moduels;

public abstract class Player
{
    public string Media { get; set; } //プロパティ
    public Player(string Media)
    {
        this.Media = Media;
    }
    public abstract void Play();
    public abstract void Stop();
}