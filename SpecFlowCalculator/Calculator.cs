using System;
using System.Collections.Generic;

namespace SpecFlowCalculator
{
    public class Calculator
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }

        public List<int> Numbers = new List<int>();
        public List<Tuple<int, string>> Operations = new List<Tuple<int, string>>();

        public int Calcul()
        {
            int result = 0;
            try
            {
                if(Operations.Count > 0)
                {
                    result = Operations[0].Item1;
                    for(int i = 1; i < Operations.Count; i++)
                    {
                        switch (Operations[i-1].Item2)
                        {
                            case "+":
                                result += Operations[i].Item1;
                                break;
                            case "-":
                                result -= Operations[i].Item1;
                                break;
                            case "*":
                                result *= Operations[i].Item1;
                                break;
                            case "/":
                                result /= Operations[i].Item1;
                                break;
                        }
                    }
                }
            }
            catch (Exception)
            {
                result = 0;
            }
            return result;
        }

        public int Add()
        {
            int result = 0;
            if (Numbers.Count > 0)
            {
                result = Numbers[0];
                for (int i = 1; i < Numbers.Count; i++)
                {
                    result += Numbers[i];
                }
            }
            return result;
        }
        public int Multiply()
        {
            int result = 0;
            if (Numbers.Count > 0)
            {
                result = Numbers[0];
                for(int i = 1; i < Numbers.Count; i++)
                {
                    result *= Numbers[i];
                }
            }
            return result;
        }
        public int Divide()
        {
            int result = 0;
            try
            {
                if (Numbers.Count > 0)
                {
                    result = Numbers[0];
                    for (int i = 1; i < Numbers.Count; i++)
                    {
                        result /= Numbers[i];
                    }
                }
            }
            catch (Exception)
            {
                result = 0;
            }
            return result;
        }
    }
}
//throw new NotImplementedException();