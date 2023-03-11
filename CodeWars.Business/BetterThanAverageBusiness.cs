namespace CodeWars.Business
{
    public class BetterThanAverageBusiness
    {
        public bool BetterThanAverage(int[] ClassPoints, int YourPoints)
        {
            decimal media = 0;
            int scoreCount = ClassPoints.Count();

            foreach (int i in ClassPoints)
            {
                media += i;
            }

            if (scoreCount == 0)
            {
                media = 0;
            }            
            else
            {
                media = media / scoreCount;
            }

            return YourPoints > media;
        }
    }
}
