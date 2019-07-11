using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPExam
{
    public class ProComputer : Computer
    {
        private List<IComponent> components = new List<IComponent> { new HDD { Cost = 5000 }, new Motherboard { Cost = 10000 }, new Videocard { Cost = 50000 }, new Audiocard { Cost = 30000 }};

        public List<IComponent> GetComponents()
        {
            return components;
        }
    }
}
