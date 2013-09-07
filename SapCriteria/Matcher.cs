using System.Linq;

namespace SapCriteria
{
    public class Matcher
    {
        private readonly AbstractProvider provider;

        public Matcher(AbstractProvider provider)
        {
            this.provider = provider;
        }

        public IOperation Field(string fieldName)
        {
            var foundField = provider.Fields.Single(f => f == fieldName);
            return new SapCriteriaOperation(provider, foundField);
        }
    }
}