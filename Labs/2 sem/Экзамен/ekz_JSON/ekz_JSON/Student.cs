using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ekz_JSON
{
    [DataContract]
    public class Student
    {
        [DataMember]
        public string _name;

        [DataMember]
        public string _group;

        [DataMember]
        public string _age;
    }
}
