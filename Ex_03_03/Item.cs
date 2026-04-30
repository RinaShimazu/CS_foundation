namespace Ex_03_03;

/// <summary>
/// 演習-02 インスタンスを複数作成し、値が個別に保持されていることを確認
/// 商品を表すクラス
/// </summary>
public class Item
{
    public int itemNo;      // 商品番号
    public string itemName; // 商品名
    public int price;       // 単価
    /// <summary>
    /// 模範解答
    /// </summary>
    public void Print()
    {
        Console.WriteLine($"商品番号={itemNo}");
        Console.WriteLine($"商品名={itemName}");
        Console.WriteLine($"単価={price}");
    }
}