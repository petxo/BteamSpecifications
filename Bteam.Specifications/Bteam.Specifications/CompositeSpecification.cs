namespace Bteam.Specifications
{
    /// <summary>
    /// 
    /// </summary>
    public static class CompositeSpecification
    {
        /// <summary>
        /// Ands the specified left.
        /// </summary>
        /// <typeparam name="T">The type of the domain entity.</typeparam>
        /// <param name="leftSpecification">The left specification.</param>
        /// <param name="rightSpecification">The right specification.</param>
        /// <returns></returns>
        public static ISpecification<T> And<T>(this ISpecification<T> leftSpecification, ISpecification<T> rightSpecification)
        {
            return new AndSpecification<T>(leftSpecification, rightSpecification);
        }

        /// <summary>
        /// Ors the specified other.
        /// </summary>
        /// <typeparam name="T">The type of the domain entity.</typeparam>
        /// <param name="leftSpecification">The left specification.</param>
        /// <param name="rightSpecification">The right specification.</param>
        /// <returns></returns>
        public static ISpecification<T> Or<T>(this ISpecification<T> leftSpecification, ISpecification<T> rightSpecification)
        {
            return new OrSpecification<T>(leftSpecification, rightSpecification);
        }

        /// <summary>
        /// Nots this instance.
        /// </summary>
        /// <typeparam name="T">The type of the domain entity.</typeparam>
        /// <param name="specification">The specification.</param>
        /// <returns></returns>
        public static ISpecification<T> Not<T>(this ISpecification<T> specification)
        {
            return new NotSpecification<T>(specification);
        }        
    }
}