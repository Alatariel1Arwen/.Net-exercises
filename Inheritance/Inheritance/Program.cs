
using Inheritance;

public class Program
{
    public static void Main(string[] args)
    {
        Dog dog = new Dog();
        dog.Name = "Ciro";
        dog.Age = "3";
        dog.Speak();

        Cat cat = new Cat();
        cat.Name = "Immobile";
        cat.Age = "6";
        cat.Speak();

        Horse horse = new Horse();
        horse.Name = "Artex";
        horse.Age = "9";
        horse.Speak();

    }
    

}
