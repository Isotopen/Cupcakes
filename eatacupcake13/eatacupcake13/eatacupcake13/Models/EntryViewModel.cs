using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eatacupcake13.Models
{
    public class EntryViewModel
    {
        /// <summary>
        /// Display the data sorted by Seasonal options
        /// </summary>

        private List<Entry> _entries;

        public EntryViewModel(List<Entry> entries)
        {
            _entries = entries;
        }

        public bool Seasonal { get; set; }

        public List<Entry> Cupcake
        {
            get
            {
                return _entries
                    .Where(entry => entry.Seasonal == false
                    || entry.Seasonal == true)
                    .ToList();
            }
        }
    }
}