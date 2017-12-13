/*
 * ITSE 1430
 * Sample implementation
 * Jacob Lanham
 * 12-13-2017
 */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieLib
{
    /// <summary>Represents a movie.</summary>
    public class Movie : IValidatableObject
    {
        /// <summary>Gets or sets the ID of the movie.</summary>
        public int Id { get; set; }

        /// <summary>Gets or sets the description.</summary>
        public string Description
        {
            get { return _description ?? ""; }
            set { _description = value; }
        }

        /// <summary>Determines if the movie is owned or not.</summary>
        public bool IsOwned { get; set; }

        /// <summary>Gets or sets the length, in minutes.</summary>
        public int Length { get; set; }

        /// <summary>Gets or sets the movie rating.</summary>
        public Rating Rating { get; set; }

        [Range(1900, 2100, ErrorMessage = "Year must be between 1900 and 2100")]
        public int ReleaseYear { get; set; }

        [StringLength(100,MinimumLength = 2, ErrorMessage = "Name must be between 2 and 100 characters long.")]
        /// <summary>Gets or sets the title.</summary>
        public string Title
        {
            get { return _title ?? ""; }
            set { _title = value; }
        }

        /// <summary>Validates the object.</summary>
        /// <param name="validationContext">The validation context.</param>
        /// <returns>The validation results.</returns>
        public IEnumerable<ValidationResult> Validate ( ValidationContext validationContext )
        {
            //Title is required
            if (Title.Length == 0)
                yield return new ValidationResult("Title is required.", new[] { "Title" });

            //Length must be >= 0.
            if (Length < 0)
                yield return new ValidationResult("Length must be >= 0.", new[] { "Length" });
        }

        #region Private Members

        private string _title, _description;        

        #endregion
    }
}
