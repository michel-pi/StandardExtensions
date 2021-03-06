﻿using System.Collections;

namespace NetStandardExtensions
{
    /// <summary>
    ///     Provides extension methods for the <c>ICollection</c> interface
    /// </summary>
    public static class CollectionExtensions
    {
        /// <summary>
        ///     Determines whether the collection is null or empty.
        /// </summary>
        /// <param name="collection">The collection.</param>
        /// <returns>
        ///     <c>true</c> if [is null or empty] [the specified collection]; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsNullOrEmpty(this ICollection collection)
        {
            if (collection == null) return true;

            return collection.Count == 0;
        }
    }
}