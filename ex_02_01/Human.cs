namespace ex_02_01;

public class Human
{
    public string Name { get; set; }
    public int Hp { get; private set; }

    public void Greet()
    {
        Console.WriteLine("Hi!");
    }

    public void Defence(int damage)
    {
        Hp -= damage;
    }
}
