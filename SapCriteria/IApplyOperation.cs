namespace SapCriteria
{
    public interface IApplyOperation : IProvideFieldsAndCriteria
    {
        Matcher And();
        Matcher Or();
    }
}