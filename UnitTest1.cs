using NUnit.Framework;
using PracticeInLab;

namespace NUnitTest_CodeWars
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        #region Test_Multiples_of_3_And_5
        [TestCase(5, 8)]
        [TestCase(10, 33)]
        public void MultiplesOf_3And5(int value, int expected)
        {
            //create instance of the class
            var codeWarsI = new CodeWarsKatas();

            var actual = codeWarsI.findSum(value);

            Assert.AreEqual(actual, expected);
        }
        #endregion

        #region TestBitcoinCount
        [TestCase(7, 3)]
        [TestCase(9, 2)]
        [TestCase(10, 2)]
        [TestCase(4, 1)]
        public void BitCounting(int value, int expected)
        {
            var codeWarI = new CodeWarsKatas();
            var actual = codeWarI.CountBits(value);
            Assert.AreEqual(actual, expected);
        }
        #endregion

        #region Test_WeIrD StRiNg CaSe
        [TestCase("Weird string case", "WeIrD StRiNg CaSe")]
        [TestCase("Once, when I was young, I coded on the Amiga!", "OnCe, WhEn I WaS YoUnG, I CoDeD On ThE AmIgA!")]
        public void ToStRiNgWeIrD(string value, string expected)
        {
            var instanceOfCodeWars = new CodeWarsKatas();
            var actual = instanceOfCodeWars.ToWeirdCase(value);
            Assert.AreEqual(actual, expected);
            // var actual = instanceOfFirst10.
        }
        #endregion

        #region Test_IQ
        [TestCase(("2 4 7 8 10"), 3)]   // // Third number is odd, while the rest of the numbers are even
        [TestCase("1 2 1 1", 2)]
        public void TestIQ_Kata(string value, int expected)
        {
            var actual = CodeWarsKatas.TestIQ(value);
            Assert.AreEqual(actual, expected);
        }
        #endregion

        #region Test_YourOrderPlease
        [TestCase("is2 Thi1s T4est 3a", "Thi1s is2 3a T4est")]
        [TestCase("4of Fo1r pe6ople g3ood th5e the2", "Fo1r the2 g3ood 4of th5e pe6ople")]
        public void Test_YourOrder(string value, string expected)
        {
            var instance_first10ex = new CodeWarsKatas();
            var actual = instance_first10ex.Order(value);
            Assert.AreEqual(actual, expected);
        }
        #endregion

        #region Test_RomanNumeralEncoder
        [TestCase(2014, "MMXIV")]
        [TestCase(1954, "MCMLIV")]
        [TestCase(1990, "MCMXC")]
        public void ConvertToRomanNumerals(int value, string expected)
        {
            var actual = CodeWarsKatas.Solution(value);
            Assert.AreEqual(actual, expected);
        }
        #endregion

        #region Test_RomanNumeralDecoder
        [TestCase("MDCXIV", 1614)]
        [TestCase("xxi", 21)]
        public void Test_DecodeRomanNum(string value, int expected)
        {
            var actual = CodeWarsKatas.DecodeRomanNum(value);
            Assert.AreEqual(actual, expected);
        }
        #endregion

        #region Test_LoveVsFriendship
        [TestCase("knowledge", 96)]
        [TestCase("friends", 75)]
        [TestCase("friends", 75)]
        [TestCase("attitude", 100)]

        public void Test_LoveVsFriendship(string value, int expected)
        {
            var codeWarInstance = new CodeWarsKatas();
            var actual = codeWarInstance.WordsToMarks(value);
            Assert.AreEqual(actual, expected);
        }
        #endregion

        #region Test_VasyaClerk()
        [TestCase(new int[] { 25, 25, 50, 50 }, "YES")]
        [TestCase(new int[] { 25, 25, 50, 50, 100 }, "NO")]
        [TestCase(new int[] { 25, 100 }, "NO")]
        public void Test_DollarChange(int[] value, string expected)
        {
            var actual = CodeWarsKatas.Tickets(value);
            Assert.AreEqual(actual, expected);
        }
        #endregion

        #region Test_CategorizeNewMember
        //[TestCase(new[] {"Senior", "Open", "Senior" }, CodeWarsKatas.OpenOrSenior(new int[][] { new int[] { 18, 20 }, new int[] { 45, 2 }, new int[] { 61, 12 }, new int[] { 37, 6 }, new int[] { 21, 21 }, new int[] { 78, 9 } }))]
        public void CategorizeOpenOrSenior(int[][] value, string[][] expected)
        {
            var actual = CodeWarsKatas.OpenOrSenior(value);
            Assert.AreEqual(actual, value);
        }
        #endregion

        #region Test_PigLatin
        [TestCase("Pig latin is cool", "igPay atinlay siay oolcay")]
        [TestCase("This is my string", "hisTay siay ymay tringsay")]
        public void Test_SimplePigLatin(string value, string expected)
        {
            var actual = CodeWarsKatas.PigIt(value);
            Assert.AreEqual(actual, expected);
        }
        #endregion

        #region Test_DescendingOrder_1Integer
        [TestCase(123456789, 987654321)]
        [TestCase(145263, 654321)]
        [TestCase(21445, 54421)]
        public void Test_DescendingOrder(int value, int expected)
        {
            var actual = CodeWarsKatas.DescendingOrder(value);
            Assert.AreEqual(actual, expected);
        }
        #endregion

        #region Test_Find_The_Parity_Outlier
        [TestCase(new int[] { 2, 4, 0, 100, 4, 11, 2602, 36 }, 11)]
        [TestCase(new int[] { 160, 3, 1719, 19, 11, 13, -21 }, -21)]
        public void FindTheUnmatchedNumber(int[] value, int expected)
        {
            var actual = CodeWarsKatas.Find(value);
            Assert.AreEqual(actual, expected);
        }
        #endregion
    }
}
