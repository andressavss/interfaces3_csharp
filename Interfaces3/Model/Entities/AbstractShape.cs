using System;
using Interfaces3.Model.Enums;

namespace Interfaces3.Model.Entities
{
    internal abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
