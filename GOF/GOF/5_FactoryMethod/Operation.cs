﻿namespace GOF._5_FactoryMethod
{
    public class Operation
    {
        public Double Arg1;
        public Double Arg2;

        public virtual Double GetResult()
        {
            Double result = 0;
            return result;
        }
    }
}