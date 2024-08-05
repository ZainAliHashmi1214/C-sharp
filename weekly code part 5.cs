//simple example of classes in c sharp (including static and instance method)



//using System;

//namespace StaticAndInstanceMethods
//{

//    public class Person
//    {

//        public string FirstName { get; set; }
//        public string LastName { get; set; }
//        public int Age { get; set; }


//        public Person(string firstName, string lastName, int age)
//        {
//            FirstName = firstName;
//            LastName = lastName;
//            Age = age;
//        }

//        public void Introduce()
//        {
//            Console.WriteLine($"Hello, my name is {FirstName} {LastName} and I am {Age} years old.");
//        }


//        public static void ShowPersonCount(int count)
//        {
//            Console.WriteLine($"There are {count} persons.");
//        }
//    }


//    class Program
//    {
//        static void Main(string[] args)
//        {

//            Person person1 = new Person("John", "Doe", 30);
//            Person person2 = new Person("Jane", "Smith", 25);

//           person1.Introduce();
//            person2.Introduce();

//           Person.ShowPersonCount(2);
//        }
//    }
//}



//inheritance in c sharp & polymorphism

//using System;

//namespace InheritanceExample
//{

//    public class Animal
//    {
//            public string Name { get; set; }

//            public Animal(string name)
//        {
//            Name = name;
//        }


//        public void Eat()
//        {
//            Console.WriteLine($"{Name} is eating.");
//        }

//            public virtual void Speak()
//        {
//            Console.WriteLine($"{Name} makes a sound.");
//        }
//    }

//        public class Dog : Animal
//    {

//        public string Breed { get; set; }


//        public Dog(string name, string breed) : base(name)
//        {
//            Breed = breed;
//        }

//           public override void Speak()
//        {
//            Console.WriteLine($"{Name} barks.");
//        }


//        public void Fetch()
//        {
//            Console.WriteLine($"{Name} is fetching the ball.");
//        }
//    }


//    class Program
//    {
//        static void Main(string[] args)
//        {
//                Animal animal = new Animal("Generic Animal");
//            animal.Eat();
//            animal.Speak();

//                Dog dog = new Dog("Rex", "German Shepherd");
//            dog.Eat();
//            dog.Speak(); 
//            dog.Fetch(); 
//        }
//    }
//}

//             Method hiding in c sharp
//using System;

//namespace MethodHidingExample
//{
   
//    public class Animal
//    {
        
//        public void Speak()
//        {
//            Console.WriteLine("The animal makes a sound.");
//        }
//    }

   
//    public class Dog : Animal
//    {
   
//        public new void Speak()
//        {
//            Console.WriteLine("The dog barks.");
//        }
//    }

    
//    class Program
//    {
//        static void Main(string[] args)
//        {
    
//            Animal myAnimal = new Animal();
//            myAnimal.Speak();

//            Dog myDog = new Dog();
//            myDog.Speak();    

//            Animal myAnimalDog = new Dog();
//            myAnimalDog.Speak(); 
//        }
//    }
//}
