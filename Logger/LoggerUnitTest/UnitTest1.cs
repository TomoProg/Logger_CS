using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;
using System.IO;
using MyUtility;

namespace LoggerUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// ファイルの最終行に指定した内容が書き込まれているかをテストする
        /// </summary>
        [TestMethod]
        public void TestFileContents()
        {
            string fileMakePath = "test.txt";
            string writeContents = "TestMethod1";
            Logger l = new Logger(fileMakePath, Encoding.UTF8);

            l.Write(writeContents);
            
            string[] fileContents = File.ReadAllLines(fileMakePath);
            string lastLine = fileContents[fileContents.Length - 1];

            Func<string, string, bool> isExistString = 
                (line, searchString) => { return line.IndexOf(searchString) >= 0 ? true : false; };

            Assert.AreEqual(expected: true, actual: isExistString(lastLine, writeContents));
            Assert.AreEqual(expected: false, actual: isExistString(lastLine, "TestMethod2"));
        }

        /// <summary>
        /// ファイルが作成されているかをテストする
        /// </summary>
        [TestMethod]
        public void TestMakeFile()
        {
            string fileMakePath = "test.txt";
            string writeContents = "TestMethod1";
            Logger l = new Logger(fileMakePath, Encoding.UTF8);
            
            if (File.Exists(fileMakePath))
            {
                File.Delete(fileMakePath);
            }
            l.Write(writeContents);

            Assert.AreEqual(expected: true, actual: File.Exists(fileMakePath));
        }
    }
}
