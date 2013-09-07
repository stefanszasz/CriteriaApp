using System.Collections.Generic;

namespace SapCriteria
{
    public abstract class AbstractProvider : IProvideFieldsAndCriteria
    {
        private readonly List<string> fields;
        private readonly List<string> comparisons;

        public IProvideFieldsAndFiltering WithFields(params string[] appliedFields)
        {
            foreach (var field in appliedFields)
                AddField(field);

            return new FieldsAndFilteringProvider(this);
        }

        protected AbstractProvider()
        {
            fields = new List<string>();
            comparisons = new List<string>();
        }

        public IEnumerable<string> Fields
        {
            get { return fields; }
        }

        public IEnumerable<string> Comparisons
        {
            get { return comparisons; }
        }

        internal void AddField(string fieldName)
        {
            if (fields.Contains(fieldName) == false)
                fields.Add(fieldName);
        }

        internal void AddComparison(string comparison)
        {
            if (comparisons.Contains(comparison) == false)
                comparisons.Add(comparison);
        }
    }
}