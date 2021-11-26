using System;

namespace bubblesort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers={5,8,2,9,1};
            System.Console.WriteLine("array before sort");
            System.Console.WriteLine(string.Join(',',numbers));
            for(int i=0;i<numbers.Length-1;i++)
            {
             for(int j=0;j<numbers.Length-1-i;j++)
             {
            if(numbers[j]>numbers[j+1])
            {
                int temp=numbers[j];
                numbers[j]=numbers[j+1];
                numbers[j+1]=temp;
            }
             }
             

            }
            System.Console.WriteLine("sorted array");
            System.Console.WriteLine(String.Join(',',numbers));

        }
    }
}
