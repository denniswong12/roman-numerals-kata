namespace RomanNumerals.Kata;

public class RomanNumeralsToNumbers
{

    public string ConvertRomanNum(string? inRomanNum)
    {
        if (inRomanNum != null && inRomanNum != "")
        {
            return "";
        }
        else
        {
            return $"Can't convert \"{inRomanNum}\" to Numbers.";
        }
    }
}

