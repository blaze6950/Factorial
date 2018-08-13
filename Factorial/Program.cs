using System;
using System.IO;

namespace Factorial
{
    class Program
    {
        static void Main()
        {
            try
            {
                FactorialNumber.DoCycle();
                FactorialNumber.DoRecursion();
            }
            catch (OutOfMemoryException e)
            {
                Console.WriteLine(e);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e);
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e);
            }
            catch (IOException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
