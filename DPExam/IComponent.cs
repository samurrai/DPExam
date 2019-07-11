using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPExam
{
    public interface IComponent
    {
        int Cost { get; set; }
        string GetName();
    }
}
