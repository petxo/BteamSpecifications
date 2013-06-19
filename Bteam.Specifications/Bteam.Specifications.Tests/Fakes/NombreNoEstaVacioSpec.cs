namespace Bteam.Specifications.Tests.Fakes
{
    public class NombreNoEstaVacioSpec : ISpecification<FakeEntity>
    {
        /// <summary>
        /// Determines whether [is satisfied by] [the specified candidate].
        /// </summary>
        /// <param name="candidate">The candidate.</param>
        /// <returns>
        /// 	<c>true</c> if [is satisfied by] [the specified candidate]; otherwise, <c>false</c>.
        /// </returns>
        public bool IsSatisfiedBy(FakeEntity candidate)
        {
            return candidate.Name != string.Empty;
        }
    }
}