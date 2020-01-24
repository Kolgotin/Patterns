using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Patterns
{
    class PatternsModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Reference { get; set; }
        public string Example { get; set; }
        public string ImageSource { get; set; }
        public object Diagram { get; set; }
    }
}
