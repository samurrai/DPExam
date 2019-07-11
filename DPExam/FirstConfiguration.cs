using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPExam
{
    public class FirstConfiguration : IConfiguration
    {
        public string GetConfiguration(List<IComponent> components)
        {
            string configuration = "";
            int cost = 0;
            foreach (var component in components)
            {
                configuration += component.GetName() + " ";
                cost += component.Cost;
            }
            return configuration + " - " + cost;
        }
    }
}
