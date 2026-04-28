namespace Ex_02_08;

static class Program
{
    static void Main(string[] args)
    {
        string[] yamanote = { "品川", "大崎", "五反田", "目黒", "恵比寿", "渋谷", "原宿", "代々木", "新宿" };
        foreach (var station in yamanote)
        {
            Console.WriteLine(station);
        }
    }
}
