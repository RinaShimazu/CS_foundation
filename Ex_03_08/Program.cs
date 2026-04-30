using System.Security.Cryptography.X509Certificates;

namespace Ex_03_08;

static class Program
{
    static void Main(string[] args)
    {
        NetAccount info = new NetAccount();

        Console.Write("口座番号を入力してください->");
        info.AccountNo = (Console.ReadLine());
        Console.Write("口座名義を入力してください->");
        info.AccountName = Console.ReadLine();
        Console.Write("残高を入力してください->");
        info.Balance = int.Parse(Console.ReadLine());
        Console.Write("ポイントを入力してください->");
        info.Point = int.Parse(Console.ReadLine());

        Console.WriteLine($"口座番号：{info.AccountNo} 口座名義：{info.AccountName} 残高：{info.Balance} ポイント：{info.Point}");
    }
}
