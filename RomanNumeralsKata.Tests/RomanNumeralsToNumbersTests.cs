namespace RomanNumeralsKata.Tests;

public class RomanNumeralsToNumbersTests
{

    private RomanNumeralsToNumbers RomanNumeralsToNumbers;

    [SetUp]
    public void Setup()
    {
        RomanNumeralsToNumbers = new RomanNumeralsToNumbers();
    }

    [Test]
    public void Convert_Invalid_Roman_Numerals_Should_Return_Error_Message()
    {
        RomanNumeralsToNumbers.ConvertRomanNum("MEEI").Should().Be("Can't convert \"MEEI\" to Numbers.");
    }

    [Test]
    public void Given_Empty_Roman_numeral_Should_Return_Error_Messag()
    {
        RomanNumeralsToNumbers.ConvertRomanNum("").Should().Be("Can't convert \"\" to Numbers.");
    }

    [Test]
    public void Given_NULL_Roman_numeral_Should_Return_Error_Messag()
    {
        RomanNumeralsToNumbers.ConvertRomanNum(null).Should().Be("Can't convert \"\" to Numbers.");
    }

    [Test]
    public void Convert_Mixed_Letter_Cases_Should_Return_A_Number()
    {
        RomanNumeralsToNumbers.ConvertRomanNum("MDcCViI").Should().Be("1707");
    }
}