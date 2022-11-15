using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfLibrary
{
    public class VarInfo
    {
        public string VarName { get; set; }
        public string VarType { get; set; }

        public VarInfo(string fieldName, string fieldType)
        {
            VarName = fieldName;
            VarType = fieldType;
        }

        public VarInfo()
        {
        }
    }
}
