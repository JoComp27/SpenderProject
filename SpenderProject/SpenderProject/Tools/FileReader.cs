using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SpenderProject.Tools
{
    static class FileReader
    {

        public static List<List<int>> ReadFile(string fileAddress)
        {

            string path = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, fileAddress);

            List<List<int>> result = new List<List<int>>();

            string[] lines = System.IO.File.ReadAllLines(path);

            for(int i = 1; i < lines.Length; i++)
            {
                List<int> parameters = new List<int>();

                string[] stringParameters = lines[i].Split(',');

                foreach (string element in stringParameters)
                {
                    parameters.Add(int.Parse(element));
                }

                result.Add(parameters);
            }

            return result;
        }

    }
}
