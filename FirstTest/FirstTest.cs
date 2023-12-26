using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using FirstLib;

namespace FirstTest
{
    [TestClass]
    public class FirstTest
    {
        [TestMethod]
        public void CheckLib()
        {
            string path = $@"C:\Users\Юлия\source\repos\Tyuiu.NosyrevaUA.Sprint7\FirstTest\bin\Debug\Check.csv";
            FirstLibrary lib = new FirstLibrary();

            int res = lib.Number(path);
            Assert.AreEqual(res, 3);
        }
    }
}
