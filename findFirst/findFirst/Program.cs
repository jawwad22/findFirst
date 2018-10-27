using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace findFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> Production = new Dictionary<string, string>();
            Production.Add("E", "TD");
            Production.Add("D", "+TD|$");
            Production.Add("T", "FS");
            Production.Add("S", "*FS|$");
            Production.Add("F", "(E)|a");
            Dictionary<string, string> tempPro = Production;
            foreach (KeyValuePair<string, string> s in Production)
            {
                Console.WriteLine("First of " + s.Key + "");
                string Value = s.Value;
                string[] splitValue = Value.Split('|');
                foreach (string split in splitValue)
                {
                    string temp = split[0].ToString();
                   
                    do
                    {
                        if (tempPro.ContainsKey(temp.ToString()))
                        {
                            temp = tempPro[temp[0].ToString()];
                            temp = temp[0].ToString();
                        }
                        else {
                            Console.Write(temp);
                            Console.WriteLine();
                            break;
                        }
                    } 
                    while (true);
                }
            }

        }
    }
}

