using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPExam
{
    public class HDD : IComponent
    {
        public int Cost { get; set; }

        public string GetName()
        {
            return "HDD";
        }
    }
}
