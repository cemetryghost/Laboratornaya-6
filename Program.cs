namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Чаппи", "будке", "Мухтар", 5);
            Cat cat = new Cat("Вискас", "доме", "Мгла", "Белый");
            Horse horse = new Horse("Сено", "загоне", "Пегас", "Новые подковы");
            Vet vet = new Vet();

            vet.treatAnimal(dog);
            vet.treatAnimal(cat);
            vet.treatAnimal(horse);

            dog.makeNoise();
            dog.eat();
            dog.sleep();

            cat.makeNoise();
            cat.eat();
            cat.sleep();

            horse.makeNoise();
            horse.eat();
            horse.sleep();
        }
    }
    
    class Animal
    {
        public string food, location;

        public Animal(string food, string location)
        {
            this.food = food;
            this.location = location;
        }

        public virtual void makeNoise() { }
        public virtual void eat() { }
        public virtual void sleep() { }
    }
    
    class Dog : Animal
    {
        public string name;
        public int age;
        public Dog(string food, string location, string name, int age) : base(food, location)
        {
            this.name = name;
            this.age = age;
        }

        public override void makeNoise() => Console.WriteLine("Собака издает звук: Гааав!");
        public override void eat() => Console.WriteLine("Собака ест: " + food);
        public override void sleep() => Console.WriteLine("Собака - спит");
    }
    
    class Cat : Animal
    {
        public string name, color;

        public Cat(string food, string location, string name, string color) : base(food, location)
        {
            this.name = name;
            this.color = color;
        }
        public override void makeNoise() => Console.WriteLine("Кот издает звук: Муyyр!");
        public override void eat() => Console.WriteLine("Кот ест " + food);
        public override void sleep() => Console.WriteLine("Кот - спит");
    }
    
    class Horse : Animal
    {
        public string name, horseshoe;

        public Horse(string food, string location, string name, string horseshoe) : base(food, location)
        {
            this.name = name;
            this.horseshoe = horseshoe;
        }
        public override void makeNoise() => Console.WriteLine("Лошадь издает звук: Иго-го-го!");
        public override void eat() => Console.WriteLine("Лошадь ест " + food);
        public override void sleep() => Console.WriteLine("Лошадь - спит");
    }
    
    class Vet
    {
        public void treatAnimal(Animal animal) => Console.WriteLine($"Животное ест: {animal.food}, а находится в {animal.location}");
    }
}

