namespace Bteam.Specifications
{
    /// <summary>
    /// Especificacion para unir dos especificaciones y que se cumplan las dos
    /// </summary>
    internal class AndSpecification<T> : ISpecification<T>
    {
        readonly ISpecification<T> _leftSpecification;
        readonly ISpecification<T> _rightSpecification;

        /// <summary>
        /// Initializes a new instance of the <see cref="AndSpecification&lt;T&gt;"/> class.
        /// </summary>
        /// <param name="leftSpecfication">The left specfication.</param>
        /// <param name="rightSpecification">The right specification.</param>
        public AndSpecification(ISpecification<T> leftSpecfication, ISpecification<T> rightSpecification)
        {
            _leftSpecification = leftSpecfication;
            _rightSpecification = rightSpecification;
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
            return (_leftSpecification.IsSatisfiedBy(candidate) && _rightSpecification.IsSatisfiedBy(candidate));
        }
    }
}
