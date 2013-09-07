namespace SapCriteria
{
    public interface IProvideFieldsAndFiltering : IProvideFieldsAndCriteria
    {
        Matcher Where();
    }
}