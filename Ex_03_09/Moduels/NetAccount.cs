namespace Ex_03_09;

public class NetAccount : Account
{
    public int Point { get; set; }
    public override string ToString();

    public NetAccount(string AccountNo, string AccountName, int Balance, int Point) : base(AccountNo, AccountName, Balance)

}
