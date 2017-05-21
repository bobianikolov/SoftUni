using System;

class InstructionSet_broken
{
    static void Main()
    {

        string opCode = Console.ReadLine();

        while (opCode != "END")
        {
            string[] codeArgs = opCode.Split(' ');

            long result = 0;
            switch (codeArgs[0])
            {
                case "INC":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        result = operandOne + 1; break;
                    }
                case "DEC":
                    {
                        long operandTwo = long.Parse(codeArgs[1]);
                        result = operandTwo - 1; ; break;
                    }
                case "ADD":
                    {
                        long operandThree = long.Parse(codeArgs[1]);
                        long operandFour = long.Parse(codeArgs[2]);
                        result = operandThree + operandFour; break;
                    }
                case "MLA":
                    {
                        long operandFive = long.Parse(codeArgs[1]);
                        long operandSix = long.Parse(codeArgs[2]);
                        result = (long)(operandFive * operandSix); break;
                    }
            }
            opCode = Console.ReadLine();
            Console.WriteLine(result);
        }
    }
}