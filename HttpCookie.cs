using System;
using System.Collections.Generic;

namespace MyCSharpIntermediate
{
    partial class Program
    {
        public class HttpCookie 
        {
            private readonly Dictionary<string, string> _dictionary;
            public DateTime Expiry { get; set; } //remember to add using system on top;

            //if not using the constructor below, you can add it here:
            //private Dictionary<string, string> _dictionary = new Dictionary<string, string>();

            //initialize in a constructor:
            public HttpCookie()
            {
                _dictionary = new Dictionary<string, string>();
            }

            public string this[string key]
            {
                get { return _dictionary[key]; }
                set { _dictionary[key] = value; }
            }
        }
    }
}
