using System.Globalization;

namespace Ex_02_05;

static class Program
{
    static void Main(string[] args)
    {   int number = int.Parse(System.Console.ReadLine());
        Console.WriteLine("数値を入力してください->" + number);

        if (number % 2 == 0)
        {
            Console.WriteLine("結果：" + number * 10);
        }
        else
        {
            Console.WriteLine("結果" + number);
        }

        
    }
}
        
    
