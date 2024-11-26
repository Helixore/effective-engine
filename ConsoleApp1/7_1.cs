using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Seven() 
    {
        
        public void ToFile(string path, string message)
        {
            File.WriteAllText(path, message);
        }
        public string FromFile(string path)
        {
            if (File.Exists(path))
            {
                return File.ReadAllText(path);
            }
            else
            {
                return "";
            }
        }
        public List<string> ToList(string path)
        {
            List<string> temp = new List<string>();
            if (File.Exists(path))
            {
                var s = File.ReadLines(path);
                foreach (var line in s)
                {
                    temp.Add(line);
                }
                return temp;
            }
            else
            {
                return temp;
            }

        }
        public string whatGender(string PESEL)
        {
            int i = Int32.Parse(PESEL.Substring(9,1));
            if (i % 2 == 0)
            {
                return "Female";
            }
            else
            {
                return "Male";
            }
        }
    }
}
