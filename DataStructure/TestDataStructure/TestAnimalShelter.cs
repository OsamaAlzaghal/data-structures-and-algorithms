using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using DataStructure.DSA.AnimalsShelterQueue;

namespace TestDataStructure
{
    public class TestAnimalShelter
    {
        [Fact]
        public void TestEnqueue()
        {
            AnimalShelter animalShelter = new AnimalShelter(1, "Irbid Shelter");
            Cat cat1 = new Cat("Lucy", 2);
            Cat cat2 = new Cat("Meme", 3);
            animalShelter.Enqueue(cat1);
            animalShelter.Enqueue(cat2);
            Assert.Equal(cat1.Name, animalShelter.GetAnimals().Peek().Name);
        }

        [Fact]
        public void TestDequeue()
        {
            AnimalShelter animalShelter = new AnimalShelter(1, "Irbid Shelter");
            Cat cat1 = new Cat("Lucy", 2);
            Cat cat2 = new Cat("Sara", 4);
            Dog dog1 = new Dog("Rex", 5);
            animalShelter.Enqueue(cat1);
            animalShelter.Enqueue(cat2);
            animalShelter.Enqueue(dog1);
            Assert.Equal(dog1.Name, animalShelter.Dequeue("dog").Name);
            Assert.Equal(cat1.Name, animalShelter.Dequeue("cat").Name);
        }

        [Fact]
        public void TestDequeueAnimalNotInShelter()
        {
            AnimalShelter animalShelter = new AnimalShelter(1, "Irbid Shelter");
            Cat cat1 = new Cat("Lucy", 2);
            Cat cat2 = new Cat("Sara", 4);
            Dog dog1 = new Dog("Rex", 5);
            animalShelter.Enqueue(cat1);
            animalShelter.Enqueue(cat2);
            animalShelter.Enqueue(dog1);
            Assert.Null(animalShelter.Dequeue("bird"));
        }

        [Fact]
        public void TestDequeueEmptyShelter()
        {
            AnimalShelter animalShelter = new AnimalShelter(1, "Irbid Shelter");
            Assert.Null(animalShelter.Dequeue("dog"));
        }
    }
}