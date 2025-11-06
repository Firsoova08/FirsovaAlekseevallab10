using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirsovaAlekseevalab10
{
    abstract class Animal
    {
        public string? Name { get; set; }

      public abstract void MakeSound();
        // Обычный метод можно тоже добавить
        public void Info() => Console.WriteLine($"Животное: {Name}");
    }
}
