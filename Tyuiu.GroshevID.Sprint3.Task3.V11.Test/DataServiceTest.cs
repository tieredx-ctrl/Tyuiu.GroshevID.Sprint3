using Tyuiu.GroshevID.Sprint3.Task3.V11.Lib;

namespace Tyuiu.GroshevID.Sprint3.Task3.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidReplaceCharOnNum()
        {
            DataService ds = new DataService();

            string value = "sqwreq vqwqq q";
            char replaceable = 'q';
            char replacement = '7';

            string res = ds.ReplaceCharOnNum(value, replaceable, replacement);
            string wait = "s7wre7 v7w77 7";

            Assert.AreEqual(wait, res);
        }
    }
}
