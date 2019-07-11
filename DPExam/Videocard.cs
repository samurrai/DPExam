using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPExam
{
    public class Videocard : IComponent
    {
        public int Cost { get; set; }

        public string GetName()
        {
            return "Videocard";
        }
    }
}
