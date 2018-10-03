using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HelloWorldDLL
{
    public class HelloWorldImp:IHelloworld
    {
        public string GetHelloWorld(string textToPrint)
        {
            return textToPrint;
        }

        public void SaveToDatabase()
        {
            throw new NotImplementedException();
        }

        public void SaveToTextFile(string path,string textToSave)
        {
            // Set a variable to the My Documents path.
            string mydocpath = path;
                //Environment.GetFolderPath(path);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(mydocpath, "HelloWorld.txt")))
            {
               // foreach (string line in lines)
                    outputFile.WriteLine(textToSave);
            }
        }

       
    }
}
