namespace Ex_03_09;

public class Account
{
    public string? AccountNo { get; set; }
    public string? AccountName { get; set; }

    public int Balance { get; set; }

    public void Print()
    {
        Console.WriteLine($"口座番号={AccountNo}");
        Console.WriteLine($"口座名義={AccountName}");
        Console.WriteLine($"残高={Balance}");
    }
    public Account(string AccountNo, string AccountName, int Balance);

    public virtual void Print()
    {
        Console.WriteLine(Console.WriteLine($"口座番号：{info.AccountNo} 口座名義：{info.AccountName} 残高：{info.Balance} ポイント：{info.Point}"));
    }
    public override string ToString()
    {
        return $"Account[AccountNo={AccountNo},AccountName={AccountName},Balance ={Balance}]";
    }


}