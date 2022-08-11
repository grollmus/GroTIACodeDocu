using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Siemens.Engineering;

namespace DocuHelper
{
    public class TypeVersion : IEquatable<TypeVersion>
    {
        public string version { get; set; }
        public string date { get; set; }
        public string author { get; set; }
        public Guid guid { get; set; }
        public string comment { get; set; } 

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            TypeVersion objAsPart = obj as TypeVersion;
            if (objAsPart == null) return false;
            else return Equals(objAsPart);
        }

        public bool Equals(TypeVersion other)
        {
            return this.guid.Equals(other.guid);    
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
