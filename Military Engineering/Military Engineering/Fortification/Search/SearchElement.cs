using CalculationsCore;
using MilitaryEngineering.Fortification.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryEngineering.Fortification.Search
{
    internal class SearchElement
    {
        public ISearchable Searchable { get; set; }
        public IHideable Hideable { get; set; }
        public SearchElement(ISearchable searchable, IHideable hideable)
        {
            Searchable = searchable;
            Hideable = hideable;
        }
    }
}
