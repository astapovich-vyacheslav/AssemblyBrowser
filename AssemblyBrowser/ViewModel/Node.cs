using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyBrowser.ViewModel
{
    public class Node
    {
        public string Header { get; set; }
        public List<Node> Nodes { get; set; } = new List<Node>();
    }
}
