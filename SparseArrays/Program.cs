using System;

namespace SparseArrays
{
    public class SparseArrays
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the array\n");
            
            int n = Convert.ToInt32(Console.ReadLine());

            string[] strings = new string[n];

            for(int i = 0; i < n; i++)
            {
                Console.Write("\n");
                strings[i] = (Console.ReadLine());
            }

            string[] queries = new string[n];
            int[] results=new int[n];

            Console.WriteLine("\n Enter the query strings");
            for( int i = 0; i < n; ++i )
            {
                Console.WriteLine("\n");
                queries[i] = (Console.ReadLine());
            }


            //Displaying the strings
            Console.WriteLine("\nDisplaying the strings");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\n" + strings[i]);
            }


            //Displaying the queries
            Console.WriteLine("\nDisplaying the queries");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\n" +  queries[i]);
            }

            //Searching for the queries in the string array
            int count = 0;
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if (strings[i] == queries[j])
                    {
                        count++;
                    }
                }
                results[i] = count;
                count = 0;
            }

            for(int i = 0; i < n;i++)
            {
                Console.WriteLine(results[i]);
            }

        }
    }
}