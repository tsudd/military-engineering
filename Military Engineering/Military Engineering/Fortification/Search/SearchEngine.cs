using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryEngineering.Fortification.Search
{
    internal class SearchEngine
    {
        public List<SearchElement> SearchElements;
        public SearchEngine(List<SearchElement> searchElements)
        {
            SearchElements = searchElements;
        }

        public void Search(string search)
        {
            IEnumerable<string> searchSplitted = search.ToUpper().Split().Where(s => !string.IsNullOrWhiteSpace(s));
            foreach(SearchElement searchElement in SearchElements)
            {
                IEnumerable<string> features = searchElement.Searchable.GetFeatures();
                

                if(Predict(searchSplitted, features))
                {
                    searchElement.Hideable.Show();
                }
                else
                {
                    searchElement.Hideable.Hide();
                }
            }
        }

        public void Restore()
        {

        }

        private bool Predict(IEnumerable<string> search, IEnumerable<string> features)
        {
            if (!search.Any())
            {
                return true;
            }

            List<string> searchList = search.ToList();
            List<string> featuresList = features.ToList();

            int matches = 0;
            for(int i = 0; i < searchList.Count; i++)
            {
                for(int j = 0; j < featuresList.Count; j++)
                {
                    if (featuresList[j].ToUpper().Contains(searchList[i]))
                    {
                        matches++;
                        break;
                    }
                }
            }

            return matches == searchList.Count;
        }
    }
}
