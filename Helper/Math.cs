namespace UIExplorer.Helper
{
    internal static class Math
    {
        public static T DivisionOnNumber<T>(this T N1, T N2, int Repetitions)
        {
            dynamic Number = N1;

            for (int Num = 1; Num <= Repetitions; Num++)
            {
                Number /= N2;
            }

            return Number;
        }
    }
}