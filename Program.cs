namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("кости", "дворе", "овчарка");
            Cat cat = new Cat("рыба", "квартире", true);
            Horse horse = new Horse("сено", "стойле", 20);

            Veterinarian vet = new Veterinarian();
            vet.treatAnimal(dog);
            vet.treatAnimal(cat);
            vet.treatAnimal(horse);

            dog.makeNoise();
            cat.makeNoise();
            horse.makeNoise();

            dog.eat();
            cat.eat();
            horse.eat();
        }
    }
    public class Animal
    {
        public string location { get; set; }
        public string food { get; set; }
        public Animal(string food, string location)
        {
            this.food = food;
            this.location = location;
        }

        public virtual void makeNoise()
        {

        }

        public virtual void eat()
        {
        }

        public void sleep()
        {

        }
    }

    public class Dog : Animal
    {
        private string breed;

        public Dog(string food, string location, string breed) : base(food, location)
        {
            this.breed = breed;
        }

        public override void makeNoise()
        {
            Console.WriteLine("Собака лает");
        }

        public override void eat()
        {
            Console.WriteLine("Собака кушает " + food);
        }
    }

    public class Cat : Animal
    {
        private bool hasClaws;

        public Cat(string food, string location, bool hasClaws) : base(food, location)
        {
            this.hasClaws = hasClaws;
        }

        public override void makeNoise()
        {
            Console.WriteLine("Кошка мурлычет");
        }

        public override void eat()
        {
            Console.WriteLine("Кошка кушает " + food);
        }
    }

    public class Horse : Animal
    {
        private int speed;

        public Horse(string food, string location, int speed) : base(food, location)
        {
            this.speed = speed;
        }

        public override void makeNoise()
        {
            Console.WriteLine("Лошадь кричит как-то иго-го-го");
        }

        public override void eat()
        {
            Console.WriteLine("Лошадь кушает " + food);
        }
    }

    public class Veterinarian
    {
        public void treatAnimal(Animal animal)
        {
            Console.WriteLine($"Животное ест {animal.food} и находится в {animal.location}");
        }
    }
}
