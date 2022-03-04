using System;
using System.Linq;

namespace Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] MyArray = { "abcw", "baz", "foo", "bar", "xtfn", "abcdef"};
            var result = GetMaximumLenght(MyArray);
            Console.WriteLine(result);
            Console.ReadKey();

        }
        public static int GetMaximumLenght(string[] arr)
        {
            int MaxLenght = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (!arr[i].Equals(arr[j]))
                    {
                        MaxLenght = arr[i].Length * arr[j].Length;
                        break;
                    }
                    else
                    {
                        MaxLenght = 0;
                    }
                }
            }
            return MaxLenght;
        }
    }
}
