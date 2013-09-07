namespace SapCriteria
{
    public interface IOperation
    {
        ICompareOperation Is { get;  }
        IApplyOperation StartsWith(string startingValue);
    }
}