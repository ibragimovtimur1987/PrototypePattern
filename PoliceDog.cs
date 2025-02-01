namespace PrototypePattern;

// Класс PoliceDog – наследник Dog, с дополнительным свойством BadgeNumber.
public class PoliceDog : Dog, IMyCloneable<PoliceDog>, ICloneable
{
    public int BadgeNumber { get; set; }
    // Основной конструктор.
    public PoliceDog(string name, int age, string furColor, string breed, int badgeNumber)
        : base(name, age, furColor, breed)
    {
        BadgeNumber = badgeNumber;
    }
        
    // Копирующий конструктор с вызовом родительского конструктора.
    public PoliceDog(PoliceDog source)
        : base(source)
    {
        BadgeNumber = source.BadgeNumber;
    }
        
    // Переопределение метода Clone.
    public override PoliceDog Clone()
    {
        return new PoliceDog(this);
    }

    // Реализация стандартного ICloneable.
    object ICloneable.Clone()
    {
        return Clone();
    }

    public override string ToString()
    {
        return $"PoliceDog: {Name}, Age: {Age}, FurColor: {FurColor}, Breed: {Breed}, BadgeNumber: {BadgeNumber}";
    }
}