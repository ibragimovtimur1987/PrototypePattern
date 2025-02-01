namespace PrototypePattern;
    public class Animal : IMyCloneable<Animal>, ICloneable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        
        // Основной конструктор.
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Копирующий конструктор.
        public Animal(Animal source)
        {
            Name = source.Name;
            Age = source.Age;
        }

        // Метод Clone, реализующий IMyCloneable.
        public virtual Animal Clone()
        {
            return new Animal(this);
        }

        // Реализация стандартного ICloneable.
        object ICloneable.Clone()
        {
            return Clone();
        }

        public override string ToString()
        {
            return $"Animal: {Name}, Age: {Age}";
        }
    }