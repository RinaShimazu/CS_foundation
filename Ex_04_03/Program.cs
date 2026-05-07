namespace Ex_04_03;

using Ex_04_03.Modules;

static class Program
{
    static void Main(string[] args)
    {
        Console.Write("社員番号を入力してください->");
        string? id = Console.ReadLine()!;
        if (id == "End")
        {
            break;
        }
        Console.Write("社員名を入力してください->");
        string? name = Console.ReadLine()!;
        Console.Write("住所を入力してください->");
        string? adress = Console.ReadLine()!;
        Employee employee = new Employee(int.Parse(id)!, name!, adress);
        employees.Add(employee);

        foreach (Employee employee in employees)
        {
            Console.WriteLine(employee);
        }
    }
}