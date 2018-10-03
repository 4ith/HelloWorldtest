using System;
using HelloWorldDLL;
using HelloWorldWebApp;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;
using System.Web.Services.Description;

namespace UnitTestProjectHW
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
        [TestMethod]
        public void HelloWolrd()
        {
            String text = new HelloWorldDLL.HelloWorldImp().GetHelloWorld("Hello World");
            Assert.AreEqual("Hello World", text);
        }

        [TestMethod]
        public void SavetoFile()
        {
            String mydocpath = "C:\\Users\\chari\\source\\repos\\HelloWorldConsoleApp\\HelloWorldConsoleApp\\bin\\Debug";
            new HelloWorldImp().SaveToTextFile(mydocpath, "Hello World");
            using (StreamReader outputFile = new StreamReader(Path.Combine(mydocpath, "HelloWorld.txt")))
            {
                // foreach (string line in lines)
                String text2 = outputFile.ReadLine();
                Assert.AreEqual("Hello World", text2);
            }
            
        }
        

    }
}
