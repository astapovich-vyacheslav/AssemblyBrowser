using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfLibrary
{
    public class MethodInfo
    {
        public string MethodName { get; set; }
        public string ReturnType { get; set; }
        public List<FieldInfo> Parameters { get; set; }

        public MethodInfo(string methodName, string returnType, List<FieldInfo> parameters)
        {
            MethodName = methodName;
            ReturnType = returnType;
            Parameters = parameters;
        }

        public MethodInfo()
        {
        }
    }
}
