using System;

namespace Bteam.Specifications
{
    public interface ISpecificationApplicator
    {
        /// <summary>
        /// Determines whether [is rule satisfied] [the specified candidate].
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <param name="candidate">The candidate.</param>
        /// <returns>
        /// 	<c>true</c> if [is rule satisfied] [the specified candidate]; otherwise, <c>false</c>.
        /// </returns>
        bool IsSatisfied<T, TEntity>(TEntity candidate) where T : class, ISpecification<TEntity>, new();

        /// <summary>
        /// Determines whether [is rule satisfied] [the specified candidate1].
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TEntity1">The type of the entity1.</typeparam>
        /// <typeparam name="TEntity2">The type of the entity2.</typeparam>
        /// <param name="candidate1">The candidate1.</param>
        /// <param name="candidate2">The candidate2.</param>
        /// <returns>
        /// 	<c>true</c> if [is rule satisfied] [the specified candidate1]; otherwise, <c>false</c>.
        /// </returns>
        bool IsSatisfied<T, TEntity1, TEntity2>(TEntity1 candidate1, TEntity2 candidate2) where T : class, ISpecification<TEntity1,TEntity2>, new();

        /// <summary>
        /// Does if satisfied.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <param name="candidate">The candidate.</param>
        /// <param name="action">The action.</param>
        void DoIfSatisfied<T, TEntity>(TEntity candidate, Action<TEntity> action) where T : class, ISpecification<TEntity>, new();

        /// <summary>
        /// Does if satisfied.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TEntity1">The type of the entity1.</typeparam>
        /// <typeparam name="TEntity2">The type of the entity2.</typeparam>
        /// <param name="candidate1">The candidate1.</param>
        /// <param name="candidate2">The candidate2.</param>
        /// <param name="action">The action.</param>
        void DoIfSatisfied<T, TEntity1, TEntity2>(TEntity1 candidate1, TEntity2 candidate2, Action<TEntity1, TEntity2> action)
            where T : class, ISpecification<TEntity1, TEntity2>, new();

        /// <summary>
        /// Determines whether the specified candidate1 is satisfied.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TEntity1">The type of the entity1.</typeparam>
        /// <typeparam name="TEntity2">The type of the entity2.</typeparam>
        /// <typeparam name="TEntity3">The type of the entity3.</typeparam>
        /// <param name="candidate1">The candidate1.</param>
        /// <param name="candidate2">The candidate2.</param>
        /// <param name="candidate3">The candidate3.</param>
        /// <returns>
        ///   <c>true</c> if the specified candidate1 is satisfied; otherwise, <c>false</c>.
        /// </returns>
        bool IsSatisfied<T, TEntity1, TEntity2, TEntity3>(TEntity1 candidate1, TEntity2 candidate2, TEntity3 candidate3)
            where T : class, ISpecification<TEntity1, TEntity2, TEntity3>, new();

        /// <summary>
        /// Determines whether the specified candidate1 is satisfied.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TEntity1">The type of the entity1.</typeparam>
        /// <typeparam name="TEntity2">The type of the entity2.</typeparam>
        /// <typeparam name="TEntity3">The type of the entity3.</typeparam>
        /// <typeparam name="TEntity4">The type of the entity4.</typeparam>
        /// <param name="candidate1">The candidate1.</param>
        /// <param name="candidate2">The candidate2.</param>
        /// <param name="candidate3">The candidate3.</param>
        /// <param name="candidate4">The candidate4.</param>
        /// <returns>
        ///   <c>true</c> if the specified candidate1 is satisfied; otherwise, <c>false</c>.
        /// </returns>
        bool IsSatisfied<T, TEntity1, TEntity2, TEntity3, TEntity4>(TEntity1 candidate1, TEntity2 candidate2, TEntity3 candidate3, TEntity4 candidate4)
            where T : class, ISpecification<TEntity1, TEntity2, TEntity3, TEntity4>, new();

        /// <summary>
        /// Determines whether the specified candidate1 is satisfied.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TEntity1">The type of the entity1.</typeparam>
        /// <typeparam name="TEntity2">The type of the entity2.</typeparam>
        /// <typeparam name="TEntity3">The type of the entity3.</typeparam>
        /// <typeparam name="TEntity4">The type of the entity4.</typeparam>
        /// <typeparam name="TEntity5">The type of the entity5.</typeparam>
        /// <param name="candidate1">The candidate1.</param>
        /// <param name="candidate2">The candidate2.</param>
        /// <param name="candidate3">The candidate3.</param>
        /// <param name="candidate4">The candidate4.</param>
        /// <param name="candidate5">The candidate5.</param>
        /// <returns>
        ///   <c>true</c> if the specified candidate1 is satisfied; otherwise, <c>false</c>.
        /// </returns>
        bool IsSatisfied<T, TEntity1, TEntity2, TEntity3, TEntity4, TEntity5>(TEntity1 candidate1, TEntity2 candidate2, TEntity3 candidate3, TEntity4 candidate4, TEntity5 candidate5)
            where T : class, ISpecification<TEntity1, TEntity2, TEntity3, TEntity4, TEntity5>, new();

        /// <summary>
        /// Does if satisfied.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TEntity1">The type of the entity1.</typeparam>
        /// <typeparam name="TEntity2">The type of the entity2.</typeparam>
        /// <typeparam name="TEntity3">The type of the entity3.</typeparam>
        /// <param name="candidate1">The candidate1.</param>
        /// <param name="candidate2">The candidate2.</param>
        /// <param name="candidate3">The candidate3.</param>
        /// <param name="action">The action.</param>
        void DoIfSatisfied<T, TEntity1, TEntity2, TEntity3>(TEntity1 candidate1, TEntity2 candidate2, TEntity3 candidate3, Action<TEntity1, TEntity2, TEntity3> action)
            where T : class, ISpecification<TEntity1, TEntity2, TEntity3>, new();

        /// <summary>
        /// Does if satisfied.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TEntity1">The type of the entity1.</typeparam>
        /// <typeparam name="TEntity2">The type of the entity2.</typeparam>
        /// <typeparam name="TEntity3">The type of the entity3.</typeparam>
        /// <typeparam name="TEntity4">The type of the entity4.</typeparam>
        /// <param name="candidate1">The candidate1.</param>
        /// <param name="candidate2">The candidate2.</param>
        /// <param name="candidate3">The candidate3.</param>
        /// <param name="candidate4">The candidate4.</param>
        /// <param name="action">The action.</param>
        void DoIfSatisfied<T, TEntity1, TEntity2, TEntity3, TEntity4>(TEntity1 candidate1, TEntity2 candidate2, TEntity3 candidate3, TEntity4 candidate4, Action<TEntity1, TEntity2, TEntity3, TEntity4> action)
            where T : class, ISpecification<TEntity1, TEntity2, TEntity3, TEntity4>, new();

        void DoIfSatisfied<T, TEntity1, TEntity2, TEntity3, TEntity4, TEntity5>(TEntity1 candidate1, TEntity2 candidate2, TEntity3 candidate3, TEntity4 candidate4, TEntity5 candidate5, Action<TEntity1, TEntity2, TEntity3, TEntity4, TEntity5> action)
            where T : class, ISpecification<TEntity1, TEntity2, TEntity3, TEntity4, TEntity5>, new();
    }
}