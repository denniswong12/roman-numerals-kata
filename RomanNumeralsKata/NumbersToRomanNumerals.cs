using System;

namespace RomanNumerals.Kata;

public class NumbersToRomanNumerals
{
    private static Dictionary<string, int> RomanDict = new Dictionary<string, int>()
    {
        {"I", 1},
        {"IV", 4},
        {"V", 5},
        {"IX", 9},
        {"X", 10},
        {"XL", 40},
        {"L", 50},
        {"XC", 90},
        {"C", 100},
        {"CD", 400},
        {"D", 500},
        {"CM", 900},
        {"M", 1000}
    };

    private string NumberConvertor(int? inNumber)
    {
        string romanNumerals = "";

        foreach (var item in RomanDict.Reverse())
        {
            while (inNumber >= item.Value)
            {
                romanNumerals += item.Key;
                inNumber -= item.Value;
            }
        }
        return romanNumerals;
    }

    public string ConvertToRomanNumerals(int? inNumber)
    {
        if ((inNumber != null) && (inNumber > 0) && (inNumber <= 3000))
        {
            return NumberConvertor(inNumber);
        }
        else
        {
            return $"Can't convert \"{inNumber}\" to Roman Numeral.";
        }
    }
}
