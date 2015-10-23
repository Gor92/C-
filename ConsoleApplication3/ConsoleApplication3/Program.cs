using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication3
{
    class Program
    {
       static  List<string> stringlist()
        {
            string line = "";
            string file = "TextFile1.txt";
            List<string> str = new List<string>();

            StreamReader s = new StreamReader(file);

            while (s.EndOfStream == false)
            {

                line = s.ReadLine();
                if (line != null)
                {
                    string fullname = "";
                    string email = "";
                    int lt = line.IndexOf("<");
                    int gt = line.IndexOf(">");
                    fullname = line.Substring(0, lt);
                    str.Add(fullname);
                }
            }
            s.Close();
            foreach (var item in str)
            {
                Console.WriteLine(item);
            }

            return str;
        }
        static void Main(string[] args)
        {
            stringlist();
            
            
           
            Console.ReadKey();

        }
    }
}
