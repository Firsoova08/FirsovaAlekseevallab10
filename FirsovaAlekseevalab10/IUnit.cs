using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirsovaAlekseevalab10
{
    public interface IUnit
    {
     string Name { get; }
     int Health { get; }
     void Attack(IUnit target);
    }
}
