using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public static class AbbrevationUtility
{
    private static readonly SortedDictionary<int, string> abbrevations = new SortedDictionary<int, string>
     {
         {1000,"a"}, //K
         {1000000, "b" }, //M
         {1000000000, "c" }, //B
     };

    public static string AbbreviateNumber(float number)
    {
        for (int i = abbrevations.Count - 1; i >= 0; i--)
        {
            KeyValuePair<int, string> pair = abbrevations.ElementAt(i);
            if (Mathf.Abs(number) >= pair.Key)
            {
                int roundedNumber = Mathf.FloorToInt(number / pair.Key);
                return roundedNumber.ToString() + pair.Value;
            }
        }
        return number.ToString();
    }
}
