using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfLibrary
{
    public class AssemblyInfo
    {
        public string AssemblyName { get; set; }
        public List<NamespaceInfo> Namespaces { get; set; }

        public AssemblyInfo(string assemblyName, List<NamespaceInfo> namespaces)
        {
            AssemblyName = assemblyName;
            Namespaces = namespaces;
        }

        public AssemblyInfo()
        {
        }
    }
}
