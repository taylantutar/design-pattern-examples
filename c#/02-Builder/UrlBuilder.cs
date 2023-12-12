using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using Microsoft.VisualBasic;

namespace _02_Builder
{
    public class UrlBuilder
    {
        public Url myUrl;

        public UrlBuilder(string BaseUrl)
        {
            myUrl = new Url
            {
                BaseUrl = BaseUrl
            };
        }

        public UrlBuilder AddParameters(string param)
        {
            myUrl.Parameters.Add(param);
            return this;
        }

        public UrlBuilder AddQueryParam(string key, string value)
        {
            myUrl.QueryParams[key] = value;
            return this;
        }

        public string Build()
        {
            StringBuilder s = new StringBuilder();

            if (myUrl.Parameters.Any())
            {
                s.Append(myUrl.BaseUrl);
                s.Append("/");
                s.AppendJoin('/', myUrl.Parameters);
            }

            if (myUrl.QueryParams.Count > 0)
            {
                s.Append("?");
                foreach (var q in myUrl.QueryParams)
                {
                    s.Append($"{q.Key}={q.Value}&");
                }
            }

            var res = s.ToString();
            if (res.Last() == '&')
            {
                res = res.Substring(0, res.Length - 1);
            }

            return res;
        }
    }
}