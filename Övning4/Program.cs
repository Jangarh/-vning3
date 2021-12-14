using Övning3;

internal    class Program
{

    static void Main(string[] args)
    {
        //PersonHandler ph = new();
        //var ph = new PersonHandler();

        //try
        //{
        //    ph.CreatePerson("Kristina", "Österman", 0);
        //}
        //catch (Exception error)
        //{
        //    Console.WriteLine(error.Message); ;
        //}


        //ph.SeedPeople();
        //ph.PrintAllPersons();

        //------------------------------

        var animal1 = new Pelican("Pelle Pelikan", 3, 2, "Brun", true);
        Console.WriteLine(animal1.Stats());

        //var animals = new List<string>()
        //{
        //   "Dog", "Horse", "Wolf", "Worm"
        //};
        //foreach (var animal in animals)
        //    Console.WriteLine(animal);

        // var uerror = new List<UserError>()
        // {
        // 
        // };
        //
        // try
        // {
        //    //var person = new Person(20, "Sam", "ee", 172, 80);
        //    //person.FName = "K";
        //    //Console.WriteLine($"Your name is: {person.FName} {person.LName}, age: {person.Age}, hight is: {person.Height} weight is: {person.Weight}");
        //
        // }
        // catch (Exception ex)
        // {
        //     Console.WriteLine(ex.Message);
        // }
        //
        // Console.ReadKey();

    }

}







