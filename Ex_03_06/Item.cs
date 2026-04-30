namespace Ex_03_06;

/// <summary>
/// 商品を表すクラス
/// </summary>
public class Item
{
    public int itemNo;      // 商品番号
    public string itemName; // 商品名
    public int price;       // 単価
    public double salesTaxRate = 0.10; // 消費税率(10%)

    /// <summary>
    /// 模範解答
    /// </summary>
    public Item()
    {
    }
    /// <summary>
    /// 模範解答
    /// </summary>
    /// <param name="pitemNo">商品番号</param>
    /// <param name="pitemName">商品名</param>
    /// <param name="pprice">単価</param>
    public Item(int pitemNo, string pitemName, int pprice)
    {
        // フィールドに引数をセット
        itemNo = pitemNo;
        itemName = pitemName;
        price = pprice;
    }

    /// <summary>
    /// 模範解答
    /// </summary>
    public void Print()
    {
        Console.WriteLine($"商品番号={itemNo}");
        Console.WriteLine($"商品名={itemName}");
        Console.WriteLine($"単価={price}");
    }
    /// <summary>
    /// 模範解答
    /// </summary>
    /// <param name="pprice">単価</param>
    public void ChangePrice(int pprice)
    {
        price = pprice;
    }

    public void ChangePrice(string pprice)
    {
        price = int.Parse(pprice);
    }

    /// <summary>
    /// 模範解答
    /// </summary>
    /// <returns>消費税込み金額</returns>
    public int CalculateTaxAmount()
    {
        double result = price + (price * salesTaxRate);
        return (int)result;
    }


}