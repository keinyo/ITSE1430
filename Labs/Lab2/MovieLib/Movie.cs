/*
 * Jacob Lanham
 * ITSE 1430
 * 10-05-2017
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLib
{
    /// <summary>Represents A moive</summary>
    public class Movie
    {

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

        /// <summary>Detirmines if owned or not</summary>
        public bool Owned { get; set; }

        /// <summary>Validates the Movie object</summary>
        /// <returns>The error message or null</returns>
        public string Validate()
        {
            //Title can not be empty
            if (String.IsNullOrEmpty(Title))
            {
                return "Name cannot be empty";
            }

            //Length >= 0
            if (Length < 0)
                return "Length must be >=0";

            return null;
        }

        private string _title;
        private string _description;

    }
}
