/*
 * Jacob Lanham
 * ITSE 1430
 * 11-21-2017
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieLib.Data.Memory;

namespace MovieLib.Data.Sql
{
    /// <summary>Provides SQL database implementation</summary>
    public class SqlMovieDatabase : MovieDatabase
    {
        public SqlMovieDatabase(string connString)
        {
            _connectionString = connString;
        }
        protected override Movie AddCore( Movie movie )
        {
            var id = 0;
            using (var conn = OpenDatabase())
            {
                var cmd = new SqlCommand("AddMovie", conn) { CommandType = CommandType.StoredProcedure };

                cmd.Parameters.AddWithValue("@Title", movie.Title);
                cmd.Parameters.AddWithValue("@length", movie.Length);
                cmd.Parameters.AddWithValue("@isOwned", movie.Owned);
                cmd.Parameters.AddWithValue("@description", movie.Description);
            };

            return GetCore(id);
        }
        /// <summary>Gets all movies.</summary>
        /// <returns>All movies</returns>
        protected override IEnumerable<Movie> GetAllCore()
        {
            var movies = new List<Movie>();
            using (var connection = OpenDatabase())
            {
                var cmd = new SqlCommand("GetAllMovies", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                using (var reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        var movie = new Movie() {
                            Id = reader.IsDBNull(0) ? 0 : reader.GetFieldValue<int>(0),
                            Title = reader.GetFieldValue<string>(1),
                            Length = reader.GetFieldValue<int>(2),
                            Owned = reader.GetFieldValue<bool>(3),
                            Description = reader.IsDBNull(4) ? "" : reader.GetFieldValue<string>(4),
                        };
                        movies.Add(movie);
                    };
                };
                return movies;
            }
            
        }
        /// <summary>Gets movie by id.</summary>
        /// <param name="id">Movie to return</param>
        /// <returns>Movie with id given.</returns>
        protected override Movie GetCore( int id )
        {
            var movie = new Movie();
            using (var conn = OpenDatabase())
            {
                var cmd = new SqlCommand("GetMovie", conn) { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("@id", id);

                using (var reader = cmd.ExecuteReader())
                {
                    movie = new Movie() {
                        Id = reader.IsDBNull(0) ? 0 : reader.GetFieldValue<int>(0),
                        Title = reader.GetFieldValue<string>(1),
                        Length = reader.GetFieldValue<int>(2),
                        Owned = reader.GetFieldValue<bool>(3),
                        Description = reader.IsDBNull(4) ? "" : reader.GetFieldValue<string>(4),
                    };
                };
                return movie;
            };
        }
        /// <summary>Removes movie by id.</summary>
        /// <param name="id">The movie to remove.</param>
        protected override void RemoveCore( int id )
        {
            using (var conn = OpenDatabase())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "RemoveMovie";
                cmd.CommandType = CommandType.StoredProcedure;

                var parameter = new SqlParameter("@id", id);
                cmd.Parameters.Add(parameter);

                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>Updates the movies </summary>
        /// <param name="existing">Existing movie object</param>
        /// <param name="movie">new movie object</param>
        /// <returns>New movie id.</returns>
        protected override Movie UpdateCore( Movie existing, Movie movie )
        {
            using (var conn = OpenDatabase())
            {
                var cmd = new SqlCommand("UpdateMovie", conn) { CommandType = CommandType.StoredProcedure };

                cmd.Parameters.AddWithValue("@Id", existing.Id);
                cmd.Parameters.AddWithValue("@Title", movie.Title);
                cmd.Parameters.AddWithValue("@Length", movie.Length);
                cmd.Parameters.AddWithValue("@Owned", movie.Owned);
                cmd.Parameters.AddWithValue("@Description", movie.Description); 

                cmd.ExecuteNonQuery();
            };

            return GetCore(existing.Id);
        }

        private SqlConnection OpenDatabase()
        {
            var connection = new SqlConnection(_connectionString);

            connection.Open();

            return connection;
        }

        private readonly string _connectionString;
    }
}
