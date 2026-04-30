namespace ex_02_01;
// インスタンスの生成
static class Program
{
    static void Main(string[] args)
    {
        Warrior warrior = new("ユータ", 15);
        Console.WriteLine(warrior.name);
        Console.WriteLine(warrior.hp);

        Warrior warrior2 = new();
        warrior2.name = "ユースケ";
        warrior2.hp = 8;
        Console.WriteLine(warrior2.name);
        Console.WriteLine(warrior2.hp);

        Warrior warrior3 = new("ユダ");
        warrior3.hp = 777;
        Console.WriteLine(warrior3.name);
        Console.WriteLine(warrior3.hp);
    }
}