namespace Ex_03_03;

static class Program
{
    static void Print(string[] args)
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
    public void ChangePrice(int pprice)
    {
        int pprice = int.Parse(Console.ReadLine());
        item.pprice = pprice;
        Console.WriteLine($"新しい価格を入力してください->{item.pprice}");
    }
}
