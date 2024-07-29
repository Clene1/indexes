using BookyApp;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPrice()
        {
            Books b = new Books(150, "Life...", "What is life", "Jack Black", "Reality");
            Assert.AreEqual(b[0], 150.00);
        }
        [TestMethod]
        public void TestUpdatedAuthor()
        {
            Books b = new Books(150, "Life...", "What is life", "Jack Black", "Reality");
            b[2] = "James Novac";
            Assert.AreEqual(b[3], "Jack Black");
        }
        [TestMethod]
        public void TestGenre()
        {
            Books b = new Books(150, "Life...", "What is life", "Jack Black", "Reality");
            Assert.AreEqual(b[4], "Reality");
        }
        [TestMethod]
        public void TestTitle()
        {
            Books b = new Books(150, "Life...", "What is life", "Jack Black", "Reality");
            Assert.AreEqual(b[1], "Life...");
        }
        [TestMethod]
        public void TestUpdateGenre()
        {
            Books b = new Books(150, "Life...", "What is life", "Jack Black", "Reality");
            b[4] = "Documentary";
            Assert.AreEqual(b[4], "Documentary");
        }
    }
}