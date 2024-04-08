using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticInterface2.Interface
{
     interface ICodeAcademy
    {
        string CodeEmail { get; set; }
        void GenerateEmail();
    }
}
