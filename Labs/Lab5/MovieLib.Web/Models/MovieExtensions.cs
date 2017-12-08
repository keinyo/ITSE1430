/*
 * Jacob Lanham
 * ITSE 1430
 * 12-08-2017
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieLib.Web.Models
{
    /// <summary>Provides extensions for <see cref="Movie"/></summary>
    public static class MovieExtensions
    {
        /// <summary>Converts a <see cref="Movie"/> to a <see cref="MovieViewModel"/>.</summary>
        /// <param name="source">The movie.</param>
        /// <returns>The model.</returns>
        public static IEnumerable<MovieViewModel> ToModel (this IEnumerable<Movie> source)
        {
            foreach (var item in source)
                yield return item.ToModel();
        }

        /// <summary>Converts a <see cref="Movie"/> to a <see cref="MovieViewModel"/>.</summary>
        /// <param name="source">The movie.</param>
        /// <returns>The model.</returns>
        public static MovieViewModel ToModel (this Movie source)
        {
            return new MovieViewModel() 
            {
                Id = source.Id,
                Title = source.Title,
                Description = source.Description,
                Owned = source.Owned,
                Length = source.Length,
            };
        }
        /// <summary>Converts a <see cref="MovieViewModel"/> to a <see cref="Movie"/>.</summary>
        /// <param name="source">The model.</param>
        /// <returns>The movie.</returns>
        public static Movie ToDomain (this MovieViewModel source)
        {
            return new Movie() {
                Id = source.Id,
                Title = source.Title,
                Description = source.Description,
                Owned = source.Owned,
                Length = source.Length,
            };
        }
    }
}