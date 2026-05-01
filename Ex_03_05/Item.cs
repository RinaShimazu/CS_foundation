namespace Ex_03_05;

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
    public void Print()
    {
        Console.WriteLine($"商品番号={itemNo}");
        Console.WriteLine($"商品名={itemName}");
        Console.WriteLine($"単価={price}");
    }

    public void ChangePrice(int pprice)
    {
        price = pprice;
    }

    public int CalculateTaxAmount()
    {
        double result = price + (price * salesTaxRate);
        return (int)result;
    }

    /// <summary>
    /// 模範解答
    /// </summary>
    /// <param name="price">金額</param>
    public void CalculateTaxAmountRef(ref int price)
    {
        price = (int)(price + (price * salesTaxRate));
    }
}lic Item(int pitemNo, string pitemName, int pprice)
    {
        // フィールドに引数をセット
        itemNo = pitemNo;
        itemName = pitemName;
        price = pprice;
    }