namespace SapCriteria
{
    public interface ICompareOperation
    {
        IApplyOperation EqualTo(object value);
        ICompareOperation Not { get; }
    }
}