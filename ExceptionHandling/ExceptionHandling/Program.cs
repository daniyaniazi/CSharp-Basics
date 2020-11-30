using System;
namespace MyNsp {
    public class DivideByOddNoException : ApplicationException
    {
        //overide virtual readonly propety
        public override string Message
        {
            get
            {
                return "Attempted to Divide by Odd Number";
            }
        }
    }
}
namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try { 
                Console.WriteLine(" ENTER 1ST NUMBER :");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine(" ENTER 2ND  NUMBER :");
                int y = int.Parse(Console.ReadLine());
                if (y == 1)
                {
                    return; //finally block will not be executed
                }
                //Throwing an exception
                if (y % 2 >=0)
                {
                    //  throw new ApplicationException("Divisor value cannot be odd number");
                    throw new MyNsp.DivideByOddNoException();
                }
                int z = x / y;
                Console.WriteLine("The result is :" + z);
                
            }
            catch(DivideByZeroException dz)
            {
                Console.WriteLine(dz.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Input must be a number");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception occur :"+ ex.Message);
            }
            finally
            {
                //Incase of abnormal termination finally block executes
                Console.WriteLine("Finally End ");
            }
            Console.WriteLine("Terminated or x is 1");
            Console.Read(); 
        }
    }
}
