namespace CodeWars.Business
{
    public class EvenOrOddBusiness
    {
        public string EvenOrOdd(int number)
        {
            string result = string.Empty;
            if (number % 2 == 0) 
            {
                result = "Even";
            }
            else
            {
                result = "Odd";
            }

            return result;
        }

    }
}