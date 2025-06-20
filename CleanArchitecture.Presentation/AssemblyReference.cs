using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Presentation
{
    public class AssemblyReference
    {
        public static readonly Assembly Assembly= typeof(Assembly).Assembly;    // Presentation katmanının dll haline erişebilceğiz
    }
}
