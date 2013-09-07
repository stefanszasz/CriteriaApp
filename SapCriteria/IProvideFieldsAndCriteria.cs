using System.Collections.Generic;

namespace SapCriteria
{
    public interface IProvideFieldsAndCriteria
    {
        IEnumerable<string> Fields { get; }
        IEnumerable<string> Comparisons { get; }
    }
}