using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioCSharp.section07_collections
{
    internal static class @params
    {
        public static double Max(params double[] input)
        {
            double max = double.MinValue;
            foreach (var item in input)
            {
                if (item >max)
                {
                    max = item;
                }
            }
            return max;
        }
        public static double Min(params double[] input)
        {
            double min = double.MaxValue;
            foreach(var item in input)
            {
                if(item < min)
                {
                    min = item;
                }
            }
            return min;
        }
        public static double Median(params double[] input)
        {
            
            int middleInput = 0;
            if(input.Length%2==0) {
                middleInput = input.Length / 2;
                return (input[middleInput] + input[middleInput-1])/2;

            }
            else
            {
                middleInput = input.Length / 2;
                return input[middleInput];


            }


        }
        public static double Mean(params double[] input)
        {
            double result = 0;
            foreach (double i in input)
            {
                result += i;
            }
            return result/input.Length;
        }
        public static double Sum(params double[] input)
        {
            double result = 0;
            foreach (double i in input)
            {
                result += i;
            }
            return result;
        }
    }
}
