namespace ex_02_01;

public class ArrayCalc
{

    public int Summarize(int[] values)
    {
        int sum = 0;
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"values[{i}]={values[i]}");
            sum += values[i];
        }
        Console.WriteLine("終了");
        return sum;
    }
}