namespace Ex_02_07;

static class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(System.Console.ReadLine());
        Console.WriteLine("数値を入力してください->" + number);

        if (number > 0)
        {
            Console.WriteLine("正の数です");
        }
        else if (number < 0)
        {
            Console.WriteLine("負の数です");
        }
        else
        {
            Console.WriteLine("0です");
        }
    }
}

