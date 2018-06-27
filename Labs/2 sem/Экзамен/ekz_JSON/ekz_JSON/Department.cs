using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ekz_JSON
{
    [DataContract]
    public class Department
    {
        [DataMember]
        public Student student;

        [DataMember]
        public string _name;

        public Department()
        {
            this.student = new Student();
        }
    }
}
