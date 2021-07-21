namespace StringCalculator2021_01
{
    public class StringCalculator
    {
        internal object Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
            {
                return 0;
            }
            return int.Parse(numbers);
        }
    }
}
