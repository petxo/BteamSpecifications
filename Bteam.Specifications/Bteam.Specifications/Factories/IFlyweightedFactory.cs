namespace Bteam.Specifications.Factories
{
    /// <summary>
    /// Flyweighted Factory
    /// </summary>
    public interface IFlyweightedFactory
    {
        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        T GetInstance<T>() where T : class, new();
    }
}