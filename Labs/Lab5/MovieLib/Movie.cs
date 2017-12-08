/*
 * Jacob Lanham
 * ITSE 1430
 * 10-29-2017
 */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLib
{
    /// <summary>Represents A moive</summary>
    public class Movie : IValidatableObject
    {

        public int Id { get; set; }

        /// <summary>Gets or sets the title</summary>
        public string Title
        {
            get { return _title ?? ""; }
            set { _title = value?.Trim(); }
        }

        /// <summary>Gets or sets the description</summary>
        public string Description
        {
            get { return _description ?? ""; }
            set { _description = value?.Trim(); }
        }

        /// <summary>Gets or sets the length</summary>
        public int Length { get; set; }

        /// <summary>Determines if owned or not</summary>
        public bool Owned { get; set; }

        /// <summary>Validates the Movie object</summary>
        /// <returns>The error message or null</returns>

        public override string ToString()
        {
            return Title;
        }

        public IEnumerable<ValidationResult> Validate ( ValidationContext validationContext )
        {
            //Title cannot be empty
            if (String.IsNullOrEmpty(Title))
                yield return new ValidationResult("Name cannot be empty.", new[] { nameof(Title) });

            //Length >= 0
            if (Length < 0)
                yield return new ValidationResult("Length must be >= 0.", new[] { nameof(Length) });

        }

        public object Validate()
        {
            throw new NotImplementedException();
        }

        private string _title;
        private string _description;

    }
}
