using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2Homework
{
    public class TestCase
    {
        public int N { get; set; }
        public double B { get; set; }

        public Type T { get; set; }
        public string Expected { get; set; }
        public Exception ExpectedException { get; set; }
    }
}
