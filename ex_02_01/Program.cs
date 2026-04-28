namespace ex_02_01;

static class Program
{
    static void Main(string[] args)
    {
        string day = "明日";
        string wether = "休み";
        // 可変数の引数を渡せる
        StringConcatenation(day, "は", wether, "です。");
        /// <summary>
        /// 引数の文字列を結合して表示する
        /// </summary>
        /// <param name="strings">結合する文字列</param>
        static void StringConcatenation(params string[] strings)
        {
            var result = "";
            for (int i = 0; i < strings.Length; i++)
            {
                result += strings[i];
            }
            Console.WriteLine(result);
        }
    }

}