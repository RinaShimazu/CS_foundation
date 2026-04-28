namespace Ex_02_11;

static class Program
{
    static void Main(string[] args)
    {
        string[] yamanote = { "品川", "大崎", "五反田", "目黒", "恵比寿", "渋谷", "原宿", "代々木", "新宿" };
        for (int i = 0; i < yamanote.Length; i++)
        {
            if (yamanote[i] == "五反田")
            {
                continue;
            }
            Console.WriteLine(yamanote[i]);
        }
        Console.WriteLine("終了");
    }
}
