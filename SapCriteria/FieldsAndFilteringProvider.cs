using System.Collections.Generic;

namespace SapCriteria
{
    public class FieldsAndFilteringProvider : IProvideFieldsAndFiltering
    {
        private readonly AbstractProvider abstractProvider;

        public FieldsAndFilteringProvider(AbstractProvider abstractProvider)
        {
            this.abstractProvider = abstractProvider;
        }

        public IEnumerable<string> Fields { get { return abstractProvider.Fields; }}
        public IEnumerable<string> Comparisons { get { return abstractProvider.Comparisons; }}
        
        public Matcher Where()
        {
            return new Matcher(abstractProvider);
        }
    }
}