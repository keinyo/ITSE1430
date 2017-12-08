/*
 * Jacob Lanham
 * ITSE 1430
 * 12-08-2017
 */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieLib.Web.Models
{
    public class MovieViewModel
    {
        /// <summary>Gets or sets the ID</summary>
        public int Id { get; set; }
        /// <summary>Gets or sets the Title</summary>
        [Required(AllowEmptyStrings = false)]
        public string Title { get; set; }
        /// <summary>Gets or sets the Description</summary>
        public string Description { get; set; }
        /// <summary>Gets or sets the Length</summary>
        [Range(0,Double.MaxValue, ErrorMessage = "Length not valid")]
        public int Length { get; set; }
        /// <summary>Determines if owned or not</summary>
        public bool Owned { get; set; }
    }
}