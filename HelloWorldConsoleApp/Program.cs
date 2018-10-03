using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using HelloWorldDLL;

namespace HelloWorldConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = ConfigurationSettings.AppSettings["Text"].ToString();
            string path = ConfigurationSettings.AppSettings["SaveToFilePath"].ToString();
            HelloWorldImp hwimp = new HelloWorldImp();
            
            Console.WriteLine(hwimp.GetHelloWorld(text)); // This gets from App.Config to print the value entered there.
            hwimp.SaveToTextFile(path,text);
        }
    }
}
