namespace AssemblyBrowserLibrary.AssemblyComposition
{
    public class TypeInfo
    {
        public string TypeName { get; set; }
        public string TypeDesc { get; set; }
        public List<FieldInfo> Fields { get; set; }
        public List<PropertyInfo> Properties { get; set; }
        public List<MethodInfo> Methods { get; set; }

        public TypeInfo(string typeName, string type, List<FieldInfo> fields, List<PropertyInfo> properties, List<MethodInfo> methods)
        {
            TypeName = typeName;
            TypeDesc = type;
            Fields = fields;
            Properties = properties;
            Methods = methods;
        }

        public TypeInfo()
        {
        }
    }
}
