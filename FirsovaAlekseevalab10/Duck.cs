using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirsovaAlekseevalab10
{
    public class Duck : IFlier, ISwimmer
    {
     public void Fly() =>Console.WriteLine("Утка летит!");
     public void Swim()=> Console.WriteLine("Утка плывёт!");
    }
}
