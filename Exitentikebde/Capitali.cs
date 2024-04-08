using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticInterface2.Exitentikebde
{
    static class Capitali
    {
       public static string Capitalize(this string name)
        { return name.Substring(0, 1).ToUpper() + name.Substring(1).ToLower(); }
    }
}
