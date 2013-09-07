namespace SapCriteria
{
    public class Criteria
    {
        public static AbstractProvider Info
        {
            get
            {
                return new InfoProvider();
            }
        }

        public static AbstractProvider MultiProvider
        {
            get
            {
                return new MultiProvider();
            }
        }
    }
}