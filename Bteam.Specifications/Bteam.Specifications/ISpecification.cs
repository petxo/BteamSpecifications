namespace Bteam.Specifications
{
    /// <summary>
    /// 
    /// </summary>
    public interface ISpecification<in T>
    {
        /// <summary>
        /// Determines whether [is satisfied by] [the specified candidate].
        /// </summary>
        /// <param name="candidate">The candidate.</param>
        /// <returns>
        /// 	<c>true</c> if [is satisfied by] [the specified candidate]; otherwise, <c>false</c>.
        /// </returns>
        bool IsSatisfiedBy(T candidate);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T1">The type of the 1.</typeparam>
    /// <typeparam name="T2">The type of the 2.</typeparam>
    public interface ISpecification<in T1, in T2>
    {
        /// <summary>
        /// Determines whether [is satisfied by] [the specified candidate].
        /// </summary>
        /// <param name="candidate1">The candidate1.</param>
        /// <param name="candidate2">The candidate2.</param>
        /// <returns>
        /// 	<c>true</c> if [is satisfied by] [the specified candidate]; otherwise, <c>false</c>.
        /// </returns>
        bool IsSatisfiedBy(T1 candidate1, T2 candidate2);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T1">The type of the 1.</typeparam>
    /// <typeparam name="T2">The type of the 2.</typeparam>
    /// <typeparam name="T3">The type of the 3.</typeparam>
    public interface ISpecification<in T1, in T2, in T3>
    {
        /// <summary>
        /// Determines whether [is satisfied by] [the specified candidate].
        /// </summary>
        /// <param name="candidate1">The candidate1.</param>
        /// <param name="candidate2">The candidate2.</param>
        /// <param name="candidate3">The candidate3.</param>
        /// <returns>
        ///   <c>true</c> if [is satisfied by] [the specified candidate]; otherwise, <c>false</c>.
        /// </returns>
        bool IsSatisfiedBy(T1 candidate1, T2 candidate2, T3 candidate3);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T1">The type of the 1.</typeparam>
    /// <typeparam name="T2">The type of the 2.</typeparam>
    /// <typeparam name="T3">The type of the 3.</typeparam>
    /// <typeparam name="T4">The type of the 4.</typeparam>
    public interface ISpecification<in T1, in T2, in T3, in T4>
    {
        /// <summary>
        /// Determines whether [is satisfied by] [the specified candidate].
        /// </summary>
        /// <param name="candidate1">The candidate1.</param>
        /// <param name="candidate2">The candidate2.</param>
        /// <param name="candidate3">The candidate3.</param>
        /// <param name="candidate4">The candidate4.</param>
        /// <returns>
        ///   <c>true</c> if [is satisfied by] [the specified candidate]; otherwise, <c>false</c>.
        /// </returns>
        bool IsSatisfiedBy(T1 candidate1, T2 candidate2, T3 candidate3, T4 candidate4);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T1">The type of the 1.</typeparam>
    /// <typeparam name="T2">The type of the 2.</typeparam>
    /// <typeparam name="T3">The type of the 3.</typeparam>
    /// <typeparam name="T4">The type of the 4.</typeparam>
    /// <typeparam name="T5">The type of the 5.</typeparam>
    public interface ISpecification<in T1, in T2, in T3, in T4, in T5>
    {
        /// <summary>
        /// Determines whether [is satisfied by] [the specified candidate].
        /// </summary>
        /// <param name="candidate1">The candidate1.</param>
        /// <param name="candidate2">The candidate2.</param>
        /// <param name="candidate3">The candidate3.</param>
        /// <param name="candidate4">The candidate4.</param>
        /// <param name="candidate5">The candidate5.</param>
        /// <returns>
        ///   <c>true</c> if [is satisfied by] [the specified candidate]; otherwise, <c>false</c>.
        /// </returns>
        bool IsSatisfiedBy(T1 candidate1, T2 candidate2, T3 candidate3, T4 candidate4, T5 candidate5);
    }
}