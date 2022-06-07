using System;
using System.IO;
using System.Linq;
using System.Diagnostics;

namespace ReadCSV
{
    class Program
    {
        public static string[] SplitString(string arrayStr, char separator = ',')
        {
            if(string.IsNullOrEmpty(arrayStr))
            {
                // https://stackoverflow.com/questions/16834245/c-sharp-declare-empty-string-array
                return new string[] {};
            }

            // https://stackoverflow.com/questions/1977340/perform-trim-while-using-split
            string[] columns = arrayStr.Split(separator).Select(p => p.Trim()).Where(p => !string.IsNullOrWhiteSpace(p)).ToArray();

            return columns;
        }

        public static int[] BuildInputIndices(string[] expectedInputNames, string[] variablesNames)
        {
            int[] array = expectedInputNames.Select((string name) => Array.IndexOf(variablesNames, name)).ToArray();
            int firstMissing = Array.IndexOf(array, -1);
            if (firstMissing != -1)
            {
                throw new Exception("Could not find variable with name " + expectedInputNames[firstMissing]);
            }
            return array;
        }

        static void Main(string[] args)
        {
            string inputFile = args[1];
            string outputFile = args[2];
            string[] selectColumns = SplitString(args[3]); // "Col3, Col2"
            // https://stackoverflow.com/questions/33946594/c-sharp-how-to-convert-string-to-char
            char separator = char.Parse(args[4]); // ","

            // string inputFile = "example.csv";
            // string outputFile = "output.csv";
            // string[] selectColumns = SplitString("Col3, Col2");
            // char separator = ',';

            StreamWriter writer = new StreamWriter(outputFile);
            using (StreamReader reader = new StreamReader(inputFile))
            {
                string header = reader.ReadLine();
                writer.WriteLine(string.Format("{0}{2}{1}", header, "Sum", separator));

                int[] featureIndices = BuildInputIndices(selectColumns, SplitString(header));

                while (!reader.EndOfStream)
                {
                    string row = reader.ReadLine();
                    string[] rawValues = row.Split(separator);
                    int[] values = new int[featureIndices.Length];

                    bool success = true;

                    for(int i = 0; i < featureIndices.Length; i++)
                    {
                        int idx = featureIndices[i];

                        if(!int.TryParse(rawValues[idx], out values[i]))
                        {
                            Console.WriteLine($"Unable to parse selectColumns {selectColumns[i]}.");
                            success = false;
                        }
                    }

                    if(success)
                    {
                        // https://stackoverflow.com/questions/2419343/how-to-sum-up-an-array-of-integers-in-c-sharp
                        int sum = values.Sum();
                        writer.WriteLine($"{row}{separator}{sum}");
                    }
                }
            }
            writer.Close();
        }
    }
}
