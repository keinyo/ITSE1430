/*
 * Jacob Lanham
 * ITSE 1430
 * 10-29-2017
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
        public Movie Add( Movie movie )
        {
            if (movie == null)
                return null;

            //Validate using IValidatable Object
            if (!ObjectValidator.TryValidate(movie, out var errors))
                return null;

            return AddCore(movie);
        }

        /// <summary>Get a specfic moive.</summary>
        /// <param name="id">The movies Id.</param>
        /// <returns>The movie, if it exsists.</returns>
        public Movie Get( int id )
        {
            if (id <= 0)
                return null;

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
        public void Remove( int id )
        {
            if (id <= 0)
                return;

            RemoveCore(id);
        }

        /// <summary>Updates the movie.</summary>
        /// <param name="movie">The movie to update</param>
        /// <returns>The updated movie</returns>
        public Movie Update( Movie movie )
        {
            if (movie == null)
                return null;

            //Validate using IValidatable Object
            if (!ObjectValidator.TryValidate(movie, out var errors))
                return null;

            var existing = GetCore(movie.Id);
            if (existing == null)
                return null;

            return UpdateCore(existing, movie);



        }

        protected abstract Movie GetCore( int id );
        protected abstract IEnumerable<Movie> GetAllCore();
        protected abstract void RemoveCore( int id );
        protected abstract Movie UpdateCore( Movie existing, Movie movie );
        protected abstract Movie AddCore( Movie movie );
    }
}
