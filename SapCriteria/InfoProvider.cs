namespace SapCriteria
{
    public class InfoProvider : AbstractProvider, IProvideFields
    {
        public Matcher Where()
        {
            return new Matcher(this);
        }
    }
}