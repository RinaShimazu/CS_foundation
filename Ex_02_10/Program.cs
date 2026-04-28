namespace Ex_02_10;

static class Program
{
    static void Main(string[] args)
    {
        string[] yamanote = { "品川", "大崎", "五反田", "目黒", "恵比寿", "渋谷", "原宿", "代々木", "新宿" };
        int i = 0;
        while (i < yamanote.Length)
        {
            Console.WriteLine(yamanote[i]);
            i += 1;
        }
    }
}
