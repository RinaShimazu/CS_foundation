namespace Ex_02_06;

static class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(System.Console.ReadLine());
        Console.WriteLine("数値を入力してください->" + number);

        if (number % 4 == 0)
        {
            Console.WriteLine("4の倍数です");
        }
        else
        {
            Console.WriteLine("4の倍数ではありません");
        }
    }
}
