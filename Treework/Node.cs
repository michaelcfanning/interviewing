using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treework
{
    [ExcludeFromCodeCoverage()]
    public class Node
    {
        private List<Node> _children = new List<Node>();

        public string Data { get; set; }

        public IList<Node> Children => this._children;
    }
}
