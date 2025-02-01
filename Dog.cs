namespace PrototypePattern;

// Класс Dog – наследник Mammal, с дополнительным свойством Breed.
public class Dog : Mammal, IMyCloneable<Dog>, ICloneable
{
    public string Breed { get; set; }
        
    // Основной конструктор.
    public Dog(string name, int age, string furColor, string breed)
        : base(name, age, furColor)
    {
        Breed = breed;
    }
        
    // Копирующий конструктор с вызовом базового конструктора.
    public Dog(Dog source)
        : base(source)
    {
        Breed = source.Breed;
    }
        
    // Переопределение метода Clone.
    public override Dog Clone()
    {
        return new Dog(this);
    }

    // Реализация стандартного ICloneable.
    object ICloneable.Clone()
    {
        return Clone();
    }

    public override string ToString()
    {
        return $"Dog: {Name}, Age: {Age}, FurColor: {FurColor}, Breed: {Breed}";
    }
}