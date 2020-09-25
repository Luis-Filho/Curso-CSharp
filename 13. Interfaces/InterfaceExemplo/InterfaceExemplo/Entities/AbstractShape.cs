using InterfaceExemplo.Enums;

namespace InterfaceExemplo.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
