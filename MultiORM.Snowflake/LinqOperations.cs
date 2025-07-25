using MultiORM.Snowflake.Validation;
using System.Linq.Expressions;

namespace MultiORM
{
    /// <summary>
    ///     Contains Expression-enabled extension methods for interacting with Snowflake.
    /// </summary>
    public static class LinqOperations
    {
        /// <summary>
        ///     Performs a equality comparison against the specified collection property.
        /// </summary>
        /// <typeparam name="T">The type parameter.</typeparam>
        /// <param name="obj">The object parameter.</param>
        /// <param name="exp">The <see cref="Expression"/> parameter.</param>
        /// <returns><see cref="{T}"/></returns>
        public static T MWhere<T>(this T obj, Expression<Func<int, bool>> exp)
        {
            if (PropertyValidators.ValidateArgument(exp))
            {
                var compiled = exp.Compile();
            }
            
            return Activator.CreateInstance<T>();
        }

    }
}
