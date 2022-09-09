using System.Linq;

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

    private int ValidateAndSumAllRomanNum(string inRomanNum)
    {
        var totalNum = 0;
        inRomanNum = inRomanNum.ToUpper();

        for (int i = 0; i < inRomanNum.Length; i++)
        {
            var romanToNum = RomanDict.Where(romanDictItem => romanDictItem.Key.Equals(inRomanNum[i])).Select(romanDictItem => romanDictItem.Value);
            if (romanToNum.Count() == NotExist)
                return NotExist;
            else
                romanToNum.ToList().ForEach(romanDictItem => totalNum += romanDictItem);
        }

        return totalNum;
    }

    private int CoreConvertor(string inRomanNum)
    {
        var totalNum = ValidateAndSumAllRomanNum(inRomanNum);

        if (totalNum != NotExist)
        {
            var convertedNum = totalNum;

            if (inRomanNum.Contains("IV") || inRomanNum.Contains("IX"))
                convertedNum -= 2;

            if (inRomanNum.Contains("XL") || inRomanNum.Contains("XC"))
                convertedNum -= 20;

            if (inRomanNum.Contains("CD") || inRomanNum.Contains("CM"))
                convertedNum -= 200;

            return convertedNum;
        }
        else
            return NotExist;
        
    }

    public string ConvertRomanNum(string? inRomanNum)
    {
        if (!String.IsNullOrEmpty(inRomanNum))
        {
            var convertedNum = CoreConvertor(inRomanNum);
            if (convertedNum == NotExist)
                return ErrorMsg(inRomanNum);
            else
                return convertedNum.ToString();
        }
        else
        {
            return ErrorMsg(inRomanNum);
        }
    }
}

