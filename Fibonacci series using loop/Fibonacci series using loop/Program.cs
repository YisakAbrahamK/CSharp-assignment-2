namespace Fibonacci_series_using_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxNum,nextTerm=0,t1=0,t2=1;
            do
            {                    
                Console.Write("Enter the max num: ");
                maxNum = Convert.ToInt32(Console.ReadLine());
                if (maxNum <= 0)
                {
                    Console.WriteLine("Invalid value enter again.");
                }
            } while (maxNum <= 0);

            Console.Write("Fibonacci series up to "+ maxNum + " is: 0 1 ");
            nextTerm = t1 + t2;
            while (nextTerm <= maxNum)
            {
                Console.Write(nextTerm+" ");
                t1 = t2;
                t2 = nextTerm;
                nextTerm = t1 + t2;
            }
        }
    }
}