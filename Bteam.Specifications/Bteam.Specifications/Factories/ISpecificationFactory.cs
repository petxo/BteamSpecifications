namespace Bteam.Specifications.Factories
{
    public interface ISpecificationFactory
    {
        /// <summary>
        /// Gets the specification.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <returns></returns>
        T GetSpecification<T, TEntity>() where T : class, ISpecification<TEntity>, new();

        /// <summary>
        /// Gets the specification.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TEntity1">The type of the entity1.</typeparam>
        /// <typeparam name="TEntity2">The type of the entity2.</typeparam>
        /// <returns></returns>
        T GetSpecification<T, TEntity1, TEntity2>() where T : class, ISpecification<TEntity1, TEntity2>, new();

        /// <summary>
        /// Gets the specification.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TEntity1">The type of the entity1.</typeparam>
        /// <typeparam name="TEntity2">The type of the entity2.</typeparam>
        /// <typeparam name="TEntity3">The type of the entity3.</typeparam>
        /// <returns></returns>
        T GetSpecification<T, TEntity1, TEntity2, TEntity3>() 
            where T : class, ISpecification<TEntity1, TEntity2, TEntity3>, new();

        /// <summary>
        /// Gets the specification.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TEntity1">The type of the entity1.</typeparam>
        /// <typeparam name="TEntity2">The type of the entity2.</typeparam>
        /// <typeparam name="TEntity3">The type of the entity3.</typeparam>
        /// <typeparam name="TEntity4">The type of the entity4.</typeparam>
        /// <returns></returns>
        T GetSpecification<T, TEntity1, TEntity2, TEntity3, TEntity4>()
            where T : class, ISpecification<TEntity1, TEntity2, TEntity3, TEntity4>, new();

        /// <summary>
        /// Gets the specification.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TEntity1">The type of the entity1.</typeparam>
        /// <typeparam name="TEntity2">The type of the entity2.</typeparam>
        /// <typeparam name="TEntity3">The type of the entity3.</typeparam>
        /// <typeparam name="TEntity4">The type of the entity4.</typeparam>
        /// <typeparam name="TEntity5">The type of the entity5.</typeparam>
        /// <returns></returns>
        T GetSpecification<T, TEntity1, TEntity2, TEntity3, TEntity4, TEntity5>()
            where T : class, ISpecification<TEntity1, TEntity2, TEntity3, TEntity4, TEntity5>, new();
    }
}