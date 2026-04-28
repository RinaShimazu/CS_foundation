using System.Diagnostics.CodeAnalysis;

namespace Ex_02_03;

static class Program
{
    static void Main(string[] args)
    {   int a = int.Parse(System.Console.ReadLine());
        int b = 5;
        
        Console.WriteLine($"数値を入力してください->{a}");
        Console.WriteLine($"{b}を加算した結果は{a + b}です");
        Console.WriteLine($"{b}を減算した結果は{a - b}です");
    }
}
