namespace Bteam.Specifications.Tests.Fakes
{
    public class FakeSpec5 : ISpecification<FakeEntity, FakeEntity, FakeEntity, FakeEntity, FakeEntity>
    {
        /// <summary>
        /// Determines whether [is satisfied by] [the specified candidate].
        /// </summary>
        /// <param name="candidate">The candidate.</param>
        /// <param name="candidate2">The candidate2.</param>
        /// <param name="candidate3">The candidate3.</param>
        /// <param name="candidate4">The candidate4.</param>
        /// <param name="candidate5">The candidate5.</param>
        /// <returns>
        ///   <c>true</c> if [is satisfied by] [the specified candidate]; otherwise, <c>false</c>.
        /// </returns>
        public bool IsSatisfiedBy(FakeEntity candidate, FakeEntity candidate2, FakeEntity candidate3, FakeEntity candidate4, FakeEntity candidate5)
        {
            return true;
        }
    }
}