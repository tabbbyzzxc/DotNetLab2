using ConsoleApp1;
using System.Collections;

/*Program p1 = new Program();
Program p2 = new Program();
ConsoleUtil.Calc<string>(new string[] { "123" }, "123");
 */

internal class Program
{
    private static void Main(string[] args)
    {

        var qwe = "qwe";
        string[] array2 = { "balls", "phone", "qwe", "balls" };
        Console.WriteLine(qwe.Invert());
        Console.WriteLine(array2.CountOccurrences("balls"));
        var unified = array2.Unify();
        foreach (var i in unified)
        {
            Console.Write(i + " ");
        }

        ExtendedDictionary<string, int, double> dic = new();

        dic.Add("key", 1, 2);
        dic.Add("qwe", 3, 4);
        Console.WriteLine(dic.ExistsWithKey("qs"));
        Console.WriteLine(dic.ExistsWithKey("key"));
        Console.WriteLine(dic.ExistsWithValue(1, 2));
        Console.WriteLine(dic.ExistsWithValue(1, 5));
        foreach (var item in dic.Elements)
        {
            Console.WriteLine($"Key: {item.TKeyValue}, U: {item.UValue}, V: {item.VValue}");
        }
    }
}