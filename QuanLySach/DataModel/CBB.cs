using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach.DataModel
{
    class CBB
    {
        public int? Value { get; set; }
        public String Text { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
