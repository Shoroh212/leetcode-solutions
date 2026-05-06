
using System.Collections.Generic;

public class Solution
{
    public static void Main(string[] args)
    {
        var l1 = new List<int> { 1, 2 };
        var l2 = new List<int> { 1, 2 };

        AddTwoNumbers(l1, l2);
    }


    public static void AddTwoNumbers(List<int> l1, List<int> l2)
    {
        string s1 = string.Join("", l1);
        string s2 = string.Join("", l2);

        /*
        string text1 =l1.ToString();
        string text2 =l2.ToString();


        var answer =text1 + text2;
        */
        int n1 = int.Parse(s1);
        int n2 = int.Parse(s2);

        int sum = n1 + n2;

        Console.WriteLine(sum);

        
        var result = sum.ToString() .Select(c => int.Parse(c.ToString()))
                        .ToList();

        Console.WriteLine(string.Join(", ", result));
    }
}
