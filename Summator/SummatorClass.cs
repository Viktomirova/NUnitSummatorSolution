namespace Summator
{
    public static class SummatorClass
    {
        public static int Sum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        
        public static double Average(int[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            if (arr.Length == 0)
            {
                return 0;
            }
            return sum/arr.Length;
        }
    }
}
