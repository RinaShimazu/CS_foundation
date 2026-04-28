using System.Globalization;

namespace Ex_03_02;

static class Program
{
    static void Main(string[] args)
    {
        // インスタンスの生成
        Item item = new();

        int itemNo = int.Parse(Console.ReadLine());
        item.itemNo = itemNo;

        string itemName = Console.ReadLine();
        item.itemName = itemName;

        int price = int.Parse(Console.ReadLine());
        item.price = price;

        Console.WriteLine($"商品番号を入力してください->{item.itemNo}");
        Console.WriteLine($"商品名を入力してください->{item.itemName}");
        Console.WriteLine($"価格を入力してください->{item.price}");
    }
}




