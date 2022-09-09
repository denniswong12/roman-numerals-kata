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

    [Test]
    public void Convert_Roman_Numerals_I_Should_Return_1()
    {
        RomanNumeralsToNumbers.ConvertRomanNum("I").Should().Be("1");
    }

    [Test]
    public void Convert_Roman_Numerals_IV_Should_Return_4()
    {
        RomanNumeralsToNumbers.ConvertRomanNum("IV").Should().Be("4");
    }

    [Test]
    public void Convert_Roman_Numerals_VI_Should_Return_6()
    {
        RomanNumeralsToNumbers.ConvertRomanNum("VI").Should().Be("6");
    }

    [Test]
    public void Convert_Roman_Numerals_XI_Should_Return_11()
    {
        RomanNumeralsToNumbers.ConvertRomanNum("XI").Should().Be("11");
    }

    [Test]
    public void Convert_Roman_Numerals_MCDLXVI_Should_Return_1466()
    {
        RomanNumeralsToNumbers.ConvertRomanNum("MCDLXVI").Should().Be("1466");
    }

    [Test]
    public void Convert_Roman_Numerals_MDXLIX_Should_Return_1549()
    {
        RomanNumeralsToNumbers.ConvertRomanNum("MDXLIX").Should().Be("1549");
    }

    [Test]
    public void Convert_Roman_Numerals_MDXCVI_Should_Return_1596()
    {
        RomanNumeralsToNumbers.ConvertRomanNum("MDXCVI").Should().Be("1596");
    }

    [Test]
    public void Convert_Roman_Numerals_MDCLXVI_Should_Return_1666()
    {
        RomanNumeralsToNumbers.ConvertRomanNum("MDCLXVI").Should().Be("1666");
    }

    [Test]
    public void Convert_Roman_Numerals_MCMLXVI_Should_Return_1966()
    {
        RomanNumeralsToNumbers.ConvertRomanNum("MCMLXVI").Should().Be("1966");
    }

    [Test]
    public void Convert_Roman_Numerals_MMXVIII_Should_Return_2018()
    {
        RomanNumeralsToNumbers.ConvertRomanNum("MMXVIII").Should().Be("2018");
    }

    [Test]
    public void Convert_Roman_Numerals_MMM_Should_Return_3000()
    {
        RomanNumeralsToNumbers.ConvertRomanNum("MMM").Should().Be("3000");
    }
}