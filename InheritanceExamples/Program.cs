// See https://aka.ms/new-console-template for more information

using InheritanceExamples;
using InheritanceExamples.AnimalSimulator;
using InheritanceExamples.Contracts;
using InheritanceExamples.TransportationSimulator;

//List<Animal> zoo = new List<Animal>();

//Animal anAnimal = new Tiger();
//zoo.Add(anAnimal);
//zoo.Add(new Duck());
//zoo.Add(new Elephant());
//zoo.Add(new Parrot());
//zoo.Add(new Duck());
//zoo.Add(new Eagle());
//zoo.Add(new HummingBird());

//foreach (var animal in zoo)
//{
//    Console.WriteLine(animal.Speak());
//}

//Animal animal1 = new Eagle();

//Bird eagle = new Eagle();
//eagle.Speak();

//Calculator calc = new Calculator();

//calc.Add(1, 2);


//List<IFlyable> flyingObjects = new List<IFlyable>();
//flyingObjects.Add(new Eagle());
//flyingObjects.Add(new Peacok());
//flyingObjects.Add(new Aeroplane());
//flyingObjects.Add(new Rocket());

//foreach (var flyingObject in flyingObjects)
//{
//    Console.WriteLine(flyingObject.Fly());
//}

People dhakaPeople = new People();
dhakaPeople.AddPerson(new Person() {
    FirstName ="Mr. A",
    LastName = "B"
}
);
dhakaPeople.AddPerson(new Person()
{
    FirstName = "Mr. 2",
    LastName = "B"
}
);

dhakaPeople.AddPerson(new Person()
{
    FirstName = "Mr. 3",
    LastName = "B"
}
);



foreach (var person in dhakaPeople)
{
    Console.WriteLine(person.GetFullName());
}



Console.WriteLine("Hello, World!");
