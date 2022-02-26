using System;

namespace T16.InstructionSet
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split();

            while (array[0] != "END")
            {
                long result = 0;
                switch (array[0])
                {
                    case "INC":
                        {
                            long operandOne = long.Parse(array[1]);
                            result = operandOne + 1;
                            Console.WriteLine(result);
                            break;
                        }
                    case "DEC":
                        {
                            long operandOne = long.Parse(array[1]);
                            result = operandOne - 1;
                            Console.WriteLine(result);
                            break;
                        }
                    case "ADD":
                        {
                            long operandOne = long.Parse(array[1]);
                            long operandTwo = long.Parse(array[2]);
                            result = operandOne + operandTwo;
                            Console.WriteLine(result);
                            break;
                        }
                    case "MLA":
                        {
                            long operandOne = long.Parse(array[1]);
                            long operandTwo = long.Parse(array[2]);
                            result = operandOne * operandTwo;
                            Console.WriteLine(result);
                            break;
                        }

                }

                array = Console.ReadLine().Split();
            }
        }
    }
}
