using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace githubConnect
{
    class languages
    {
        public languages(string t, int l)
        {
            type = t;
            lines = l;
        }
        public string type { get; private set; }
        public int lines { get; private set; }
    }
}
