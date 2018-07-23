using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace eatacupcake13.Models
{
    /// <summary>
    /// A cupcake on the menu.
    /// </summary>
    public class Entry
    {
        /// <summary>
        /// The Id number of the cupcake entry.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The name of the cupcake with a maxlength of 100 characters.
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        /// <summary>
        /// The date of the entry. Should not include a time portion.
        /// </summary>
        public DateTime DateAdded { get; set; }

        /// <summary>
        /// The season of the cupcake.
        /// </summary>
        public string SeasonType { get; set; }

        /// <summary>
        /// If the cupcake is seasonal or not
        /// </summary>
        public bool Seasonal { get; set; }

        /// <summary>
        /// A description of the cupcake entry.
        /// </summary>
        [MaxLength(500, ErrorMessage = "The Notes field cannot be longer than 500 characters.")]
        public string Notes { get; set; }
    }
}