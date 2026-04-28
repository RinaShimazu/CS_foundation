namespace ex_02_01;

static class Program
{
    static void Main(string[] args)
    {
        Console.Write("値1を入力してください->");
        var a = int.Parse(Console.ReadLine());
        Console.Write("値2を入力してください->");
        var b = int.Parse(Console.ReadLine());
        if (a == b)
        {
            Console.WriteLine("値1と値2は等しい");
        }
        else if (a > b)
        {
            Console.WriteLine("値1は値2より大きい");
        }
        else
        {
            Console.WriteLine("値1は値2より小さい");
        }
        Console.WriteLine("終了");
        
    }
}