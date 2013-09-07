using System.Linq;
using Xunit;
using SapCriteria;
namespace CriteriaApp
{
    public class CriteriaTests
    {
        [Fact]
        public void Simple_equality_two_fields()
        {
            var provider = Criteria.Info.WithFields("a", "b").Where().Field("a").Is.EqualTo("s");
            Assert.Equal(provider.Comparisons.First(), "a == s");
        }

        [Fact]
        public void Simple_inequality_two_fields()
        {
            var provider = Criteria.Info.WithFields("a", "b").Where().Field("a").Is.Not.EqualTo("s");
            Assert.Equal(provider.Comparisons.First(), "a <> s");
        }

        [Fact]
        public void Simple_equality_two_fields_multiple_where()
        {
            var provider = Criteria.Info.WithFields("a", "b", "x")
                .Where()
                .Field("a").Is.EqualTo("1")
                .And()
                .Field("b").Is.Not.EqualTo("2");
                
            var s = provider.ToString();
            Assert.Equal(provider.Comparisons.First(), "a == 1");
            Assert.Equal(provider.Comparisons.Last(), "b <> 2");
        }
    }
}
