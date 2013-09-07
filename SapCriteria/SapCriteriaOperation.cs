using System.Collections.Generic;

namespace SapCriteria
{
    public class SapCriteriaOperation : IApplyOperation, IOperation, ICompareOperation
    {
        private readonly AbstractProvider provider;
        private readonly string currentField;

        public SapCriteriaOperation(AbstractProvider provider, string currentField)
        {
            this.provider = provider;
            this.currentField = currentField;
        }

        public IApplyOperation StartsWith(string startingValue)
        {
            provider.AddComparison(string.Format("{0} LIKE {1}%", currentField, startingValue));
            return this;
        }

        public ICompareOperation Is
        {
            get
            {
                return this;
            }
        }

        private ICompareOperation not;
        public ICompareOperation Not
        {
            get
            {
                not = this;
                return not;
            }
        }

        public IApplyOperation EqualTo(object value)
        {
            if (not == null)
                provider.AddComparison(currentField + " == " + value);

            else
                provider.AddComparison(currentField + " <> " + value);

            return this;
        }

        public AbstractProvider ToCriteria()
        {
            return provider;
        }

        public Matcher And()
        {
            provider.AddComparison(" AND ");
            return new Matcher(provider);
        }

        public Matcher Or()
        {
            provider.AddComparison(" OR ");
            return new Matcher(provider);
        }

        public IEnumerable<string> Fields
        {
            get
            {
                return provider.Fields;
            }
        }

        public IEnumerable<string> Comparisons
        {
            get
            {
                return provider.Comparisons;
            }
        }

        public override string ToString()
        {
            return string.Format("SELECT {0} \r\n WHERE \r\n {1}", string.Join(", ", provider.Fields), string.Join(" \r\n", provider.Comparisons));
        }
    }
}