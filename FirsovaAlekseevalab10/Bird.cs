using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirsovaAlekseevalab10
{
    internal class Bird : ISound
    {
        public void MakeSound()
        {
            Console.WriteLine("Чирик!");

        }
    }
}
