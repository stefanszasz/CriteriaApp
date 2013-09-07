namespace SapCriteria
{
    public class Criteria
    {
        public static InfoProvider Info
        {
            get
            {
                return new InfoProvider();
            }
        }

        public static MultiProvider MultiProvider
        {
            get
            {
                return new MultiProvider();
            }
        }
    }
}