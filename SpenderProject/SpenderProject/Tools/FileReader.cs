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

        public static List<List<int>> ReadFile(string relativePath)
        {

            List<List<int>> result = new List<List<int>>();

            string fullPath = Path.GetFullPath(relativePath);

            string[] lines = System.IO.File.ReadAllLines(Path.GetFullPath(fullPath));

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
