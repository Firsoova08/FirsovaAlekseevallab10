using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirsovaAlekseevalab10
{
    class Student : Person
    {
        public string? University { get; set; }
        public override void SayHello()
        {
            Console.WriteLine($"Привет! Я {Name}, учусь в {University}.");
        }
    }
}
