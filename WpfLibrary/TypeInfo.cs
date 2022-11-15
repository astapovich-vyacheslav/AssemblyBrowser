using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfLibrary
{
    public class TypeInfo
    {
        public string TypeName { get; set; }
        public string Type { get; set; }
        public List<FieldInfo> Fields { get; set; }
        public List<PropInfo> Properties { get; set; }
        public List<MethodInfo> Methods { get; set; }

        public TypeInfo(string typeName, string type, List<FieldInfo> fields, List<PropInfo> properties, List<MethodInfo> methods)
        {
            TypeName = typeName;
            Type = type;
            Fields = fields;
            Properties = properties;
            Methods = methods;
        }

        public TypeInfo()
        {
        }
    }
}
