using Övning4;

var animals = new List<string>()
{
    "Dog", "Horse", "Wolf", "Worm"
};
foreach (var animal in animals)
    Console.WriteLine(animal);

var uerror = new List<UserError>()
{
    
};

try
{
   //var person = new Person(20, "Sam", "ee", 172, 80);
   //person.FName = "K";
   //Console.WriteLine($"Your name is: {person.FName} {person.LName}, age: {person.Age}, hight is: {person.Height} weight is: {person.Weight}");

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.ReadKey();





