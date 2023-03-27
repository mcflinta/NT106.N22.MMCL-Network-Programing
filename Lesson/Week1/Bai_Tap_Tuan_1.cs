// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;
public class kata
{
    public static string BooleanToString(bool b)
    {   //1. Convert a Boolean to a String
        if(b == false)
            return "False";
            return "True";
    }
    
    public static class Clock
    {   //2. Beginner Series #2 Clock
        public static int Past(int h, int m, int s)
        {
            return h * 3600000 + m * 60000 + s * 1000;
        }
    }

    public static class sumNumber
    {
        public static int Sum(int[] numbers)
        {   //3. Sum without highest and lowest number
            if(numbers == null)
                return 0;
            if(numbers.Length == 0)
                return 0;
            int maxN = numbers[0];
            int minN = numbers[1];
            int flagMaxN = 0;
            int flagMinN = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                if(maxN < numbers[i])
                {
                    maxN = numbers[i];
                    flagMaxN = i;
                }
                if(minN > numbers[i])
                {
                    minN = numbers[i];
                    flagMinN = i;
                }
            }
            int result = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                if(i == flagMaxN || i == flagMinN)
                    continue;
                result += numbers[i];
            }
            return result;
        }
    }
    public class correctText
    {
        public static string Correct(string text)
        {   //4. Correct the mistake of the character recognition software
            return text.Replace('5', 'S').Replace('0', 'O').Replace('1', 'I');
        }
    }
    public static class WillThereBeEnoughSpace
    {
        public static int Enough(int cap, int on, int wait)
        {   //5. Will there be enough space?
            return (cap >= on + wait) ? 0 : (on + wait - cap);
            throw new NotImplementedException();
        }
    }

    public class removeExclamationMark
    {
        public static string removeExclamationMarks(string s)
        {   //6. Remove exclamation Marks            
            return s.Replace("!", "");
        }
    }
    
    public class keepHydrated
    {
        public static int Litres(double time)
        {   //7. Keep Hydrate
            return (int) time / 2;
        }
    }

    public static class ArrayInversion
    {
        public static int[] InvertValues(int[] input)
        {   //8. Invert values
            for(int i = 0 ; i < input.Length; i++)
                input[i] = (-1) * input[i];
            return input;
        }
    }

    public static class thirdAngleOfTriangle
    {
        public static int OtherAngle(int a, int b)
        {   //9. Third angle of trigangle
            return 180 - a -b;
            throw new NotImplementedException();
        }
    }

    public static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
    {   //10. How good are you really?
        int sumN = 0;
        for(int i = 0; i < ClassPoints.Length; i++)
            sumN += ClassPoints[i];
        int average = sumN / ClassPoints.Length;
        return (average < YourPoints) ? true : false;
    }
}