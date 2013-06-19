using System;
using System.Collections.Concurrent;

namespace Bteam.Specifications.Factories
{
    /// <summary>
    /// Flyweighted Factory
    /// </summary>
    public class FlyweightedFactory : IFlyweightedFactory
    {
        private readonly ConcurrentDictionary<string, object> _flyweightedDictionary;

        /// <summary>
        /// Initializes a new instance of the <see cref="FlyweightedFactory"/> class.
        /// </summary>
        public FlyweightedFactory()
        {
            _flyweightedDictionary = new ConcurrentDictionary<string, object>();
        }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T GetInstance<T>() where T : class, new()
        {
            var typeOfSpec = typeof(T).FullName;
            if (String.IsNullOrEmpty(typeOfSpec))
                throw new ArgumentException(String.Format("Type {0} is null on FlyweightedDictionary", typeOfSpec));

            return (_flyweightedDictionary.GetOrAdd(typeOfSpec, new T()) as T);
        }

    }
}