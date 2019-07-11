using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPExam
{
    public class HomeComputer : Computer
    {
        private List<IComponent> components = new List<IComponent> { new HDD { Cost = 1000 }, new Motherboard { Cost = 1000 }, new Videocard { Cost = 3000 }, new Audiocard { Cost = 1000 } };

        public List<IComponent> GetComponents()
        {
            return components;
        }
    }
}
