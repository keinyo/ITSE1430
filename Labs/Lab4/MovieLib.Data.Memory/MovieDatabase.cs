/*
 * Jacob Lanham
 * ITSE 1430
 * 11-21-2017
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLib.Data.Memory
{
    public abstract class MovieDatabase : IMovieDatabase
    {
        /// <summary>Adds a movie.</summary>
        /// <param name="movie">The movie to add.</param>
        /// <returns>The added movie.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="movie"/>is null</exception>
        public Movie Add( Movie movie )
        {
            if (movie == null)
                throw new ArgumentNullException(nameof(movie), "Movie was null");

            ObjectValidator.Validate(movie);

            try
            {
                return AddCore(movie);
            }
            catch
            {
                throw;
            }
        }

        /// <summary>Get a specfic moive.</summary>
        /// <param name="id">The movies Id.</param>
        /// <returns>The movie, if it exsists.</returns>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="id"/>is invalid</exception>
        public Movie Get( int id )
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be >0");

            return GetCore(id);
        }

        /// <summary>Gets all the movies.</summary>
        /// <returns>The movies.</returns>
        public IEnumerable<Movie> GetAll()
        {
            return GetAllCore();
        }

        /// <summary>Removes the movie.</summary>
        /// <param name="id">The movie to remove.</param>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="id"/>is invalid</exception>
        public void Remove( int id )
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be > 0");

            RemoveCore(id);
        }

        /// <summary>Updates the movie.</summary>
        /// <param name="movie">The movie to update</param>
        /// <returns>The updated movie</returns>
        /// <exception cref="ArgumentNullException"><paramref name="movie"/>is null</exception>
        public Movie Update( Movie movie )
        {
            if (movie == null)
                throw new ArgumentNullException(nameof(movie));

            //Validate using IValidatable Object
            ObjectValidator.Validate(movie);

            var existing = GetCore(movie.Id);

            return UpdateCore(existing, movie);
        }

        protected abstract Movie GetCore( int id );
        protected abstract IEnumerable<Movie> GetAllCore();
        protected abstract void RemoveCore( int id );
        protected abstract Movie UpdateCore( Movie existing, Movie movie );
        protected abstract Movie AddCore( Movie movie );
    }
}
