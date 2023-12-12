using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _02_Builder
{
    public class Url
    {
        public Url()
        {
            QueryParams = new Dictionary<string, string>();
            Parameters = new List<string>();
        }

        public string BaseUrl { get; set; }
        public Dictionary<string, string> QueryParams { get; set; }
        public List<string> Parameters { get; set; }
    }
}