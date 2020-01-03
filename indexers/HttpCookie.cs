using System.Collections.Generic;

namespace indexers
{
    public class HttpCookie
    {
        // we are using a dictionary for the indexer, which will be using a hashtable to store data and look up
        // for index, use a list, for keys use dictionary
        private readonly Dictionary<string, string> _dictionary; // use readonly so we can't accidently re initialize the dictionary
        public DateTime Expiry { get; set; }
        public HttpCookie()
        {
            _dictionary = new Dictionary<string, string>();
        }

        // declaring our indexer
        public string this[string key]
        {
            get
            {
                return _dictionary[key];
            }
            set
            {
                _dictionary[key] = value;
            }
        }
    }
}
