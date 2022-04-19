using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.DSA.AnimalsShelterQueue
{
    public class AnimalShelter
    {
        public int ID { get; set; }
        public string Name { get; set; }

        private Queue<Animal> Animals = new Queue<Animal>();
        private Queue<Animal> TempQueue = new Queue<Animal>();

        public AnimalShelter(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }
        public void Enqueue(Animal animal)
        {
            Animals.Enqueue(animal);
        }
        public Queue<Animal> GetAnimals()
        {
            return Animals;
        }
        public Animal Dequeue(string type)
        {
            try
            {
                if (Animals.Count < 1)
                {
                    throw new Exception("The queue is empty!");
                }
                else
                {
                    Animal temp;
                    while (Animals.Count > 0)
                    {
                        temp = Animals.Peek();
                        if (temp.Type == type)
                        {
                            break;
                        }
                        else
                        {
                            TempQueue.Enqueue(Animals.Dequeue());
                        }
                    }
                    if (Animals.Count > 0)
                    {
                        temp = Animals.Dequeue();
                        while (Animals.Count > 0)
                        {
                            TempQueue.Enqueue(Animals.Dequeue());
                        }
                        while (TempQueue.Count > 0)
                        {
                            Animals.Enqueue(TempQueue.Dequeue());
                        }
                        return temp;
                    }
                    else
                    {
                        while (TempQueue.Count > 0)
                        {
                            Animals.Enqueue(TempQueue.Dequeue());
                        }
                        return null;
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public abstract string Type { get; }

        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
    public class Dog : Animal
    {
        public override string Type
        {
            get
            {
                return "dog";
            }
        }
        public Dog(string name, int age) : base(name, age)
        { }
    }
    public class Cat : Animal
    {
        public override string Type
        {
            get
            {
                return "cat";
            }
        }
        public Cat(string name, int age) : base(name, age)
        { }
    }
}