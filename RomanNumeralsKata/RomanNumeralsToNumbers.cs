namespace RomanNumerals.Kata;

public class RomanNumeralsToNumbers
{
    const int NotExist = 0;

    private static Dictionary<char, int> RomanDict = new Dictionary<char, int>()
    {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
    };

    private string ErrorMsg(string? inRomanNum)
    {
        return $"Can't convert \"{inRomanNum}\" to Numbers.";
    }

    private int MatchRomanToDict(char romanToMatchDict)
    {
        foreach (var item in RomanDict)
        {
            if (romanToMatchDict == item.Key)
                return item.Value;
        }

        return NotExist;
    }

    private bool ValidateRomanNumerals(string inRomanNum)
    {
        inRomanNum = inRomanNum.ToUpper();
        char[] romanNumArr = inRomanNum.ToCharArray();

        for (int i = 0; i < inRomanNum.Length; i++)
        {
            if (MatchRomanToDict(inRomanNum[i]) == NotExist)
                return false;
        }

        return true;
    }

    public string ConvertRomanNum(string? inRomanNum)
    {
        if (inRomanNum != null && inRomanNum != "")
        {
            if(!ValidateRomanNumerals(inRomanNum))
                return ErrorMsg(inRomanNum);
            return "Valid Roman Numeral.";
        }
        else
        {
            return ErrorMsg(inRomanNum);
        }
    }
}

