using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Patterns
{
    class KindsModel
    {
        public string KindName { get; set; }
        public ObservableCollection<PatternsModel> PatternsTree { get; set; }
    }
}
