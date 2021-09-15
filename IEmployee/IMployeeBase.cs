using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEmployee_LP
{
    public class IMployeeBase : IEmployee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public virtual decimal Salary { get; set; }
    }
}
