namespace Fibonacci_series_using_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Continue="No";
            /*The following outer do while loop is responsible
              to make the user chooce whether to 
              continue to use the program or exit*/ 
            do
            {
                int maxNum=-1, nextTerm = 0, t1 = 0, t2 = 1;
                string recivedString;
                do
                {
                    Console.Write("Enter the max num: ");
                    recivedString = Console.ReadLine();
                    if (isNumber(recivedString))
                    {
                        maxNum = Convert.ToInt32(recivedString);
                        if (maxNum < 1)
                        {
                            Console.WriteLine("Please enter a number grater than 0.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid value enter again.");
                    }
                } while (isNumber(recivedString) != true || maxNum < 1);

                Console.Write("Fibonacci series up to " + maxNum + " is: 0 1 ");
                nextTerm = t1 + t2;
                while (nextTerm <= maxNum)
                {
                    Console.Write(nextTerm + " ");
                    t1 = t2;
                    t2 = nextTerm;
                    nextTerm = t1 + t2;
                }
                Console.WriteLine(); //To add new line
                Console.Write("Enter anything to continue 'q' to quit  : ");
                Continue = Console.ReadLine();

            } while (Continue != "q");

        }


        /* This function will check whether a string is a number or not*/
        static Boolean isNumber(String value)
        {
            for(int i = 0; i < value.Length; i++)
            {
                if (value[i]<'0' || value[i] > '9')
                {
                    return false;
                }
            }
            return true;
        }
    }
}