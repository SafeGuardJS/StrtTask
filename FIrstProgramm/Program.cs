using System;

namespace FIrstProgramm
{
    class Program
    {
        static void Main(string[] args)
        {
            float key;
            float[] new_Array = { 1.23F, 2.2F, -3.23F, 4.23F, 5.0F, 6.0F, 7.0F, 8.0F, 9.0F, 10.0F};
            foreach(float i in new_Array)
            {
                Console.Write(i + " ");
            }

            if((new_Array.Length % 2) == 0)
            {
                for(int i = 0; i < new_Array.Length / 2; i++)
                {
                    key = new_Array[new_Array.Length - 1 - i];
                    new_Array[new_Array.Length - i - 1] = new_Array[i];
                    new_Array[i] = key;
                }
            }
            else
            {
                for (int i = 0; i < new_Array.Length / 2; i++)
                {
                    key = new_Array[new_Array.Length - 1 - i];
                    new_Array[new_Array.Length - i - 1] = new_Array[i];
                    new_Array[i] = key;
                    if (i == (new_Array.Length - 1) / 2) break;
                }

            }

            Console.WriteLine("");

            foreach(float i in new_Array)
            {
                Console.Write($"{i} ");
            }

           
        }
    }
}
