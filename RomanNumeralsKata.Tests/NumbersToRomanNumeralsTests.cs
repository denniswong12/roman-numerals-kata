namespace RomanNumeralsKata.Tests;

public class NumbersToRomanNumeralsTests
{

    private NumbersToRomanNumerals NumbersToRomanNumerals;

    [SetUp]
    public void Setup()
    {
        NumbersToRomanNumerals = new NumbersToRomanNumerals();
    }

    [Test]
    public void Convert_Minus_One_To_Roman_Numerals_Should_Return_Error_Message()
    {
        NumbersToRomanNumerals.ConvertToRomanNumerals(-1).Should().Be("Can't convert \"-1\" to Roman Numeral.");
    }

    [Test]
    public void Convert_0_To_Roman_Numerals_Should_Return_Error_Message()
    {
        NumbersToRomanNumerals.ConvertToRomanNumerals(0).Should().Be("Can't convert \"0\" to Roman Numeral.");
    }

    [Test]
    public void Convert_3001_To_Roman_Numerals_Should_Return_Error_Message()
    {
        NumbersToRomanNumerals.ConvertToRomanNumerals(3001).Should().Be("Can't convert \"3001\" to Roman Numeral.");
    }

    [Test]
    public void Convert_null_To_Roman_Numerals_Should_Return_Error_Message()
    {
        NumbersToRomanNumerals.ConvertToRomanNumerals(null).Should().Be("Can't convert \"\" to Roman Numeral.");
    }

    [Test]
    public void Convert_1_To_Roman_Numerals_Should_Return_I()
    {
        NumbersToRomanNumerals.ConvertToRomanNumerals(1).Should().Be("I");
    }

    [Test]
    public void Convert_4_To_Roman_Numerals_Should_Return_IV()
    {
        NumbersToRomanNumerals.ConvertToRomanNumerals(4).Should().Be("IV");
    }

    [Test]
    public void Convert_6_To_Roman_Numerals_Should_Return_VI()
    {
        NumbersToRomanNumerals.ConvertToRomanNumerals(6).Should().Be("VI");
    }

    [Test]
    public void Convert_11_To_Roman_Numerals_Should_Return_XI()
    {
        NumbersToRomanNumerals.ConvertToRomanNumerals(11).Should().Be("XI");
    }

    [Test]
    public void Convert_1466_To_Roman_Numerals_Should_Return_MCDLXVI()
    {
        NumbersToRomanNumerals.ConvertToRomanNumerals(1466).Should().Be("MCDLXVI");
    }

    [Test]
    public void Convert_1549_To_Roman_Numerals_Should_Return_MDXLIX()
    {
        NumbersToRomanNumerals.ConvertToRomanNumerals(1549).Should().Be("MDXLIX");
    }

    [Test]
    public void Convert_1596_To_Roman_Numerals_Should_Return_MDXCVI()
    {
        NumbersToRomanNumerals.ConvertToRomanNumerals(1596).Should().Be("MDXCVI");
    }

    [Test]
    public void Convert_1666_To_Roman_Numerals_Should_Return_MDCLXVI()
    {
        NumbersToRomanNumerals.ConvertToRomanNumerals(1666).Should().Be("MDCLXVI");
    }

    [Test]
    public void Convert_1966_To_Roman_Numerals_Should_Return_MCMLXVI()
    {
        NumbersToRomanNumerals.ConvertToRomanNumerals(1966).Should().Be("MCMLXVI");
    }

    [Test]
    public void Convert_2018_To_Roman_Numerals_Should_Return_MMXVIII()
    {
        NumbersToRomanNumerals.ConvertToRomanNumerals(2018).Should().Be("MMXVIII");
    }

    [Test]
    public void Convert_3000_To_Roman_Numerals_Should_Return_MMM()
    {
        NumbersToRomanNumerals.ConvertToRomanNumerals(3000).Should().Be("MMM");
    }
}