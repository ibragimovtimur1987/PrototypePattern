namespace PrototypePattern;

public class Mammal : Animal, IMyCloneable<Mammal>, ICloneable
{
    public string FurColor { get; set; }
        
    // Основной конструктор.
    public Mammal(string name, int age, string furColor)
        : base(name, age)
    {
        FurColor = furColor;
    }

    // Копирующий конструктор с вызовом родительского конструктора.
    public Mammal(Mammal source)
        : base(source)
    {
        FurColor = source.FurColor;
    }

    // Переопределение метода Clone для клонирования Mammal.
    public override Mammal Clone()
    {
        return new Mammal(this);
    }

    // Реализация стандартного ICloneable.
    object ICloneable.Clone()
    {
        return Clone();
    }

    public override string ToString()
    {
        return $"Mammal: {Name}, Age: {Age}, FurColor: {FurColor}";
    }
}