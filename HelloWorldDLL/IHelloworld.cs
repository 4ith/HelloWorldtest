using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldDLL
{
    public interface IHelloworld
    {
        string GetHelloWorld(string textToPrint);

        void SaveToDatabase();

        void SaveToTextFile(string path, string textToSave);
    }
}
