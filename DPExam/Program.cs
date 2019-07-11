using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPExam
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IComponent> components = new List<IComponent>();
            components.Add(new HDD {
                Cost = 1000
            });
            components.Add(new Motherboard {
                Cost = 2000
            });
            components.Add(new Videocard {
                Cost = 3000
            });
            components.Add(new Audiocard {
                Cost = 500
            });
            components.Add(new Videocard {
                Cost = 10000
            });
            components.Add(new Motherboard {
                Cost = 5000
            });
            Console.WriteLine("Список доступных компонентов:");
            foreach (var component in components)
            {
                Console.WriteLine(component.GetName() + " - " + component.Cost);
            }
            Console.ReadLine();
        }
    }
}
