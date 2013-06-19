namespace Bteam.Specifications.Factories
{
    public class SpecificationFactory : ISpecificationFactory
    {
        private readonly IFlyweightedFactory _flyweightedFactory;

        /// <summary>
        /// Initializes a new instance of the <see cref="SpecificationFactory"/> class.
        /// </summary>
        /// <param name="flyweightedFactory">The flyweighted factory.</param>
        public SpecificationFactory(IFlyweightedFactory flyweightedFactory)
        {
            _flyweightedFactory = flyweightedFactory;
        }

        /// <summary>
        /// Gets the specification.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <returns></returns>
        public T GetSpecification<T, TEntity>() where T : class, ISpecification<TEntity>, new()
        {
            return _flyweightedFactory.GetInstance<T>();
        }

        /// <summary>
        /// Gets the specification.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TEntity1">The type of the entity1.</typeparam>
        /// <typeparam name="TEntity2">The type of the entity2.</typeparam>
        /// <returns></returns>
        public T GetSpecification<T, TEntity1, TEntity2>() 
            where T : class, ISpecification<TEntity1, TEntity2>, new()
        {
            return _flyweightedFactory.GetInstance<T>();
        }

        /// <summary>
        /// Gets the specification.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TEntity1">The type of the entity1.</typeparam>
        /// <typeparam name="TEntity2">The type of the entity2.</typeparam>
        /// <typeparam name="TEntity3">The type of the entity3.</typeparam>
        /// <returns></returns>
        public T GetSpecification<T, TEntity1, TEntity2, TEntity3>() 
            where T : class, ISpecification<TEntity1, TEntity2, TEntity3>, new()
        {
            return _flyweightedFactory.GetInstance<T>();
        }

        /// <summary>
        /// Gets the specification.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TEntity1">The type of the entity1.</typeparam>
        /// <typeparam name="TEntity2">The type of the entity2.</typeparam>
        /// <typeparam name="TEntity3">The type of the entity3.</typeparam>
        /// <typeparam name="TEntity4">The type of the entity4.</typeparam>
        /// <returns></returns>
        public T GetSpecification<T, TEntity1, TEntity2, TEntity3, TEntity4>()
            where T : class, ISpecification<TEntity1, TEntity2, TEntity3, TEntity4>, new()
        {
            return _flyweightedFactory.GetInstance<T>();
        }

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
        public T GetSpecification<T, TEntity1, TEntity2, TEntity3, TEntity4, TEntity5>()
            where T : class, ISpecification<TEntity1, TEntity2, TEntity3, TEntity4, TEntity5>, new()
        {
            return _flyweightedFactory.GetInstance<T>();
        }
    }
}