using LibraryForCiCdAndTest;

namespace TestLibrary
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Test1()
        {
            StringsWork stringsWork = new StringsWork();

            Assert.Throws<ArgumentNullException>(() =>
                stringsWork.SearchInString("Hello", ""));


        }


        [Test]
        public void SearchInString_ContainsSubstring_ReturnsTrue()
        {

            StringsWork stringsWork = new StringsWork();

            bool result = stringsWork.SearchInString("Hello world", "world");
            Assert.That(result, Is.True);
        }

        [Test]
        public void SearchInString_NotContainsSubstring_ReturnsFalse()
        {
            StringsWork stringsWork = new StringsWork();

            bool result = stringsWork.SearchInString("Hello world", "cat");
            Assert.That(result, Is.False);
        }
    }
}
