using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Students
    {
        public string name;
        public string surname;
        public int age;
        public string speciality;
        public int groupNo;

        public override string ToString()
        {
            return $"{name} {surname} {age} {speciality} {groupNo}";
        }
    }
}
