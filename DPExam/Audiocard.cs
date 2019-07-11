using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPExam
{
    class Audiocard : IComponent
    {
        public int Cost { get; set; }

        public string GetName()
        {
            return "Audiocard";
        }
    }
}
