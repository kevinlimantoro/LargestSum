using System;

namespace CodeWars
{
    public static class Kata
    {
        public static int LargestSum(int[] arr)
        {
            var res = 0;
            var maxres = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                res += arr[i];
                if(res < 0)
                {
                    res = 0;
                }
                if (maxres < res)
                {
                    maxres = res;
                }
            }
            return maxres;
        }
    }
}
