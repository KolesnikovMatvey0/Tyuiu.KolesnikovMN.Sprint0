using Tyuiu.KolesnikovMN.Sprint0.Task2.V0.Lib;

namespace Tyuiu.KolesnikovMN.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGeteMessageValid()
        {
            var name = "������";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("������, ������", res);
        }
    }
}