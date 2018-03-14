using System;
using System.IO;

namespace Ch3_Decorator.IO
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;

            try
            {
                TextReader inStream = new LowerCaseInputStream(
                    //put a copy in the same dir as your executable.
                    new StreamReader("test.txt")
                );

                while ((input = inStream.Read()) >= 0)
                {
                    Console.Write((char)input);
                }
            }

            catch (IOException e)
            {
                Console.WriteLine(e.StackTrace);
            }

            finally
            {
                Console.ReadKey();
            }
        }
    }
}
