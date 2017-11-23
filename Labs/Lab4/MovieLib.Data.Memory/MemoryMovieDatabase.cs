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
    public class MemoryMovieDatabase : MovieDatabase
    {
        /// <summary>Adds a movie.</summary>
        /// <param name="movie">The movie to add</param>
        /// <returns>The added product</returns>
        protected override Movie AddCore( Movie movie )
        {
            var newMovie = CopyMovie(movie);
            _movies.Add(newMovie);

            if (newMovie.Id <= 0)
                newMovie.Id = _nextId++;
            else if (newMovie.Id >= _nextId)
                _nextId = newMovie.Id + 1;

            return CopyMovie(newMovie);
        }

        /// <summary>Gets all movies.</summary>
        /// <returns>The movies</returns>
        protected override IEnumerable<Movie> GetAllCore()
        {
            foreach (var movie in _movies)
                yield return CopyMovie(movie);
        }

        /// <summary>Get a specific movie.</summary>
        /// <param name="id">The ID of the movie yu are looking for.</param>
        /// <returns>The movie, if it exists.</returns>
        protected override Movie GetCore( int id )
        {
            var movie = FindMovie(id);

            return (movie != null) ? CopyMovie(movie) : null;
        }

        /// <summary>Removes the movie.</summary>
        /// <param name="id">The ID of the movie to remove.</param>
        protected override void RemoveCore( int id )
        {
            var movie = FindMovie(id);
            if (movie != null)
                _movies.Remove(movie);
        }

        /// <summary>Updates a movie.</summary>
        /// <param name="existing">Existing movie.</param>
        /// <param name="movie">updated movie</param>
        /// <returns></returns>
        protected override Movie UpdateCore( Movie existing, Movie movie )
        {
            //Replace
            existing = FindMovie(movie.Id);
            _movies.Remove(existing);

            var newMovie = CopyMovie(movie);
            _movies.Add(newMovie);

            return CopyMovie(newMovie);
        }

        //Copies the movie into a new movie
        private Movie CopyMovie ( Movie movie)
        {
            if (movie == null)
                return null;

            var newMovie = new Movie();
            newMovie.Id = movie.Id;
            newMovie.Title = movie.Title;
            newMovie.Description = movie.Description;
            newMovie.Length = movie.Length;
            newMovie.Owned = movie.Owned;

            return newMovie;
        }

        //Finds a movie based on ID
        private Movie FindMovie( int id )
        {
            foreach(var movie in _movies)
            {
                if (movie.Id == id)
                    return movie;
            };

            return null;
        }

        private List<Movie> _movies = new List<Movie>();
        private int _nextId = 1;

    }
}
