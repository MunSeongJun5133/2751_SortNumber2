using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2751_SortNumber2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());

            Int32 n = Int32.Parse(sr.ReadLine());
            Int32[] arr = new Int32[n];

            for(Int32 i = 0; i < arr.Length; i++)
                arr[i] = Int32.Parse(sr.ReadLine());
            

            /*Int32 tmp;

            for(Int32 i = 0; i < arr.Length - 1; i++)
            {
                for (Int32 j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }*/

            Array.Sort(arr);

            StringBuilder sb = new StringBuilder();
            for(Int32 i = 0; i < arr.Length; i++)
            {
                sb.AppendLine(arr[i].ToString());
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
