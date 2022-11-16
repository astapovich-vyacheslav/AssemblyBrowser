using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfLibrary;

namespace AssemblyBrowser.Model
{
    public static class Core
    {
        public static AssemblyInfo GetTree(string filename)
        {
            WpfLibrary.AssemblyBrowser assemblyBrowser = new WpfLibrary.AssemblyBrowser(filename);
            return assemblyBrowser.GetAssemblyInfo();
        }
    }
}
