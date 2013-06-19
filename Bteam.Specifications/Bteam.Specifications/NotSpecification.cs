namespace Bteam.Specifications
{
    /// <summary>
    /// Niega una especificacion existente
    /// </summary>
    /// <typeparam name="T">The type of the domain entity.</typeparam>
    internal  class NotSpecification<T> : ISpecification<T>
    {
        private readonly ISpecification<T> _original;

        /// <summary>
        /// Initializes a new instance of the <see cref="NotSpecification&lt;T&gt;"/> class.
        /// </summary>
        /// <param name="original">The original.</param>
        public NotSpecification(ISpecification<T> original)
        {
            _original = original;
        }

        /// <summary>
        /// Determines whether [is satisfied by] [the specified candidate].
        /// </summary>
        /// <param name="candidate">The candidate.</param>
        /// <returns>
        /// 	<c>true</c> if [is satisfied by] [the specified candidate]; otherwise, <c>false</c>.
        /// </returns>
        public bool IsSatisfiedBy(T candidate)
        {
            return (!_original.IsSatisfiedBy(candidate));
        }
    }
}
