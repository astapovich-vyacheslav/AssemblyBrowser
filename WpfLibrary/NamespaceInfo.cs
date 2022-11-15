using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfLibrary
{
    public class NamespaceInfo
    {
        public string NamespaceName { get; set; }
        public List<TypeInfo> Types { get; set; }

        public NamespaceInfo(string namespaceName, List<TypeInfo> types)
        {
            NamespaceName = namespaceName;
            Types = types;
        }

        public NamespaceInfo()
        {
        }
    }
}
