using PrototypePattern;

Console.WriteLine("=== Демонстрация клонирования объектов ===\n");

// Создаём исходные объекты
var animal = new Animal("Generic animal", 5);
var mammal = new Mammal("Mammal Mary", 3, "Brown");
var dog = new Dog("Buddy", 4, "Black", "Labrador");
var policeDog = new PoliceDog("Rex", 6, "Black", "German Shepherd", 101);

// Клонирование через методы IMyCloneable<T>
var animalClone = animal.Clone();
var mammalClone = mammal.Clone();
var dogClone = dog.Clone();
var policeDogClone = policeDog.Clone();

// Клонирование через стандартный интерфейс ICloneable с приведением типа
var animalClone2 = ((ICloneable)animal).Clone() as Animal;
var mammalClone2 = ((ICloneable)mammal).Clone() as Mammal;
var dogClone2 = ((ICloneable)dog).Clone() as Dog;
var policeDogClone2 = ((ICloneable)policeDog).Clone() as PoliceDog;

// Изменяем исходные объекты, чтобы проверить независимость клонов
animal.Name = "Changed animal";
mammal.FurColor = "White";
dog.Breed = "Poodle";
policeDog.BadgeNumber = 999;

// Вывод результатов клонирования для IMyCloneable<T>
Console.WriteLine("Клоны, созданные через IMyCloneable<T>:");
Console.WriteLine("Оригинальный Animal: " + animal);
Console.WriteLine("Клон Animal:      " + animalClone);
Console.WriteLine();
Console.WriteLine("Оригинальный Mammal: " + mammal);
Console.WriteLine("Клон Mammal:       " + mammalClone);
Console.WriteLine();
Console.WriteLine("Оригинальный Dog: " + dog);
Console.WriteLine("Клон Dog:         " + dogClone);
Console.WriteLine();
Console.WriteLine("Оригинальный PoliceDog: " + policeDog);
Console.WriteLine("Клон PoliceDog:        " + policeDogClone);

Console.WriteLine("\n----------------------------------------------\n");

// Вывод результатов клонирования для ICloneable
Console.WriteLine("Клоны, созданные через ICloneable:");
Console.WriteLine("Оригинальный Animal: " + animal);
Console.WriteLine("Клон Animal:      " + animalClone2);
Console.WriteLine();
Console.WriteLine("Оригинальный Mammal: " + mammal);
Console.WriteLine("Клон Mammal:       " + mammalClone2);
Console.WriteLine();
Console.WriteLine("Оригинальный Dog: " + dog);
Console.WriteLine("Клон Dog:         " + dogClone2);
Console.WriteLine();
Console.WriteLine("Оригинальный PoliceDog: " + policeDog);
Console.WriteLine("Клон PoliceDog:        " + policeDogClone2);

Console.WriteLine("\nНажмите любую клавишу для выхода...");
Console.ReadKey();