namespace Ex_02_12;

static class Program
{
    static void Main(string[] args)
    {
        int number = Mul3(number = int.Parse(System.Console.ReadLine()));

        Console.WriteLine("値を入力してください->" + number);

        int Mul3(int number)
        {
            return number * 3;
        }
    }
}
